using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace My_News
{
    public partial class frmMain : Form
    {
        public static frmMain Instance;

        public static frmMain GetInstance()
        {
            if (frmMain.Instance == null)
                frmMain.Instance = new frmMain();

            return frmMain.Instance;
        }

        public frmMain()
        {
            InitializeComponent();

        }
        public void ChooseNow()
        {
            tctMain.SelectTab("tbSetupSource");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!DbHelper.NoServerMode)
            {
                BasicLoadData();
            }
            else
            {
                tctMain.SelectTab("tbSettings");
            }
        }

        public void BasicLoadData()
        {
            ucSourceMng1.LoadAllData();
            ucGeneral1.LoadInfo();
            ucSourceMng1.LoadSourceName("");
            ucSourceMng1.LoadCategoryName("");
            ucSetupSource1.LoadSelectedSourceAndCategory();
            ucSetupSource1.LoadSourceAndCategory();
        }

        private void tctMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DbHelper.NoServerMode)
            {
                ucGeneral1.LoadInfo();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            mnRssSync.Instance.Stop();
            frmMyNews.Instance.Dispose();
        }

        private void ucGeneral1_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

    }
}
