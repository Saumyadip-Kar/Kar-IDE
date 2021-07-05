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
    public partial class Add_to_Project : Form
    {
        public Add_to_Project()
        {
            InitializeComponent();
        }

        private void Add_to_Project_Load(object sender, EventArgs e)
        {
            Selected_Item.SelectedIndex = 0;
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            switch (Selected_Item.SelectedIndex)
            {
                case 0:
                    Add_Primitive_Variable apv = new Add_Primitive_Variable();
                    apv.Show();
                    break;
                case 1:
                    Add_Wrapper_Type art = new Add_Wrapper_Type();
                    art.Show();
                    break;
                case 2:
                    Add_Array aa = new Add_Array();
                    aa.Show();
                    break;
                case 3:
                    Add_String_Here ash = new Add_String_Here();
                    ash.Show();
                    break;
                case 4:
                    Add_Class_Here ach = new Add_Class_Here();
                    ach.Show();
                    break;
                case 5:
                    Add_Object ao = new Add_Object();
                    ao.Show();
                    break;
                case 6:
                    Add_Method am = new Add_Method();
                    am.Show();
                    break;





            }
        }
    }
}
