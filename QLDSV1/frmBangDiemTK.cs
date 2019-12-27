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
using DevExpress.XtraReports.UI;

namespace QLDSV1
{
    public partial class frmBangDiemTK : DevExpress.XtraEditors.XtraForm
    {
        DiemSinhVienDAL dal;
        string malop;

        public frmBangDiemTK()
        {
            InitializeComponent();
            dal = new DiemSinhVienDAL();
        }

        private void FrmBangDiemTK_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH2' table. You can move, or remove it, as needed.
        
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            dS.EnforceConstraints = false;
            this.v_DS_PHANMANH2TableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH2);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            cmbLop.SelectedIndex = 0;

            malop = cmbLop.SelectedValue.ToString();
            cmbKhoa.SelectedIndex = -1;
            cmbKhoa.SelectedIndex = Program.temp;
       
            if (Program.mGroup.Equals("KHOA"))
            {
                cmbKhoa.Enabled = false;
            }
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (Program.servername.Equals(Program.tenServerDN))
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                    DataConnection dc = new DataConnection();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.


                }
                else
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                    DataConnection dc = new DataConnection();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);

                }
            }
            catch (Exception)
            {


            }
        }

        private void CmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                malop = cmbLop.SelectedValue.ToString();
                MessageBox.Show(malop);
            }
            catch (Exception)
            {


            }
        }

        private void Btnpreview_Click(object sender, EventArgs e)
        {
            rptBangDiemTK rpt = new rptBangDiemTK(malop);
            rpt.xrLop.Text = cmbLop.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}