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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            MainWindow mw1 = new MainWindow();
            mw1.Show();
        }

        private void login2_Click(object sender, EventArgs e)
        {
            PreviewWindow p = new PreviewWindow();
            p.Show();
            Web_Browser w = new Web_Browser();
            w.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
