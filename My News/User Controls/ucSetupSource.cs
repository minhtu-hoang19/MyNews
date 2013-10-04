using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using My_News.DAL;

namespace My_News.User_Controls
{
    public partial class ucSetupSource : UserControl
    {

        private List<CaSo> casomenu = new List<CaSo>();
        private List<CaSo> casoselected = new List<CaSo>();
        public ucSetupSource()
        {
            InitializeComponent();
        }

        private void ucSetupSource_Load(object sender, EventArgs e)
        {

        }


        public void LoadSelectedSourceAndCategory()
        {
            try
            {
                casoselected = (new CaSoDAL()).GetUserSelectedCaSo();
                LoadCasoselectedToListbox();
            }
            catch (Exception)
            {
                MessageBox.Show("Load data thất bại.");
                //log
            }
        }
        public void LoadSourceAndCategory()
        {
            try
            {
                casomenu = (new CaSoDAL()).GetAllCaSo();

                // Remove selected CaSo
                foreach (CaSo c in casoselected)
                {
                    for (int i = casomenu.Count - 1; i >= 0; --i)
                    {
                        if ((casomenu[i].Source.Name + "  -  " + casomenu[i].Category.Name).Equals(c.Source.Name + "  -  " + c.Category.Name))
                        {
                            casomenu.RemoveAt(i);
                        }
                    }
                }

                LoadCasomenuToListbox();
            }
            catch (Exception)
            {
                MessageBox.Show("Load data thất bại.");
            }
        }

        private void LoadCasomenuToListbox()
        {
            List<string> liststr = new List<string>();
            foreach (var item in casomenu)
            {
                string str = item.Source.Name + "  -  " + item.Category.Name;
                liststr.Add(str);
            }

            lstMenu.DataSource = liststr;
        }

        private void LoadCasoselectedToListbox()
        {
            List<string> liststr = new List<string>();
            foreach (var item in casoselected)
            {
                string str = item.Source.Name + "  -  " + item.Category.Name;
                liststr.Add(str);
            }

            lstSelected.DataSource = liststr;
        }

        private void cmdGetBack_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItems.Count > 0)
            {
                //for (int i = lstMenu.Items.Count - 1; i >= 0; --i)
                foreach (var item in lstSelected.SelectedItems)
                {
                    int target = GetIndexByString(item.ToString(), casoselected);
                    casomenu.Add(casoselected[target]);
                    casoselected.RemoveAt(target);
                    //casoselected.Add(casomenu[GetIndexByString(lstMenu.Items[i].ToString(), casomenu)]);

                }
            }
            LoadCasoselectedToListbox();
            LoadCasomenuToListbox();
        }

        private int GetIndexByString(string str, List<CaSo> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (str.Equals(list[i].Source.Name + "  -  " + list[i].Category.Name))
                {
                    return i;
                }
            }

            return -1;
        }
        private void cmdGet_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItems.Count > 0)
            {
                //for (int i = lstMenu.Items.Count - 1; i >= 0; --i)
                foreach (var item in lstMenu.SelectedItems)
                {
                    int target = GetIndexByString(item.ToString(), casomenu);
                    casoselected.Add(casomenu[target]);
                    casomenu.RemoveAt(target);
                    //casoselected.Add(casomenu[GetIndexByString(lstMenu.Items[i].ToString(), casomenu)]);

                }
            }
            LoadCasoselectedToListbox();
            LoadCasomenuToListbox();
        }

        private void cmdSortAsCategory_Click(object sender, EventArgs e)
        {
            casomenu.Sort();
            List<string> liststr = new List<string>();
            foreach (var item in casomenu)
            {
                string str = item.Source.Name + "  -  " + item.Category.Name;
                liststr.Add(str);
            }

            lstMenu.DataSource = liststr;
        }

        private void cmdSoftAsSource_Click(object sender, EventArgs e)
        {
            IComparer<CaSo> compare = new myReverserClass();
            casomenu.Sort(compare);
            List<string> liststr = new List<string>();
            foreach (var item in casomenu)
            {
                string str = item.Source.Name + "  -  " + item.Category.Name;
                liststr.Add(str);
            }

            lstMenu.DataSource = liststr;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            LoadSelectedSourceAndCategory();
            LoadSourceAndCategory();
        }

        private void cmdGetAll_Click(object sender, EventArgs e)
        {
            foreach (CaSo c in casomenu)
            {
                casoselected.Add(c);
            }
            casomenu.Clear();

            LoadCasoselectedToListbox();
            LoadCasomenuToListbox();
        }

        private void cmdAccept_Click(object sender, EventArgs e)
        {
            bool rs = (new CaSoDAL()).SetUserSelectedCaSo(casoselected);
            if (rs)
            {
                mnRssSync.Instance.StartSync();
                frmMyNews.Instance.ResetNews();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void cmdGetBackAll_Click(object sender, EventArgs e)
        {
            foreach (CaSo c in casoselected)
            {
                casomenu.Add(c);
            }
            casoselected.Clear();
            LoadCasoselectedToListbox();
            LoadCasomenuToListbox();
        }
    }

    public class myReverserClass : IComparer<CaSo>
    {
        // Calls CaseInsensitiveComparer.Compare with the parameters reversed. 
        int IComparer<CaSo>.Compare(CaSo x, CaSo y)
        {
            return x.Source.Name.CompareTo(y.Source.Name);
        }
    }
}
