using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace My_News.Window_Forms
{
    public partial class frmGuide : Form
    {
        int counter = 5;
        bool closeable = true;
        bool countdown = false;
        public frmGuide(bool c = false)
        {
            InitializeComponent();
            countdown = c;
        }

        private void frmGuide_Load(object sender, EventArgs e)
        {
            if (countdown)
            {
                closeable = false;
                btnCloseMe.Enabled = false;
                lklChooseNow.Enabled = false;
                btnCloseMe.Text = "Đóng (5)";
                tmrCountDown.Start();
            }
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                tmrCountDown.Stop();
                closeable = true;
                btnCloseMe.Text = "Đóng";
            }

            btnCloseMe.Text = "Đóng (" + counter.ToString() + ")";
            btnCloseMe.Enabled = closeable;
            lklChooseNow.Enabled = closeable;
        }

        private void frmGuide_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !closeable;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain.Instance.Show();
            frmMain.Instance.ChooseNow();
            this.Close();
        }

        private void btnCloseMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
