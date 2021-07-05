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
    public partial class Web_Browser : Form
    {
        WebBrowser webBrowser = new WebBrowser();
        public Web_Browser()
        {
            InitializeComponent();
        }
        

        private void Web_Browser_Load(object sender, EventArgs e)
        {
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Dock = DockStyle.Fill;
            panel1.Controls.Add(webBrowser);
            webBrowser.Navigate("bing.com");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
