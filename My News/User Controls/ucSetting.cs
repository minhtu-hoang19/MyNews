using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace My_News.User_Controls
{
    public partial class ucSetting : UserControl
    {
        public ucSetting()
        {
            InitializeComponent();
        }

        private void ucSetting_Load(object sender, EventArgs e)
        {

            LoadSettings();
        }


        private void LoadSettings()
        {
            nudTime.Value = Properties.Settings.Default.SyncDelay;
            nudSpeed.Value = Properties.Settings.Default.TextSpeed;
            chkJustShowTitle.Checked = Properties.Settings.Default.TitleOnly;
            chkStartWithWindow.Checked = Properties.Settings.Default.StartWithWindows;
            tkbOpacity.Value = Properties.Settings.Default.TextOpacity;
            txtAddressServer.Text = Properties.Settings.Default.db_server;
            txtId.Text = Properties.Settings.Default.db_username;
            txtPassword.Text = Properties.Settings.Default.db_password;
            rdbSql.Checked = !Properties.Settings.Default.db_use_trusted;
            txtPassword.Enabled = !Properties.Settings.Default.db_use_trusted;
            txtId.Enabled = !Properties.Settings.Default.db_use_trusted;
            rdbWindow.Checked = Properties.Settings.Default.db_use_trusted;
            txtFont.Font = Properties.Settings.Default.TextFont;
            fontDialog1.Font = Properties.Settings.Default.TextFont;
            nudNewsDays.Value = Properties.Settings.Default.NewsDays;
            if (chkStartWithWindow.Checked == true)
            {
                RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                add.SetValue("My News", "\"" + Application.ExecutablePath.ToString() + "\"");
            }
            else
            {
                RegistryKey remove = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                remove.DeleteValue("My News");
            }
        }

        private void rdbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtAddressServer.Enabled = true;
            txtId.Enabled = true;
            txtPassword.Enabled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (chkStartWithWindow.Checked == true)
            {
                Properties.Settings.Default.StartWithWindows = true;
                RegistryKey add = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                add.SetValue("My News", "\"" + Application.ExecutablePath.ToString() + "\"");
            }
            else
            {
                Properties.Settings.Default.StartWithWindows = false;
                RegistryKey remove = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                remove.DeleteValue("My News");
            }

            if (chkJustShowTitle.Checked == true)
            {
                Properties.Settings.Default.TitleOnly = true;
            }
            else
            {
                Properties.Settings.Default.TitleOnly = false;
            }

            Properties.Settings.Default.SyncDelay = Convert.ToInt32(nudTime.Value);
            Properties.Settings.Default.TextSpeed = Convert.ToInt32(nudSpeed.Value);
            Properties.Settings.Default.TextOpacity = Convert.ToInt32(tkbOpacity.Value);
            Properties.Settings.Default.NewsDays = Convert.ToInt32(nudNewsDays.Value);
            if (rdbWindow.Checked == true)
            {
                Properties.Settings.Default.db_server = txtAddressServer.Text;
                Properties.Settings.Default.db_username = txtId.Text;
                Properties.Settings.Default.db_password = txtPassword.Text;
                Properties.Settings.Default.db_use_trusted = true;

            }
            if (rdbWindow.Checked == false)
            {
                Properties.Settings.Default.db_server = txtAddressServer.Text;
                Properties.Settings.Default.db_username = txtId.Text;
                Properties.Settings.Default.db_password = txtPassword.Text;
                Properties.Settings.Default.db_use_trusted = false;
            }

            Properties.Settings.Default.TextFont = fontDialog1.Font;


            Properties.Settings.Default.Save();
            MessageBox.Show("Lưu cài đặt thành công!");

            //Reconnect server if current is off
            if (DbHelper.NoServerMode)
            {
                if (DbHelper.IsConnected())
                {
                    MessageBox.Show("Kết nối server thành công!");
                    DbHelper.NoServerMode = false;
                    Thread autoSyncThread = new Thread(new ThreadStart(mnRssSync.Instance.Run));
                    autoSyncThread.Start();
                    frmMain.Instance.BasicLoadData();
                }
                else
                {
                    MessageBox.Show(String.Format("Không tìm thấy server:\n{0}\nVui lòng kiểm tra lại kết nối!", DbHelper.GetConnectionString()), "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void rdbWindow_CheckedChanged(object sender, EventArgs e)
        {

            txtId.Enabled = false;
            txtPassword.Enabled = false;
        }

        private void cmdDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartWithWindows = true;
            chkStartWithWindow.Checked = true;
            Properties.Settings.Default.TitleOnly = true;
            chkJustShowTitle.Checked = true;
            Properties.Settings.Default.TextSpeed = 50;
            nudSpeed.Value = 50;
            Properties.Settings.Default.SyncDelay = 15;
            nudTime.Value = 15;
            Properties.Settings.Default.TextOpacity = 50;
            tkbOpacity.Value = 50;
            txtAddressServer.Text = "";
            txtId.Text = "";
            txtPassword.Text = "";
            rdbWindow.Checked = true;
            fontDialog1.Font = this.Font;
            txtFont.Font = this.Font;
            nudNewsDays.Value = 3;
        }

        private void txtFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                //// Set TextBox properties.

                this.txtFont.Font = font;
            }
        }
    }
}
