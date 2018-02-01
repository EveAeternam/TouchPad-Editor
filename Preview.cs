using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchPad_UI_Editor
{
    public partial class Preview : Form
    {
        //MainWindow editor = new MainWindow();

        public Preview()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Preview_Load(object sender, EventArgs e)
        {

        }

        private void RefreshPrev()
        {
            //pb_prevBg.BackColor = editor.tft_bgColor;
        }

        public void SetBgColor (Color bg)
        {
            pb_preview.BackColor = bg;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPrev();
        }
    }
}
