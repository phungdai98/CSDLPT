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
using System.Collections;

namespace QLDSV1
{
    public partial class SinhVien : DevExpress.XtraEditors.XtraForm
    {
        SinhVienDAL dal;
        LopBLL lobll;
        String temp1 = "";
        String temp2 = "";
        String temp3 = "";
        String temp4 = "";
        String temp5 = "";
        String temp6 = "";
        String temp7 = "";
        String temp8 = "";
        String temp9 = "";
        String temp10 = "";
        Stack<BeanSinhVien> st= new Stack<BeanSinhVien>();
        public SinhVien()
        {
            InitializeComponent();
            dal = new SinhVienDAL();
            lobll = new LopBLL();
        }
        public void ShowSinhVien()
        {
            DataTable dt = dal.getSinhVien(Program.maLopSub);
            tablesv.DataSource = dt;
            
        }
        public void ShowAllLop()
        {
            DataTable dt = lobll.getAllLop();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtmasv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasv.Focus();
                return false;
            }
            return true;
        }
        private void SinhVien_Load(object sender, EventArgs e)
        {
            
            this.v_DS_PHANMANH2TableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH2);
            int index = 0;
            ShowAllLop();
            Program.maLopSub = dataGridView1.Rows[0].Cells["MALOP"].Value.ToString();
            ShowSinhVien();
            int index1 = gridView1.FocusedRowHandle;
            if (index1 >= 0)
            {
                txtmasv.Text = gridView1.GetRowCellValue(index, "MASV").ToString();
                txtho.Text = gridView1.GetRowCellValue(index, "HO").ToString();
                txtten.Text = gridView1.GetRowCellValue(index, "TEN").ToString();
                //txtmalop.Text = gridView1.GetRowCellValue(index, "MALOP").ToString();
                txtmalop.Text = dataGridView1.Rows[index].Cells["MALOP"].Value.ToString();
                if (gridView1.GetRowCellValue(index, "PHAI").ToString().Equals("True"))
                {
                    txtphai.SelectedIndex = 0;
                }
                else
                {
                    txtphai.SelectedIndex = 1;
                }
                txtdate.Text = gridView1.GetRowCellValue(index, "NGAYSINH").ToString();
                txtnoisinh.Text = gridView1.GetRowCellValue(index, "NOISINH").ToString();
                txtdiachi.Text = gridView1.GetRowCellValue(index, "DIACHI").ToString();
                txtghichu.Text = gridView1.GetRowCellValue(index, "GHICHU").ToString();
                if (gridView1.GetRowCellValue(index, "NGHIHOC").ToString().Equals("True"))
                {
                    txtnghihoc.SelectedIndex = 0;
                }
                else
                {
                    txtnghihoc.SelectedIndex = 1;
                }
            }
            
            cmb2.SelectedIndex = -1;
            cmb2.SelectedIndex = Program.temp;
            if (Program.mGroup.Equals("KHOA"))
            {
                cmb2.Enabled = false;
                btninsert.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnphuchoi.Enabled = false;
            }
            txtmalop.Enabled = false;
            //String sodong ="Số dòng là" +Program.demrow;
            //MessageBox.Show(sodong);
        }

        private void Btninsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dal.CheckMaSV(txtmasv.Text)>0)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ");
                //return 0;
            }
            if (CheckData()&&dal.CheckMaSV(txtmasv.Text)==0)
            {
                BeanSinhVien sv = new BeanSinhVien();
                sv.MASV = txtmasv.Text;
                sv.HO = txtho.Text;
                sv.TEN = txtten.Text;
                sv.MALOP = txtmalop.Text;
                Boolean phai = Boolean.Parse(txtphai.Text);
                sv.PHAI = phai;
                sv.NGAYSINH = txtdate.Text;
                sv.NOISINH = txtnoisinh.Text;
                sv.DIACHI = txtdiachi.Text;
                sv.GHICHU = txtghichu.Text;
                bool nghihoc = bool.Parse(txtnghihoc.Text);
                sv.NGHIHOC = nghihoc;
                if (dal.InsertSinhVien(sv))
                {
                    ShowSinhVien();

                }

                else
                {
                    MessageBox.Show("Đã có lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Tablesv_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;
            if(index>=0)
            {
                txtmasv.Text = gridView1.GetRowCellValue(index, "MASV").ToString();
                txtho.Text= gridView1.GetRowCellValue(index, "HO").ToString();
                txtten.Text = gridView1.GetRowCellValue(index, "TEN").ToString();
                //txtmalop.Text= gridView1.GetRowCellValue(index, "MALOP").ToString();
                
                if (gridView1.GetRowCellValue(index, "PHAI").ToString().Equals("True"))
                {
                    txtphai.SelectedIndex = 0;
                }
                else
                {
                    txtphai.SelectedIndex = 1;
                }
                txtdate.Text= gridView1.GetRowCellValue(index, "NGAYSINH").ToString();
                txtnoisinh.Text= gridView1.GetRowCellValue(index, "NOISINH").ToString();
                txtdiachi.Text= gridView1.GetRowCellValue(index, "DIACHI").ToString();
                txtghichu.Text= gridView1.GetRowCellValue(index, "GHICHU").ToString();
                if (gridView1.GetRowCellValue(index, "NGHIHOC").ToString().Equals("True"))
                {
                    txtnghihoc.SelectedIndex = 0;
                }
                else
                {
                    txtnghihoc.SelectedIndex = 1;
                }

                 temp1 = gridView1.GetRowCellValue(index, "MASV").ToString();
                 temp2 = gridView1.GetRowCellValue(index, "HO").ToString();
                 temp3 = gridView1.GetRowCellValue(index, "TEN").ToString();
                 temp4 = gridView1.GetRowCellValue(index, "MALOP").ToString();
                 temp5 = gridView1.GetRowCellValue(index, "PHAI").ToString();
                 temp6 = gridView1.GetRowCellValue(index, "NGAYSINH").ToString();
                 temp7 = gridView1.GetRowCellValue(index, "NOISINH").ToString();
                 temp8 = gridView1.GetRowCellValue(index, "DIACHI").ToString();
                 temp9 = gridView1.GetRowCellValue(index, "GHICHU").ToString();
                 temp10 = gridView1.GetRowCellValue(index, "NGHIHOC").ToString();
                if(dal.CheckMaSVinDiem(gridView1.GetRowCellValue(index, "MASV").ToString())>0)
                {
                    btnxoa.Enabled = false;
                }
                else
                {
                    btnxoa.Enabled = true;
                }
            }
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //txtmalop.Enabled = true;
            txtmasv.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            //txtmalop.Text ="";

            
            txtphai.SelectedIndex = 0;
            txtdate.Text = "";
            txtnoisinh.Text = "";
            txtdiachi.Text = "";
            txtghichu.Text = "";
           
           txtnghihoc.SelectedIndex = 0;           
        }

        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //list= new List<BeanSinhVien>();
            if (CheckData())
            {
                BeanSinhVien sv = new BeanSinhVien();
                sv.MASV = txtmasv.Text;
                sv.HO = txtho.Text;
                sv.TEN = txtten.Text;
                sv.MALOP = txtmalop.Text;
                Boolean phai = Boolean.Parse(txtphai.Text);
                sv.PHAI = phai;
                sv.NGAYSINH = txtdate.Text;
                sv.NOISINH = txtnoisinh.Text;
                sv.DIACHI = txtdiachi.Text;
                sv.GHICHU = txtghichu.Text;
                bool nghihoc = bool.Parse(txtnghihoc.Text);
                sv.NGHIHOC = nghihoc;
                st.Push(sv);
                if (MessageBox.Show("Ban muon xoa khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (dal.DeleteSinhVien(sv))
                    {
                        ShowSinhVien();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void BarButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckData())
            {
                BeanSinhVien sv = new BeanSinhVien();
                sv.MASV = txtmasv.Text;
                sv.HO = txtho.Text;
                sv.TEN = txtten.Text;
                sv.MALOP = txtmalop.Text;
                Boolean phai = Boolean.Parse(txtphai.Text);
                sv.PHAI = phai;
                sv.NGAYSINH = txtdate.Text;
                sv.NOISINH = txtnoisinh.Text;
                sv.DIACHI = txtdiachi.Text;
                sv.GHICHU = txtghichu.Text;
                bool nghihoc = bool.Parse(txtnghihoc.Text);
                sv.NGHIHOC = nghihoc;
                if (dal.UpdateSinhVien(sv))
                {
                    ShowSinhVien();

                }

                else
                {
                    MessageBox.Show("Đã có lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (Program.mGroup.Equals("PGV"))
            {
                try
                {
                    Program.servername = cmb2.SelectedValue.ToString();
                    if(Program.servername.Equals(Program.tenServerDN))
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                        DataConnection dc = new DataConnection();
                        //MessageBox.Show(Program.mloginDN);
                        //load
                        lobll = new LopBLL();
                        ShowAllLop();
                        Program.maLopSub = dataGridView1.Rows[0].Cells["MALOP"].Value.ToString();
                        dal = new SinhVienDAL();
                        ShowSinhVien();


                        int index1 = gridView1.FocusedRowHandle;
                        if (index1 >= 0)
                        {
                            txtmasv.Text = gridView1.GetRowCellValue(0, "MASV").ToString();
                            txtho.Text = gridView1.GetRowCellValue(0, "HO").ToString();
                            txtten.Text = gridView1.GetRowCellValue(0, "TEN").ToString();
                            //txtmalop.Text = gridView1.GetRowCellValue(index, "MALOP").ToString();
                            txtmalop.Text = dataGridView1.Rows[index].Cells["MALOP"].Value.ToString();
                            if (gridView1.GetRowCellValue(0, "PHAI").ToString().Equals("True"))
                            {
                                txtphai.SelectedIndex = 0;
                            }
                            else
                            {
                                txtphai.SelectedIndex = 1;
                            }
                            txtdate.Text = gridView1.GetRowCellValue(0, "NGAYSINH").ToString();
                            txtnoisinh.Text = gridView1.GetRowCellValue(0, "NOISINH").ToString();
                            txtdiachi.Text = gridView1.GetRowCellValue(0, "DIACHI").ToString();
                            txtghichu.Text = gridView1.GetRowCellValue(0, "GHICHU").ToString();
                            if (gridView1.GetRowCellValue(0, "NGHIHOC").ToString().Equals("True"))
                            {
                                txtnghihoc.SelectedIndex = 0;
                            }
                            else
                            {
                                txtnghihoc.SelectedIndex = 1;
                            }
                        }
                    }
                    else
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                        DataConnection dc = new DataConnection();


                        //Program.KetNoi();
                        lobll = new LopBLL();
                        ShowAllLop();
                        Program.maLopSub = dataGridView1.Rows[0].Cells["MALOP"].Value.ToString();
                        dal = new SinhVienDAL();
                        ShowSinhVien();


                        int index1 = gridView1.FocusedRowHandle;
                        if (index1 >= 0)
                        {
                            txtmasv.Text = gridView1.GetRowCellValue(0, "MASV").ToString();
                            txtho.Text = gridView1.GetRowCellValue(0, "HO").ToString();
                            txtten.Text = gridView1.GetRowCellValue(0, "TEN").ToString();
                            //txtmalop.Text = gridView1.GetRowCellValue(index, "MALOP").ToString();
                            txtmalop.Text = dataGridView1.Rows[0].Cells["MALOP"].Value.ToString();
                            if (gridView1.GetRowCellValue(0, "PHAI").ToString().Equals("True"))
                            {
                                txtphai.SelectedIndex = 0;
                            }
                            else
                            {
                                txtphai.SelectedIndex = 1;
                            }
                            txtdate.Text = gridView1.GetRowCellValue(0, "NGAYSINH").ToString();
                            txtnoisinh.Text = gridView1.GetRowCellValue(0, "NOISINH").ToString();
                            txtdiachi.Text = gridView1.GetRowCellValue(0, "DIACHI").ToString();
                            txtghichu.Text = gridView1.GetRowCellValue(0, "GHICHU").ToString();
                            if (gridView1.GetRowCellValue(0, "NGHIHOC").ToString().Equals("True"))
                            {
                                txtnghihoc.SelectedIndex = 0;
                            }
                            else
                            {
                                txtnghihoc.SelectedIndex = 1;
                            }
                        }

                    }

                }
                catch (Exception)
                {


                }
            }
            st.Clear();
        }

        private void Btnphuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmasv.Text = temp1;
            txtho.Text = temp2;
            txtten.Text = temp3;
            txtmalop.Text = temp4;

            if (temp5.Equals("True"))
            {
                txtphai.SelectedIndex = 0;
            }
            else
            {
                txtphai.SelectedIndex = 1;
            }
            txtdate.Text = temp6;
            txtnoisinh.Text = temp7;
            txtdiachi.Text = temp8;
            txtghichu.Text = temp9;
            if (temp10.Equals("True"))
            {
                txtnghihoc.SelectedIndex = 0;
            }
            else
            {
                txtnghihoc.SelectedIndex = 1;
            }
        }

        private void BarButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //list= new List<BeanSinhVien>();
                BeanSinhVien sv = st.Pop();
                
                if (dal.InsertSinhVien(sv))
                {
                    ShowSinhVien();
                    //MessageBox.Show("Phục hồi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {
                    //MessageBox.Show("Đã có lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            //int index1 = 0;
            if (index >= 0)
            {
                txtmalop.Text= dataGridView1.Rows[index].Cells["MALOP"].Value.ToString();
                Program.maLopSub = dataGridView1.Rows[index].Cells["MALOP"].Value.ToString();
                ShowSinhVien();
                int index1 = gridView1.FocusedRowHandle;
                if (index1 >= 0)
                {
                    txtmasv.Text = gridView1.GetRowCellValue(0, "MASV").ToString();
                    txtho.Text = gridView1.GetRowCellValue(0, "HO").ToString();
                    txtten.Text = gridView1.GetRowCellValue(0, "TEN").ToString();
                    //txtmalop.Text = gridView1.GetRowCellValue(index, "MALOP").ToString();
                    //txtmalop.Text = dataGridView1.Rows[index].Cells["MALOP"].Value.ToString();
                    if (gridView1.GetRowCellValue(0 ,"PHAI").ToString().Equals("True"))
                    {
                        txtphai.SelectedIndex = 0;
                    }
                    else
                    {
                        txtphai.SelectedIndex = 1;
                    }
                    txtdate.Text = gridView1.GetRowCellValue(0, "NGAYSINH").ToString();
                    txtnoisinh.Text = gridView1.GetRowCellValue(0, "NOISINH").ToString();
                    txtdiachi.Text = gridView1.GetRowCellValue(0, "DIACHI").ToString();
                    txtghichu.Text = gridView1.GetRowCellValue(0, "GHICHU").ToString();
                    if (gridView1.GetRowCellValue(0, "NGHIHOC").ToString().Equals("True"))
                    {
                        txtnghihoc.SelectedIndex = 0;
                    }
                    else
                    {
                        txtnghihoc.SelectedIndex = 1;
                    }
                }
            }
        }
    }
}