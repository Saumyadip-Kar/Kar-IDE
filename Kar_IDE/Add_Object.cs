using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kar_IDE
{
    public partial class Add_Object : Form
    {
        public Add_Object()
        {
            InitializeComponent();
        }
        int i = 0;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { Consructor_Args.Enabled = true; }
            else { Consructor_Args.Enabled = false; }
        }

        private void class_name_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void ID_Box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Object_Load(object sender, EventArgs e)
        {
            class_name.Text = "Object";
            ID_Box.Text = "obj" + i;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (ID_Box.Text != "")
            {
                if (class_name.Text != "")
                {
                    String className = class_name.Text, id = ID_Box.Text, cons = "", declaration="";
                    if(checkBox2.Checked==true)
                    {
                        cons = Consructor_Args.Text;
                        declaration = className + " " + id + " = new " + className + "(" + cons + ");";
                    }
                    else
                    {
                        declaration = className + " " + id + " = new " + className + "();";
                    }
                    if (Add_New_Line.Checked == true) { declaration += "\n"; }
                    MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                    i++;
                    ID_Box.Text = "obj" + i;

                }
                else
                { MessageBox.Show("Enter a valid Class Name"); }
            }
            else
            { MessageBox.Show("Enter a valid Identifier"); }
        }
    }
}
