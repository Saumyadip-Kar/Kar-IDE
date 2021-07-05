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
    public partial class Add_Wrapper_Type : Form
    {
        public Add_Wrapper_Type()
        {
            InitializeComponent();
        }

        int i = 0;
        private void add_button_Click(object sender, EventArgs e)
        {
            String type = "Integer", id = "", val, declaration;
            switch (Type_Box.SelectedIndex)
            {
                case 0:
                    type = "Byte";
                    break;
                case 1:
                    type = "Short";
                    break;
                case 2:
                    type = "Character";
                    break;
                case 3:
                    type = "Integer";
                    break;
                case 4:
                    type = "Long";
                    break;
                case 5:
                    type = "Float";
                    break;
                case 6:
                    type = "Double";
                    break;
                case 7:
                    type = "Boolean";
                    break;
            }

            if (ID_Box.Text == "")
            {
                MessageBox.Show("Provide a Valid Identifier Name");
            }
            else
            {
                id = ID_Box.Text;


                if (Value_Check.Checked == true)
                {
                    val = Value_Box.Text;
                    declaration = type + " " + id + " = " + type+".valueOf(" +val+ ");";
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

        private void Add_Wrapper_Type_Load(object sender, EventArgs e)
        {
            Type_Box.SelectedIndex = 3;
            Value_Box.Enabled = false;
        }

        private void Value_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Value_Check.Checked == true)
            {
                Value_Box.Enabled = true;
            }
            else
            {
                Value_Box.Enabled = false;
            }
        }
    }
}
