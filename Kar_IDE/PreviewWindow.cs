using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;

namespace Kar_IDE
{
    public partial class PreviewWindow : Form
    {
        public PreviewWindow()
        {
            InitializeComponent();
        }
        
        

        private void PreviewWindow_Load(object sender, EventArgs e)
        {
            TextEditorControl t = new TextEditorControl();
            t.Dock = DockStyle.Fill;
            t.SetHighlighting("Java");
            panel1.Controls.Add(t);
        }

        
    }
}
