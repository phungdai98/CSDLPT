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
            if (string.IsNullOrEmpty(txtmonhoc.Text)||string.IsNullOrEmpty(txtlanthi.Text)|| string.IsNullOrEmpty(txtlop.Text))
            {
                MessageBox.Show("Bạn chưa nhập lần thi hoặc môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnSave.Enabled = false;
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CheckData())
            {
                string malop = txtlop.Text;
                ShowDanhSachSV(malop);
                string notice = "" + Program.demrow;
            }
            
            //MessageBox.Show(notice);
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                for (int i = 0; i < Program.demrow; i++)
                {
                    int index = -1;
                    index = i;
                    BeanDiemSV dsv = new BeanDiemSV();
                    dsv.MASV = gridView1.GetRowCellValue(index, "MASV").ToString();

                    dsv.MAMH = txtmonhoc.Text;
                    dsv.LANTHI = int.Parse(txtlanthi.Text);
                    dsv.DIEM = gridView1.GetRowCellValue(index, "DIEM").ToString();
                    dal.InsertDiem(dsv);

                }
                MessageBox.Show("Lưu lại thành công");
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
            string notice = "Các sinh viên đã có điểm môn" +mamh+" lần" +lanthi;
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
                        dem++;
                        if(dal.checkDiemSV(masv,mamh,lanthi)>0)
                        {
                            notice += masv + ","; 
                        }
                        else
                        {
                            notice = "hop lệ";
                        }
                    }

                    
                }
                

            }
            if(dem== Program.demrow)
            {
                MessageBox.Show(notice);
                btnSave.Enabled = true;
            }
        }
    }
}