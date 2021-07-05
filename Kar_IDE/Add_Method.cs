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
    public partial class Add_Method : Form
    {
        public Add_Method()
        {
            InitializeComponent();
        }

        int i = 0;
        private void pCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (pCheck.Checked == true) { param.Enabled = true; }
            else { param.Enabled = false; }
        }

        private void Add_Method_Load(object sender, EventArgs e)
        {
            ret.Text = "void";
            ID_Box.Text = "M" + i;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (ID_Box.Text != "")
            {
                if (ret.Text != "")
                {
                    String declaration = "", id = ID_Box.Text, r = ret.Text, p = "";
                    if(pCheck.Checked==true)
                    {
                        p = param.Text;
                        declaration = r + " " + id + "(" + p + "){\n" + "//Write Method Definition Here" + "\n};";
                    }
                    else
                    {
                        declaration = r + " " + id + "(){\n" + "//Write Method Definition Here" + "\n};";
                    }
                    if (Add_New_Line.Checked == true) { declaration += "\n"; }
                    MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                    i++;
                    ID_Box.Text = "M" + i;
                }
                else
                { MessageBox.Show("Enter a valid return type"); }
            }
            else
            { MessageBox.Show("Enter a valid Identifier"); }
        }
    }
}
