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
    public partial class Add_String_Here : Form
    {
        public Add_String_Here()
        {
            InitializeComponent();
        }

        private void Add_String_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Enabled==true)
            {
                if (checkBox2.Checked == true) { Contructor_Args.Enabled = true; }
                else { Contructor_Args.Enabled = false; }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { Value_Box.Enabled = true; }
            else { Value_Box.Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) { checkBox2.Enabled = true; }
            else { checkBox2.Enabled = false; Contructor_Args.Enabled = false; }
        }

        int i = 0;
        private void add_button_Click(object sender, EventArgs e)
        {
            if(ID_Box.Text!="")
            {
                String id = ID_Box.Text, const_args = "", val = "", declaration = "";
                if(checkBox3.Checked)
                {
                    if(checkBox2.Checked==true && checkBox1.Checked==true)
                    {
                        const_args = Contructor_Args.Text;
                        if (Value_Box.Text == "") { val = "\"\""; }
                        else { val = Value_Box.Text; }
                        declaration = "String " + id + " = new String(" + const_args + ");" + "\n" + id + " = " + val + ";"; 
                    }
                    else if (checkBox2.Checked == true && checkBox1.Checked == false)
                    {
                        const_args = Contructor_Args.Text;
                        declaration = "String " + id + " = new String(" + const_args + ");";
                    }
                    else if (checkBox2.Checked == false && checkBox1.Checked == true)
                    {
                        if (Value_Box.Text == "") { val = "\"\""; }
                        else { val = Value_Box.Text; }
                        declaration = "String " + id + " = new String();" + "\n" + id + " = " + val + ";";
                    }
                    else if (checkBox2.Checked == false && checkBox1.Checked == false)
                    {
                        if (Value_Box.Text == "") { val = "\"\""; }
                        else { val = Value_Box.Text; }
                        declaration = "String " + id + " = new String();";
                    }
                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        if (Value_Box.Text == "") { val = "\"\""; }
                        else { val = Value_Box.Text; }
                        declaration = "String " + id + " = " + val + ";";
                    }
                    else if (checkBox1.Checked == false)
                    {
                        declaration = "String " + id + ";";
                    }
                }

                if (Add_New_Line.Checked == true) { declaration += "\n"; }
                MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                i++;
                ID_Box.Text = "$" + i;
            }
            else 
            { MessageBox.Show("Enter a valid Identifier"); }
        }
        
        private void ID_Box_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
