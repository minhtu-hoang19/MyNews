using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using My_News.DAL;
using My_News.Window_Forms;
using System.Threading;
using System.Diagnostics;

namespace My_News.User_Controls
{
    public partial class ucSourceMng : UserControl
    {

        public ucSourceMng()
        {
            InitializeComponent();
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            if (txtRss.Text.Trim() != "")
            {
                Source sou = (new SourceDAL()).GetSourceByName(cboSource.Text);
                Category cat = (new CategoryDAL()).GetCategoryByName(cboCategory.Text);
                bool rs = (new RsslinkDAL()).InsertRsslink(new Rsslink(0, txtRss.Text, cat, sou));
                if (rs)
                {
                    MessageBox.Show("Thêm mới Rss Link thành công.");
                    LoadAllData();
                    frmMain.Instance.BasicLoadData();
                }
                else
                {
                    MessageBox.Show("Thêm mới Rss Link thất bại. Vui lòng kiểm tra:\n    - Tên chuyên mục bị trùng.\n    - Nhập đầy đủ các thông tin.\n    - Kết nối tới server.");
                }
            }
            else
            {
                MessageBox.Show("Thêm mới Rss Link thất bại. Vui lòng kiểm tra:\n    - Tên chuyên mục bị trùng.\n    - Nhập đầy đủ các thông tin.\n    - Kết nối tới server.");
            }
        }

        private void dgdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRss.Text = (string)dgdData.SelectedRows[0].Cells[3].Value;
            cboSource.Text = (string)dgdData.SelectedRows[0].Cells[1].Value;
            cboCategory.Text = (string)dgdData.SelectedRows[0].Cells[2].Value;
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (txtRss.Text.Trim() != "")
            {
                Source sou = (new SourceDAL()).GetSourceByName(cboSource.Text);
                Category cat = (new CategoryDAL()).GetCategoryByName(cboCategory.Text);
                int id = (int)dgdData.SelectedRows[0].Cells[0].Value;
                bool rs = (new RsslinkDAL()).UpdateRsslink(new Rsslink(id, txtRss.Text, cat, sou));
                if (rs)
                {
                    MessageBox.Show("Cập nhật Rss Link thành công.");
                    LoadAllData();
                    frmMain.Instance.BasicLoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật Rss Link thất bại. Vui lòng kiểm tra:\n    - Tên chuyên mục bị trùng.\n    - Nhập đầy đủ các thông tin.\n    - Kết nối tới server.");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật Rss Link thất bại. Vui lòng kiểm tra:\n    - Tên chuyên mục bị trùng.\n    - Nhập đầy đủ các thông tin.\n    - Kết nối tới server.");
            }
            //IComparer<DataLoader> myComparer = new myReverserClass();
            //loadlist.Sort(myComparer);
            //dgdData.AutoGenerateColumns = false;
            //dgdData.DataSource = loadlist;
            //dgdData.Refresh();

        }
        public void LoadAllData()
        {
            List<Rsslink> list = new List<Rsslink>();
            List<DataLoader> loadlist = new List<DataLoader>();
            list = (new RsslinkDAL()).GetAllRsslink();
            if (list != null)
            {
                foreach (var item in list)
                {
                    DataLoader load = new DataLoader();
                    load.Id = item.Id;
                    load.Url = item.Url.TrimEnd(' ');
                    load.SourceName = item.GetSource.Name;
                    load.CategoryName = item.GetCategory.Name;
                    loadlist.Add(load);
                }
                dgdData.AutoGenerateColumns = false;
                dgdData.DataSource = loadlist;
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến Server!\nVui lòng kiểm tra lại cài đặt:\n" + DbHelper.GetConnectionString(), "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ucSourceMng_Load(object sender, EventArgs e)
        {

        }

        private void ReloadData(string str)
        {
            frmMain.Instance.BasicLoadData();
        }
        public void LoadSourceName(string sou)
        {
            List<Source> list = new List<Source>();
            list = (new SourceDAL()).GetAllSource();
            List<String> liststr = new List<string>();
            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        liststr.Add(item.Name);
                    }
                }
                else
                {
                    liststr.Add("");
                }
                liststr.Add("[Quản lý]");
                cboSource.DataSource = liststr;
                cboSource.Text = sou;
            }
        }

        public void LoadCategoryName(string cat)
        {
            List<Category> list = new List<Category>();
            list = (new CategoryDAL()).GetAllCategory();
            List<String> liststr = new List<string>();
            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        liststr.Add(item.Name);
                    }
                }
                else
                {
                    liststr.Add("");
                }
                liststr.Add("[Quản lý]");
                cboCategory.DataSource = liststr;
                cboCategory.Text = cat;
            }
        }
        private void cmdDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa Rss Link này không?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = (int)dgdData.SelectedRows[0].Cells[0].Value;
                bool rs = (new RsslinkDAL()).DeleteRsslink(id);

                if (rs)
                {
                    LoadAllData();
                    frmMain.Instance.BasicLoadData();
                }
                else
                {
                    MessageBox.Show("Xóa Rss Link thất bại. Vui lòng kiểm tra kết nối tới server.");
                }
            }
        }

        private void cboSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSource.Text == "[Quản lý]")
            {
                frmNewSource frmSou = new frmNewSource();
                frmSou.NotifyEvent += new NotifyLoadData(ReloadData);
                frmSou.NotifyEvent += new NotifyLoadData(LoadSourceName);
                LoadSourceName("");
                frmSou.ShowDialog();

            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.Text == "[Quản lý]")
            {
                frmNewCategory frmCat = new frmNewCategory();
                frmCat.NotifyEvent += new NotifyLoadData(ReloadData);
                frmCat.NotifyEvent += new NotifyLoadData(LoadCategoryName);
                LoadCategoryName("");
                frmCat.ShowDialog();

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "MYNEWS_DATA_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            saveFileDialog1.ShowDialog();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Thread startExport = new Thread(new ThreadStart(StartExport));
            startExport.Start();
            btnExport.Visible = false;
            picLoadingExport.Visible = true;
        }
        private delegate void dlgEnableControls();
        private void EnableControls()
        {
            //CHeck for Cross-thread warning
            if (this.btnExport.InvokeRequired)
            {
                this.Invoke(new dlgEnableControls(EnableControls));
                return;
            }
            btnExport.Visible = true;
            btnImport.Visible = true;
            picLoadingImport.Visible = false;
            picLoadingExport.Visible = false;
        }
        private void StartExport()
        {
            try
            {
                string fileName = saveFileDialog1.FileName;
                Excel_Helper eh = new Excel_Helper();
                eh.Create();

                eh.SetValue(1, 1, "Các chuyên mục");
                eh.SetValue(2, 1, "ID");
                eh.SetValue(2, 2, "Tên chuyên mục");

                List<Category> listCat = (new CategoryDAL()).GetAllCategory();
                int row = 3;
                foreach (var cat in listCat)
                {
                    eh.SetValue(row, 1, cat.Id.ToString());
                    eh.SetValue(row, 2, cat.Name.ToString());

                    row++;
                }

                eh.SetValue(row, 1, "Các nguồn");
                row++;
                eh.SetValue(row, 1, "ID");
                eh.SetValue(row, 2, "Tên nguồn");
                eh.SetValue(row, 3, "Trang chủ");
                eh.SetValue(row, 4, "Logo");
                row++;
                List<Source> listSou = (new SourceDAL()).GetAllSource();
                foreach (var sou in listSou)
                {
                    eh.SetValue(row, 1, sou.Id.ToString());
                    eh.SetValue(row, 2, sou.Name.ToString());
                    eh.SetValue(row, 3, sou.Homepage.ToString());
                    eh.SetValue(row, 4, sou.Logo.ToString());

                    row++;
                }

                eh.SetValue(row, 1, "Các link RSS");
                row++;
                eh.SetValue(row, 1, "ID");
                eh.SetValue(row, 2, "URL");
                eh.SetValue(row, 3, "Nguồn");
                eh.SetValue(row, 4, "Chuyên mục");
                row++;
                //List<Source> listSou = (new SourceDAL()).GetAllSource();
                List<Rsslink> listRl = (new RsslinkDAL()).GetAllRsslink();
                foreach (var rl in listRl)
                {
                    eh.SetValue(row, 1, rl.Id.ToString());
                    eh.SetValue(row, 2, rl.Url.ToString());
                    eh.SetValue(row, 3, rl.GetSource.Id.ToString());
                    eh.SetValue(row, 4, rl.GetCategory.Id.ToString());
                    row++;
                }

                eh.SetValue(row, 1, "Các chuyên mục đã chọn");
                row++;
                eh.SetValue(row, 1, "User");
                eh.SetValue(row, 2, "Chuyên mục");
                eh.SetValue(row, 3, "Nguồn");
                row++;
                //List<Source> listSou = (new SourceDAL()).GetAllSource();
                List<CaSo> listCs = (new CaSoDAL()).GetUserSelectedCaSo();
                foreach (var cs in listCs)
                {
                    eh.SetValue(row, 1, "0");
                    eh.SetValue(row, 2, cs.Category.Id.ToString());
                    eh.SetValue(row, 3, cs.Source.Id.ToString());

                    row++;
                }


                eh.Save(fileName);
                eh.Close();
                MessageBox.Show("Đã Export thành công!");
            }
            catch (Exception ee)
            {
                Logger.Instance.Log("ucSourceMng.saveFileDialog", ee.ToString());
                MessageBox.Show("Không thể lưu file! Vui lòng kiểm tra lại vị trí lưu file.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            EnableControls();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Thread importExport = new Thread(new ThreadStart(StartImport));
            importExport.Start();
            btnImport.Visible = false;
            picLoadingImport.Visible = true;
        }

        private void StartImport()
        {
            try
            {
                string fileName = openFileDialog1.FileName;
                Excel_Helper eh = new Excel_Helper();
                eh.Open(fileName);
                List<Category> listCat = new List<Category>();

                int row = 3;
                while ((new StrHelper()).isNumber(eh.GetValue(row, 1)))
                {
                    listCat.Add(new Category(Convert.ToInt32(eh.GetValue(row, 1)), eh.GetValue(row, 2)));
                    row++;
                }

                List<Source> listSou = new List<Source>();
                row += 2;
                while ((new StrHelper()).isNumber(eh.GetValue(row, 1)))
                {
                    listSou.Add(new Source(Convert.ToInt32(eh.GetValue(row, 1)), eh.GetValue(row, 2), eh.GetValue(row, 3), eh.GetValue(row, 4)));
                    row++;
                }

                List<Rsslink> listRl = new List<Rsslink>();
                row += 2;
                while ((new StrHelper()).isNumber(eh.GetValue(row, 1)))
                {
                    listRl.Add(new Rsslink(Convert.ToInt32(eh.GetValue(row, 1)),
                        eh.GetValue(row, 2), 
                        new Category(Convert.ToInt32(eh.GetValue(row, 4))), 
                        new Source(Convert.ToInt32(eh.GetValue(row, 3)))
                        ));
                    row++;
                }
                List<CaSo> listCs = new List<CaSo>();
                row += 2;
                while ((new StrHelper()).isNumber(eh.GetValue(row, 1)))
                {
                    listCs.Add(new CaSo(new Category(Convert.ToInt32(eh.GetValue(row, 2))), new Source(Convert.ToInt32(eh.GetValue(row, 3)))));
                    row++;
                }

                string mess = String.Format("File này chứa: \n- {0} danh mục\n- {1} nguồn tin\n- {2} RSS link\n- {3} cài đặt của người dùng\n\nBạn có muốn XÓA TOÀN BỘ DATABASE CŨ và thay thế bằng dữ liệu trên?\n\nYes: xóa toàn bộ database cũ và thay thế bằng dữ liệu import.\nNo: thêm dữ liệu này vào database cũ bỏ qua các dữ liệu trùng.", listCat.Count.ToString(), listSou.Count.ToString(), listRl.Count.ToString(), listCs.Count.ToString());
                var result = MessageBox.Show(null, mess, "Import dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                ItemDAL id = new ItemDAL();
                CategoryDAL cd = new CategoryDAL();
                SourceDAL sd = new SourceDAL();
                RsslinkDAL rd = new RsslinkDAL();
                CaSoDAL csd = new CaSoDAL();
                if (result == DialogResult.Yes)
                {
                    id.DeleteAllItem();
                    rd.DeleteAllRsslink();
                    cd.DeleteAllCategory();
                    sd.DeleteAllSource();
                    csd.DeleteAllCaSo();
                }
                cd.ImportCategory(listCat);
                sd.ImportSource(listSou);
                rd.ImportRsslink(listRl);
                csd.SetUserSelectedCaSo(listCs);

                eh.Close();
                MessageBox.Show("Import thành công! Chương trình sẽ tự khởi động lại sau khi bạn nhấn OK", "Thành công");
                RestartMyself();
            }
            catch (Exception ee)
            {
                Logger.Instance.Log("ucSourceMng.saveFileDialog", ee.ToString());
                MessageBox.Show("Không thể import file!\n" + ee.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EnableControls();
        }

        private void RestartMyself(bool asAdmin = false)
        {
            try
            {
                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                if (asAdmin)
                {
                    Info.UseShellExecute = true;
                    Info.Verb = "runas";
                }
                Process.Start(Info);
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception)
            {
                
            }
        }
    }


    public class DataLoader
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string SourceName { get; set; }
        public string CategoryName { get; set; }
    }

}
