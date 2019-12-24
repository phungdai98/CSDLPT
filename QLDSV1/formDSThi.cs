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
    public partial class formDSThi : DevExpress.XtraEditors.XtraForm
    {
        string lop = "";
        string monhoc = "";
        public formDSThi()
        {
            InitializeComponent();
        }

        private void FormDSThi_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH2' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH2TableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH2);
            cmbLop.SelectedIndex = 0;
            lop = cmbLop.SelectedValue.ToString();
            cmbMon.SelectedIndex = 0;
            cmbPhanManh.SelectedIndex = -1;
            cmbPhanManh.SelectedIndex = Program.temp;
            monhoc = cmbMon.SelectedValue.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lop = cmbLop.SelectedValue.ToString();
                //MessageBox.Show(Program.rptMalop);
            }
            catch (Exception)
            {


            }
        }

        private void CmbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                monhoc = cmbMon.SelectedValue.ToString();
                //MessageBox.Show(Program.rptMaMh);
            }
            catch (Exception)
            {


            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            DSTHIHETMON rpt = new DSTHIHETMON(lop);
            rpt.xrLop.Text = cmbLop.Text;
            rpt.xrMonHoc.Text = cmbMon.Text;
            rpt.xrNgay.Text = txtNgay.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void CmbPhanManh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbPhanManh.SelectedValue.ToString();
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
    }
}