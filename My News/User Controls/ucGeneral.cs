using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using My_News.DAL;

namespace My_News.Window_Forms
{
    public partial class ucGeneral : UserControl
    {
        public ucGeneral()
        {
            InitializeComponent();
        }

        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            frmMain.Instance.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmMyNews.Instance.ResetNews();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            mnRssSync.Instance.Stop();
            frmMyNews.Instance.Dispose();
        }

        private void btnShowGuide_Click(object sender, EventArgs e)
        {
            ShowGuide();
        }
        private void ShowGuide(bool c = false)
        {
            (new frmGuide(c)).ShowDialog(this);
        }
        private void ucGeneral_Load(object sender, EventArgs e)
        {

        }
        public void LoadInfo()
        {
            List<Source> list = new List<Source>();
            list = (new SourceDAL()).GetAllSource();

            if (list != null)
            {

                int sourceCount = list.Count;
                lblSource.Text = sourceCount.ToString();

                List<Category> listCategory = new List<Category>();
                listCategory = (new CategoryDAL()).GetAllCategory();
                int categoryCount = listCategory.Count;
                lblSelected.Text = categoryCount.ToString();

                lblLastUpdate.Text = Properties.Settings.Default.LastUpdate.ToString();

                List<Rsslink> listRsslink = new List<Rsslink>();
                listRsslink = (new RsslinkDAL()).GetAllRsslink();
                int rssCount = listRsslink.Count;
                lblLinkRss.Text = listRsslink.Count.ToString();
            }
        }

        private void label18_DoubleClick(object sender, EventArgs e)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            label18.ForeColor = randomColor;
        }

        private void tmrLoadDelay_Tick(object sender, EventArgs e)
        {
            tmrLoadDelay.Stop();
            if (Properties.Settings.Default.FirstRun == 2)
            {
                Properties.Settings.Default.FirstRun = 3;
                Properties.Settings.Default.Save();
                ShowGuide(true);
            }
        }
    }
}
