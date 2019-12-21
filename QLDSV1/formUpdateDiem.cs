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
    public partial class formUpdateDiem : DevExpress.XtraEditors.XtraForm
    {
        DiemSinhVienDAL dal;
        public formUpdateDiem()
        {
            InitializeComponent();
            dal = new DiemSinhVienDAL();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtmasv.Text)||string.IsNullOrEmpty(txtmamh.Text))
            {
                MessageBox.Show("Bạn chưa nhập dl", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasv.Focus();
                return false;
            }
            return true;
        }
        public void ShowDiem(string masv,string mamh)
        {
            DataTable dt = dal.getdIEM(masv,mamh);
            gridControl1.DataSource = dt;
        }
        private void FormUpdateDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            txtmamh.SelectedIndex = -1;
        }

        private void Txtmamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtmamh.SelectedIndex>-1)
            {
                Program.maMHComboBox = txtmamh.SelectedValue.ToString();
                //MessageBox.Show(Program.maMHComboBox);
            }
            
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if(CheckData())
            {
                string masv = txtmasv.Text;
                string mamh = Program.maMHComboBox;
                ShowDiem(masv, mamh);
            }
        }
    }
}