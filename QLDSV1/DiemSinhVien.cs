using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLDSV1
{
    public partial class DiemSinhVien : DevExpress.XtraEditors.XtraForm
    {
        DiemSinhVienDAL dal;

        public DiemSinhVien()
        {
            InitializeComponent();
            dal = new DiemSinhVienDAL();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtmonhoc.Text)||string.IsNullOrEmpty(txtlanthi.Text)|| string.IsNullOrEmpty(txtlop.Text)|| int.Parse(txtlanthi.Text) >2)
            {
                MessageBox.Show("Bạn chưa nhập lần thi hoặc môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //int lan = int.Parse(lanthi);
                txtmonhoc.Focus();
                txtlanthi.Focus();
                return false;
            }
            return true;
        }
        public void ShowDanhSachSV(string malop)
        {
            DataTable dt = dal.getDanhSachSV(malop);
            tableDiem.DataSource = dt;

        }

        private void DiemSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH2' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH2TableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH2);
            btnSave.Enabled = false;
            cmbDiem.SelectedIndex = -1;
            cmbDiem.SelectedIndex = Program.temp;
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CheckData())
            {
                string malop = txtlop.Text;
                ShowDanhSachSV(malop);
                btnSave.Enabled = false;
                string notice = "" + Program.demrow;
            }
            
            //MessageBox.Show(notice);
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int lanthi=int.Parse(txtlanthi.Text);
                
                for (int i = 0; i < Program.demrow; i++)
                {
    
                    int index = -1;
                    index = i;
                    BeanDiemSV dsv = new BeanDiemSV();
                    dsv.MASV = gridView1.GetRowCellValue(index, "MASV").ToString();

                    dsv.MAMH = txtmonhoc.Text;

                    dsv.DIEM = gridView1.GetRowCellValue(index, "DIEM").ToString();
                    if (lanthi == 1)
                    {
                        if(dal.checkDiemSV(dsv.MASV,dsv.MAMH,1)>0 && dal.checkDiemSV(dsv.MASV, dsv.MAMH, 2)==0)
                        {
                            dsv.LANTHI = int.Parse(txtlanthi.Text)+1;
                            dal.InsertDiem(dsv);
                            MessageBox.Show("Lưu lại thành công");
                        }
                        else if(dal.checkDiemSV(dsv.MASV, dsv.MAMH, 1) > 0 && dal.checkDiemSV(dsv.MASV, dsv.MAMH, 2) > 0)
                        {
                            MessageBox.Show("Không thể lưu sinh viên này"+dsv.MASV);
                        }
                        else
                        {
                            dsv.LANTHI = int.Parse(txtlanthi.Text);
                            dal.InsertDiem(dsv);
                            MessageBox.Show("Lưu lại thành công");
                        }
                    }
                    if(lanthi==2)
                    {
                        if (dal.checkDiemSV(dsv.MASV, dsv.MAMH, 1) > 0 && dal.checkDiemSV(dsv.MASV, dsv.MAMH, 2) == 0)
                        {
                            dsv.LANTHI = int.Parse(txtlanthi.Text);
                            dal.InsertDiem(dsv);
                            MessageBox.Show("Lưu lại thành công");
                        }
                        else if (dal.checkDiemSV(dsv.MASV, dsv.MAMH, 1) > 0 && dal.checkDiemSV(dsv.MASV, dsv.MAMH, 2) > 0)
                        {
                            MessageBox.Show("Không thể lưu sinh viên này" + dsv.MASV);
                        }
                        else if(dal.checkDiemSV(dsv.MASV, dsv.MAMH, 1) == 0)
                        {
                            dsv.LANTHI = int.Parse(txtlanthi.Text)-1;
                            dal.InsertDiem(dsv);
                            MessageBox.Show("Lưu lại thành công");
                        }

                    }
                    

                }
                
                btnSave.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi");
            }
            
            
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Nhấn lưu lại để lưu");
            //btnSave.Enabled = true;
            int dem = 0;
            
            string mamh = txtmonhoc.Text;
            int lanthi = int.Parse(txtlanthi.Text);
            string notice = "";
            string notice3 = "Các sinh viên sau đây đã có điểm môn " +mamh+" lần " + 1 +" nếu lưu lại điểm tự động chuyển lần 2  : ";
            string notice1 = "Các sinh viên sau đây đã có điểm môn " + mamh + " lần 1 và 2 nên sẽ không thể lưu sinh viên này";
            string notice2 = "Các sinh viên sau đây chưa có điểm lần 1 nếu lưu lại sẽ tự cập nhập lần 1 : ";
            for (int i = 0; i < Program.demrow; i++)
            {
                int index = -1;
                index = i;
                BeanDiemSV dsv = new BeanDiemSV();
                string masv = gridView1.GetRowCellValue(index, "MASV").ToString();

                
                string string_diem = gridView1.GetRowCellValue(index, "DIEM").ToString();
                if(string.IsNullOrEmpty(string_diem))
                {
                    MessageBox.Show("Vui lòng nhập giá trị");
                    btnSave.Enabled = false;
                    break;
                }
                else
                {
                    double diem = Convert.ToDouble(string_diem);
                    if (diem < 0 || diem > 10)
                    {
                        MessageBox.Show("Bạn nhập giá trị điểm không hợp lệ vui lòng kiểm tra lại trước khi lưu");
                        btnSave.Enabled = false;
                        break;
                    }
                    else
                    {
                        if(lanthi==1)
                        {
                            dem++;
                            if (dal.checkDiemSV(masv, mamh, 1) > 0 && dal.checkDiemSV(masv, mamh, 2) == 0)
                            {
                                notice3 += masv + ",";
                                //notice = notice3;
                            }
                            else if (dal.checkDiemSV(masv, mamh, 1) > 0 && dal.checkDiemSV(masv, mamh, 2) > 0)
                            {
                                notice1 += masv + " " + ";";
                                
                            }
                            
                        }
                        if(lanthi==2)
                        {
                            dem++;
                            if (dal.checkDiemSV(masv, mamh, 1) > 0 && dal.checkDiemSV(masv, mamh, 2) > 0)
                            {
                                notice1 += masv + " " + ";";
                                //notice = notice1;
                            }
                            else if (dal.checkDiemSV(masv, mamh, 1)==0)
                            {
                                notice2 += masv + " " + ";";
                                
                            }
                        }
                        
                    }

                    
                }
                

            }
            if(dem== Program.demrow)
            {
                if(lanthi==1) MessageBox.Show(notice1 + " " + notice3);
                else if(lanthi==2) MessageBox.Show(notice1 + " " + notice2);

                btnSave.Enabled = true;
            }
        }

        private void CmbDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.mGroup.Equals("PGV"))
            {
                try
                {
                    Program.servername = cmbDiem.SelectedValue.ToString();
                    if (Program.servername.Equals(Program.tenServerDN))
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                        DataConnection dc = new DataConnection();
                        dal = new DiemSinhVienDAL();
                    }
                    else
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                        DataConnection dc = new DataConnection();
                        //MessageBox.Show(Program.servername);
                        dal = new DiemSinhVienDAL();
                    }
                       
                }
                catch (Exception)
                {


                }
            }
        }
    }
}