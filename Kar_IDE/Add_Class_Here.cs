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
    public partial class Add_Class_Here : Form
    {
        public Add_Class_Here()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { c_params.Enabled = true; }
            else { c_params.Enabled = false; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { super_class.Enabled = true; }
            else { super_class.Enabled = false; }
        }

        int i = 0;
        private void add_button_Click(object sender, EventArgs e)
        {
            if (ID_Box.Text != "")
            {
                String id = ID_Box.Text, superclass = "", cons_params = "", declaration = "";
                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    if (super_class.Text == "") { MessageBox.Show("Enter the name of the superclass"); }
                    else
                    {
                        superclass = super_class.Text;
                        cons_params = c_params.Text;
                        declaration = "class " + id + " extends " + superclass + "{\n"+ id +"("+cons_params+"){\nsuper();\n//Write Your Code Here\n}\n"+"//Write the class Definition here"+"\n};"; 
                    }
                }
                else if(checkBox1.Checked == true && checkBox2.Checked == false)
                {
                    if (super_class.Text == "") { MessageBox.Show("Enter the name of the superclass"); }
                    else
                    {
                        superclass = super_class.Text;
                        declaration = "class " + id + " extends " + superclass + "{\n" + "//Write the class Definition here" + "\n};";
                    }
                }
                else if (checkBox1.Checked == false && checkBox2.Checked == true)
                {
                        cons_params = c_params.Text;
                        declaration = "class " + id +  "{\n" + id+ "(" + cons_params + "){\n//Write Your Code Here\n}\n" + "//Write the class Definition here" + "\n};";
                }
                else if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                        declaration = "class " + id + "{\n" + "//Write the class Definition here" + "\n};";
                }

                if (Add_New_Line.Checked == true) { declaration += "\n"; }
                MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                i++;
                ID_Box.Text = "$" + i;

            }
            else
            { MessageBox.Show("Enter a valid Identifier"); }
        }
    }
}
