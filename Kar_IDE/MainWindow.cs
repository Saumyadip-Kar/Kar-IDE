using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime;
using System.Diagnostics;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;



namespace Kar_IDE
{
    public partial class MainWindow : Form
    {
        public static MainWindow instance;

        private const int grip = 16;// To Resize the Window without any Border
        private const int caption = 32;// To Resize the Window without any Border
        private bool dragging = false;
        private Point StartPosition1 = new Point(0, 0);
     
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            this.FormBorderStyle = FormBorderStyle.None;// To Resize the Window without any Border
            this.DoubleBuffered = true;// To Resize the Window without any Border
            this.SetStyle(ControlStyles.ResizeRedraw, true);// To Resize the Window without any Border
            

        }


        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Form1.instance.Hide();
        }

        ComboBox cb = new ComboBox();
       


  






        // To Resize the Window without any Border***************************************************************************
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle r = new Rectangle(this.ClientSize.Width - grip, this.ClientSize.Height - grip, grip, grip);
            ControlPaint.DrawSizeGrip(e.Graphics,Color.DodgerBlue, r);
            r = new Rectangle(0, 0, this.ClientSize.Width, caption);
            e.Graphics.FillRectangle(Brushes.DodgerBlue, r);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            { 
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y < caption)
                {
                    m.Result = (IntPtr)2; 
                    return;
                }
                if (p.X >= this.ClientSize.Width - grip && p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)17; 
                    return;
                }
            }
            base.WndProc(ref m);
        }
    // To Resize the Window without any Border***************************************************************************









    // To Move the window with controller***************************************************************************
    private void Controller_MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            StartPosition1 = new Point(e.X, e.Y);
        }

        private void Controller_MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Controller_MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging == true)
            {
                Point p1 = PointToScreen(e.Location);
                Location = new Point(p1.X - this.StartPosition1.X, p1.Y - this.StartPosition1.Y);
            }
        }
        // To Move the window with controller***************************************************************************






        // Variables to Determine the behaviors
        
        static int max_tabs_allowed = 20;
        static int tab_no = 0;
        String[] file_types = new String[max_tabs_allowed];
        String[] file_paths = new String[max_tabs_allowed];
        String[] file_paths_without_type = new String[max_tabs_allowed];
        String[] file_names = new String[max_tabs_allowed];
        String[] file_names_without_type = new String[max_tabs_allowed];
        String[] file_directories = new String[max_tabs_allowed];
        String[] languages = new String[max_tabs_allowed];

        //===================================================

        private void SetFileInfo(String FilePath, int index)
        {
            String slash = @"\";
            file_paths[index] = FilePath;
            file_types[index] = Path.GetExtension(file_paths[index]).ToString();
            file_names[index] = Path.GetFileName(file_paths[index]).ToString();
            file_names_without_type[index] = Path.GetFileNameWithoutExtension(file_paths[index]).ToString();
            file_directories[index] = Path.GetDirectoryName(file_paths[index]).ToString();
            file_paths_without_type[index] = file_directories[index] + slash + file_names_without_type[index];
        }

        private String[] GetFileInfo(int index)
        {
            String[] info = { file_paths[index] , file_types[index] , file_names[index] , file_names_without_type[index], file_directories[index] , file_paths_without_type[index] };
            return info;
        }

        private void DeleteFileInfo(int index)
        {
            file_paths[index] = "";
            file_types[index] = "";
            file_names[index] = "";
            file_names_without_type[index] = "";
            file_directories[index] = "";
            file_paths_without_type[index] = "";

        }



        //Text Editor

        private void SetEditBox(String lang)
        {
            tab_no++;
            TabPage tp = new TabPage("Doc-" + tab_no);
            TextEditorControl rtb = new TextEditorControl();
            rtb.Dock = DockStyle.Fill;
            rtb.Height = tabControl1.Height;
            rtb.Width = tabControl1.Width;
            rtb.BackColor = Color.White;
            rtb.SetHighlighting(lang);
            //rtb.EnableFolding = true;
            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedTab = tp;
        }

        public TextEditorControl GetEditBox()
        {
            TextEditorControl rtb = null;
            TabPage tp = tabControl1.SelectedTab;
            if (tp != null)
            {
                rtb = tp.Controls[0] as TextEditorControl;
            }
            return rtb;
        }

        private void DeleteEditBox()
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            if(current_index >= 0) 
            {
            DeleteFileInfo(current_index);
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            tab_no--;
            if (tab_no != 0) 
            {
                tabControl1.SelectedTab = tabControl1.TabPages[tab_no - 1];
            }
            }
        }









        private void New_Menu_Click(object sender, EventArgs e)
        {
            SetEditBox("XML");
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            DeleteFileInfo(current_index);
        }

        private void Close_Menu_Click(object sender, EventArgs e)
        {
            DeleteEditBox();
            DeleteFileInfo(tab_no);
        }

        private void Open_Menu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "java files (*.java)|*.java|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetEditBox("Java");
                GetEditBox().Text = "";
                GetEditBox().Text = File.ReadAllText(ofd.FileName);
                String file1 = ofd.FileName.ToString();
                int id = tab_no - 1;
                SetFileInfo(file1, id);
                tabControl1.SelectedTab.Text = file_names[tab_no - 1];
            }
        }

        private void SaveAs_Menu_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            if (current_index >= 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "java files (*.java)|*.java|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(sfd.FileName, FileMode.Append))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(GetEditBox().Text);
                        SetFileInfo(sfd.FileName, current_index);
                        tabControl1.SelectedTab.Text = file_names[current_index];
                    }

                }
            }
        }

        private void Save_Menu_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            if (current_index >= 0)
            {
                if (file_paths[current_index] == "")
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream s = File.Open(sfd.FileName, FileMode.Append))
                        using (StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write(GetEditBox().Text);
                            SetFileInfo(sfd.FileName, current_index);
                            tabControl1.SelectedTab.Text = file_names[current_index];
                        }
                    }
                }
                else
                {
                    using (Stream s = File.Open(file_paths[current_index], FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(GetEditBox().Text);
                        tabControl1.SelectedTab.Text = file_names[current_index];
                    }
                }
            }

            
        }




























        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void status_bar_MainWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Left_Panel_MainWindow_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cont1_size_changed(object sender, PaintEventArgs e)
        {
            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void splitContainer5_Panel1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void Quit_Button_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Maximize_Button_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Minimize_Button_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Quit_Button_MouseEnter(object sender, EventArgs e)
        {
            Quit_Button.BackColor = Color.Red;
        }

        private void Maximize_Button_MouseEnter(object sender, EventArgs e)
        {
            Maximize_Button.BackColor = Color.Yellow;
        }

        private void Minimize_Button_MouseEnter(object sender, EventArgs e)
        {
            Minimize_Button.BackColor = Color.Aquamarine;
        }

        private void Quit_Button_MouseLeave(object sender, EventArgs e)
        {
            Quit_Button.BackColor = Color.DodgerBlue;
        }

        private void Maximize_Button_MouseLeave(object sender, EventArgs e)
        {
            Maximize_Button.BackColor = Color.DodgerBlue;
        }

        private void Minimize_Button_MouseLeave(object sender, EventArgs e)
        {
            Minimize_Button.BackColor = Color.DodgerBlue;
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
           if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
           else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }









        private void Run_Button_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;

            if (current_index >= 0)
            {
                if (file_types[current_index] == ".java")
                {
                    Process p1 = new Process();
                    String p1_path = @"C:\Program Files\Common Files\Oracle\Java\javapath\java.exe";
                    String working_directory = file_directories[current_index];
                    String args = file_names[current_index];
                    if (File.Exists(p1_path))
                    {
                        if (file_paths[current_index] != "")
                        {
                            p1.StartInfo.FileName = p1_path;
                            p1.StartInfo.WorkingDirectory = working_directory;
                            p1.StartInfo.Arguments = args;
                            p1.StartInfo.CreateNoWindow = false;
                            p1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            p1.StartInfo.UseShellExecute = true;
                            p1.StartInfo.ErrorDialog = true;
                            p1.Start();
                            TestBox.Text = p1.ProcessName;
                            ErrorBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Save the File at First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Properly Mention JRE Path");
                    }
                }
                else if (file_types[current_index] == ".html" || file_types[current_index] == ".htm")
                {
                    
                    
                        if (file_paths[current_index] != "")
                        {
                        String url = "http://www.google.com";
                        Process.Start(url);
                        }
                        else
                        {
                            MessageBox.Show("Save the File at First");
                        }
                }
            }
            else
            {
                MessageBox.Show("No File is Opened");
            }
            

        }

        private void Compile_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            if (current_index >= 0)
            {
                if (file_types[current_index] == ".java")
                {
                    Process p1 = new Process();
                    String p1_path = @"C:\Program Files\Common Files\Oracle\Java\javapath\javac.exe";
                    String working_directory = file_directories[current_index];
                    String args = file_names[current_index];
                    if (File.Exists(p1_path))
                    {
                        if (file_paths[current_index] != "")
                        {
                            p1.StartInfo.FileName = p1_path;
                            p1.StartInfo.WorkingDirectory = working_directory;
                            p1.StartInfo.Arguments = args;
                            p1.StartInfo.RedirectStandardError = true;
                            p1.StartInfo.CreateNoWindow = true;
                            p1.Start();
                            ErrorBox.Text = "";
                            ErrorBox.Text = p1.StandardError.ReadToEnd();
                            if(ErrorBox.Text != "")
                            {
                                splitContainer5.SplitterDistance = 400;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Save the File at First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Properly Mention JDK Path");
                    }
                }
            }
            else
            {
                MessageBox.Show("No File is Opened");
            }

        }

        private void button3_Click(object sender, EventArgs e) //Stop Button
        {
            Process[] p = Process.GetProcesses();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].ProcessName == "java")
                {
                    p[i].Kill();
                }

            }
        }

        private void Compile_Run_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            bool success = false;

            if (current_index >= 0)
            {
                if (file_types[current_index] == ".java")
                {
                    Process p1 = new Process();
                    String p1_path = @"C:\Program Files\Common Files\Oracle\Java\javapath\javac.exe";
                    String working_directory = file_directories[current_index];
                    String args = file_names[current_index];
                    if (File.Exists(p1_path))
                    {
                        if (file_paths[current_index] != "")
                        {
                            p1.StartInfo.FileName = p1_path;
                            p1.StartInfo.WorkingDirectory = working_directory;
                            p1.StartInfo.Arguments = args;
                            p1.StartInfo.RedirectStandardError = true;
                            p1.StartInfo.CreateNoWindow = true;
                            p1.Start();
                            ErrorBox.Text = "";
                            ErrorBox.Text = p1.StandardError.ReadToEnd();
                            if (ErrorBox.Text != "")
                            {
                                splitContainer5.SplitterDistance = 400;
                            }
                            else { success = true; }

                        }
                        else
                        {
                            MessageBox.Show("Save the File at First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Properly Mention JDK Path");
                    }
                }
            }
            else
            {
                MessageBox.Show("No File is Opened");
            }
            if (success == true)
            {
                if (current_index >= 0)
                {
                    String path1 = file_paths_without_type[current_index] + ".class";
                    if (File.Exists(path1))
                    {
                        Process p1 = new Process();
                        String p1_path = @"C:\Program Files\Common Files\Oracle\Java\javapath\java.exe";
                        String working_directory = file_directories[current_index];
                        String args = file_names_without_type[current_index];
                        if (File.Exists(p1_path))
                        {
                            if (file_paths[current_index] != "")
                            {
                                p1.StartInfo.FileName = p1_path;
                                p1.StartInfo.WorkingDirectory = working_directory;
                                p1.StartInfo.Arguments = args;
                                p1.StartInfo.CreateNoWindow = false;
                                p1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                                p1.StartInfo.UseShellExecute = true;
                                p1.StartInfo.ErrorDialog = true;
                                p1.Start();
                                TestBox.Text = p1.ProcessName;
                                ErrorBox.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Save the File at First");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Properly Mention JRE Path");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Class Not Found");
                    }

                }
                else
                {
                    MessageBox.Show("Class not Found");
                }
            }


        }















        private void button1_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;
            if (current_index >= 0)
            {
                if (file_paths[current_index] == "")
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream s = File.Open(sfd.FileName, FileMode.Append))
                        using (StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write(GetEditBox().Text);
                            SetFileInfo(sfd.FileName, current_index);
                            tabControl1.SelectedTab.Text = file_names[current_index];
                        }
                    }
                }
                else
                {
                    using (Stream s = File.Open(file_paths[current_index], FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(GetEditBox().Text);
                        tabControl1.SelectedTab.Text = file_names[current_index];
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                GetEditBox().ActiveTextAreaControl.TextArea.ClipboardHandler.Copy(sender, e);
            }
        }

        private void Cut_Button_Click(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                GetEditBox().ActiveTextAreaControl.TextArea.ClipboardHandler.Cut(sender, e);
            }
        }

        private void Paste_Button_Click(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                GetEditBox().ActiveTextAreaControl.TextArea.ClipboardHandler.Paste(sender, e);
            }
        }

        private void Undo_Button_Click(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                GetEditBox().Undo();
            }
        }

        private void Redo_Button_Click(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                GetEditBox().Redo();
            }
        }
        private void Add_Item_Menu_Clicked(object sender, EventArgs e)
        {
            if (tab_no - 1 >= 0)
            {
                Add_to_Project ap = new Add_to_Project();
                ap.Show();
            }
        }


        private void restart_menu_clicked(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Run_Compiled_Class_Click(object sender, EventArgs e)
        {
            int current_index = -1;
            current_index = tabControl1.SelectedIndex;

            if (current_index >= 0)
            {
                String path1 = file_paths_without_type[current_index] + ".class";
                if (File.Exists(path1))
                {
                    Process p1 = new Process();
                    String p1_path = @"C:\Program Files\Common Files\Oracle\Java\javapath\java.exe";
                    String working_directory = file_directories[current_index];
                    String args = file_names_without_type[current_index];
                    if (File.Exists(p1_path))
                    {
                        if (file_paths[current_index] != "")
                        {
                            p1.StartInfo.FileName = p1_path;
                            p1.StartInfo.WorkingDirectory = working_directory;
                            p1.StartInfo.Arguments = args;
                            p1.StartInfo.CreateNoWindow = false;
                            p1.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                            p1.StartInfo.UseShellExecute = true;
                            p1.StartInfo.ErrorDialog = true;
                            p1.Start();
                            TestBox.Text = p1.ProcessName;
                            ErrorBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Save the File at First");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Properly Mention JRE Path");
                    }
                }
                else
                {
                    MessageBox.Show("Class not Found");
                }

            }
            else
            {
                MessageBox.Show("No File is Opened");
            }
        }
    }
        
}
