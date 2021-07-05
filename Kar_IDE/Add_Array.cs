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
    public partial class Add_Array : Form
    {
        public Add_Array()
        {
            InitializeComponent();
        }

        private void Add_Array_Load(object sender, EventArgs e)
        {
            
        }

        int i = 0;
        private void add_button_Click(object sender, EventArgs e)
        {
            if (type_box.Text == "") { MessageBox.Show("Enter a Valide Type"); }
            else
            {
                if (ID_Box.Text == "") { MessageBox.Show("Enter a Valide Identifier"); }
                else
                {
                    String type = type_box.Text, id = ID_Box.Text, elm_no="",val="",declaration="";
                    
                    if(checkBox1.Checked==true && checkbox2.Checked == true)
                    {
                        elm_no = elment_no_box.Text;
                        val = Value_Box.Text;
                        declaration = type + "[] " + id + " = new " + type + "[" + elm_no + "];" + "\n" + id + " = {" + val + "};";
                    }
                    else if (checkBox1.Checked == true && checkbox2.Checked == false)
                    {
                        elm_no = elment_no_box.Text;
                        declaration = type + "[] " + id + " = new " + type + "[" + elm_no + "];";
                    }
                    else if (checkBox1.Checked == false && checkbox2.Checked == true)
                    {
                        val = Value_Box.Text;
                        declaration = type + "[] " +id + " = {" + val + "};";
                    }
                    else
                    {
                        declaration = type + "[] " + id + ";";
                    }

                    if (Add_New_Line.Checked == true) { declaration += "\n"; }

                    MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                    i++;
                    ID_Box.Text = "$" + i;

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { elment_no_box.Enabled = true; }
            else
            {
                elment_no_box.Enabled = false;
            }
        }

        private void checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox2.Checked == true) { Value_Box.Enabled = true; }
            else
            {
                Value_Box.Enabled = false;
            }
        }
    }
}
