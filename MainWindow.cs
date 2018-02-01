using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Ports;

namespace TouchPad_UI_Editor
{
    public partial class MainWindow : Form
    {
        Preview prev = new Preview();

        public string[] buttons_name = { "1", "2", "3", "4" };
        public string[] buttons_key = { "", "", "", "" };

        public string[] keycodes = { "", "", "", "" };

        public int[] tft_dimension = { 1, 1 };
        public int tft_spacing = 0;
        public Color tft_bgColor = Color.Black;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Show emulator Preview
            prev.Show();

            //Get latest Version from GitHub
            lbl_latestVer.Text = GetVersion();

            //Get the COM Ports
            GetComs();

            //Display Columns by Rows
            SetTableLayoutPrev();

            //Show Button Preview
            SetButtonPrev();

            //Populate Butoon List
            PopBtnList(buttons_name);

            //Select the first Button in list so something is selected
            lb_buttons.SelectedIndex = 0;
        }

        private void serial_arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void GetComs()
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cb_COM.Items.Add(port);
            }
        }

        private void PopBtnList(string[] btns)
        {
            foreach (string button in btns)
            {
                lb_buttons.Items.Add(button);
            }
        }

        private void btn_Auto_Click(object sender, EventArgs e)
        {
            GetComs();
        }

        private void cb_tftOrient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tftOrient.Text == "HORIZONTAL")
            {
                pb_tft.Image = Properties.Resources.tft_land;
                table_LayoutPrev.Location = new Point(120, 160);
                table_LayoutPrev.Size = new Size(260, 190);
                tb_columns.Maximum = 6;
                tb_rows.Maximum = 3;
                lbl_rez.Text = "(320 x 240)";
            } else if (cb_tftOrient.Text == "VERTICAL")
            {
                pb_tft.Image = Properties.Resources.tft_port;
                table_LayoutPrev.Location = new Point(170, 100);
                table_LayoutPrev.Size = new Size(190, 265);
                lbl_rez.Text = "(240 x 320)";
                tb_columns.Maximum = 3;
                tb_rows.Maximum = 6;
            }
            
            //Swap em around
            int hld;
            hld = tb_columns.Value;
            tb_columns.Value = tb_rows.Value;
            tb_rows.Value = hld;
            //Make sure it doesn't exceed max
            if (tb_columns.Value > tb_columns.Maximum)
            {
                tb_columns.Value = tb_columns.Maximum;
            }
            if (tb_rows.Value > tb_rows.Maximum)
            {
                tb_rows.Value = tb_rows.Maximum;
            }

            SetTableLayoutPrev();
            SetButtonPrev();
        }

        private void tb_rows_Scroll(object sender, EventArgs e)
        {
            SetTableLayoutPrev();
        }

        private void tb_columns_Scroll(object sender, EventArgs e)
        {
            SetTableLayoutPrev();
        }

        private void SetTableLayoutPrev()
        {
            int maxBtns = tb_columns.Value * tb_rows.Value;
            tft_dimension[0] = tb_columns.Value;
            tft_dimension[1] = tb_rows.Value;
            lbl_dimensions.Text = tb_columns.Value.ToString() + " x " + tb_rows.Value.ToString() + "   (" + maxBtns + " max buttons)";
            table_LayoutPrev.ColumnCount = tb_columns.Value;
            table_LayoutPrev.RowCount = tb_rows.Value;
            SetButtonPrev();
            if (lb_buttons.Items.Count > maxBtns)
            {
                lbl_mismatchWarning.Text = "Warning! This layout does not have enough room for all the buttons!";
            } else
            {
                lbl_mismatchWarning.Text = "";
            }
        }

        private void SetButtonPrev()
        {
            int screen_length = 0;
            int screen_height = 0;
            int padding = tb_spacing.Value;
            int[] buttons = { tb_rows.Value, tb_columns.Value };
            if (cb_tftOrient.Text == "HORIZONTAL")
            {
                screen_length = 320;
                screen_height = 240;
            }
            else if (cb_tftOrient.Text == "VERTICAL")
            {
                screen_length = 240;
                screen_height = 320;
            }
            int length = (screen_length-(padding*2)-(padding*(buttons[0]-1))) / buttons[0];
            int height = (screen_height - (padding * 2) - (padding * (buttons[1] - 1))) / buttons[1];

            lbl_btnLength.Text = length.ToString();
            lbl_btnHeight.Text = height.ToString();
            pb_btnPrev.Size = new Size(length, height);
        }

        private string GetVersion()
        {
            string v = "0.0.0 (error)";
            using (WebClient client = new WebClient())
            {
                v = client.DownloadString("https://raw.githubusercontent.com/EveAeternam/RotoTouch-OS/master/version");
            }
            return v;
        }

        private void tb_spacing_Scroll(object sender, EventArgs e)
        {
            tft_spacing = tb_spacing.Value;
            lbl_spacing.Text = tft_spacing.ToString() + " px";
            SetButtonPrev();
        }

        private void btn_removeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lb_buttons.SelectedItem.ToString());
        }

        private void btn_ColorPick_Click(object sender, EventArgs e)
        {
            diag_BtnColor.ShowDialog();
            lbl_btnColor.ForeColor = diag_BtnColor.Color;
            lbl_btnColor.Text = diag_BtnColor.Color.Name;
        }

        private void cb_key1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_key1.Text == "CUSTOM")
            {
                tb_key1.Enabled = true;
            } else
            {
                tb_key1.Enabled = false;
            }
        }

        private void cb_key2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_key2.Text == "CUSTOM")
            {
                tb_key2.Enabled = true;
            }
            else
            {
                tb_key2.Enabled = false;
            }
        }

        private void cb_key3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_key3.Text == "CUSTOM")
            {
                tb_key3.Enabled = true;
            }
            else
            {
                tb_key3.Enabled = false;
            }
        }

        private void btn_pickBgColor_Click(object sender, EventArgs e)
        {
            diag_BtnColor.ShowDialog();
            SetBgColor(diag_BtnColor.Color);
        }

        private void SetBgColor(Color clr)
        {
            tft_bgColor = clr;
            lbl_bgColor.ForeColor = clr;
            lbl_bgColor.Text = clr.Name;
            table_LayoutPrev.BackColor = clr;
            pb_btnPrev.BackColor = clr;
            prev.SetBgColor(clr);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prev = new Preview();
            prev.Show();
        }
    }

    public class Button
    {
        private string label = "";
        private int[] size = { 1, 1 };
        private int[] pos = { 1, 1 };
        private string[] keys;
        private string color = "";
    }

    public class TFTScreen
    {
        public Color bgColor = Color.Black;
    }
}
