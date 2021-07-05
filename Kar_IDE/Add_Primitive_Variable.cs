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
    public partial class Add_Primitive_Variable : Form
    {
        public Add_Primitive_Variable()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Value_Box.Enabled = true;
            }
            else
            {
                Value_Box.Enabled = false;
            }

        }

        private void Add_Primitive_Variable_Load(object sender, EventArgs e)
        {
            Type_Box.SelectedIndex = 3;
            Value_Box.Enabled = false;
        }

        int i = 0;
        private void add_button_Click(object sender, EventArgs e)
        {
            String type= "int", id = "", val, declaration;
            switch (Type_Box.SelectedIndex)
            {
                case 0:
                    type = "byte";
                    break;
                case 1:
                    type = "short";
                    break;
                case 2:
                    type = "char";
                    break;
                case 3:
                    type = "int";
                    break;
                case 4:
                    type = "long";
                    break;
                case 5:
                    type = "float";
                    break;
                case 6:
                    type = "double";
                    break;
                case 7:
                    type = "boolean";
                    break;
            }

            if (ID_Box.Text == "")
            {
                MessageBox.Show("Provide a Valid Identifier Name");
            }
            else
            {
                id = ID_Box.Text;


                if (checkBox1.Checked == true)
                {
                    val = Value_Box.Text;
                    declaration = type + " " + id + " = " + val + ";";
                }
                else
                {
                    declaration = type + " " + id + ";";
                }

                if (Add_New_Line.Checked == true) { declaration += "\n"; }

                MainWindow.instance.GetEditBox().ActiveTextAreaControl.TextArea.InsertString(declaration);
                i++;
                ID_Box.Text = "$" + i;
            }

        }

        private void Type_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
