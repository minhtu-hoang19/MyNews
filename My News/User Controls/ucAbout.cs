using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace My_News.User_Controls
{
    public partial class ucAbout : UserControl
    {
        public ucAbout()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label20_DoubleClick(object sender, EventArgs e)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            label20.ForeColor = randomColor;
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sực muốn gỡ bỏ chương trình này ra khỏi máy tính?", @":-(", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                Properties.Settings.Default.FirstRun = 0;
                Properties.Settings.Default.Save();
                RegistryKey remove = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                remove.DeleteValue("My News");
                MessageBox.Show("Gỡ bỏ thành công!\n\nBất cứ lúc nào bạn muốn cài đặt lại chương trình, chỉ cần chạy lại file My News.exe", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mnRssSync.Instance.Stop();
                frmMyNews.Instance.Dispose();
            }
        }
    }
}
