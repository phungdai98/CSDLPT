﻿using System;
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
    public partial class formReportBangDiem : DevExpress.XtraEditors.XtraForm
    {
        
        public formReportBangDiem()
        {
            InitializeComponent();
        }

        private void FormReportBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;

            cmbTenLop.SelectedIndex = 0;
            Program.rptMalop = cmbTenLop.SelectedValue.ToString();
            cmbMonHoc.SelectedIndex = 0;

            Program.rptMaMh = cmbMonHoc.SelectedValue.ToString();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            BangDiemSV rpt = new BangDiemSV(Program.rptMalop, Program.rptMaMh, int.Parse(txtLan.Text));
            rpt.xrLop.Text = cmbTenLop.Text;
            rpt.xrMh.Text = cmbMonHoc.Text;
            rpt.xrlan.Text = txtLan.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void CmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
                
            try
            {
                Program.rptMalop = cmbTenLop.SelectedValue.ToString();
                MessageBox.Show(Program.rptMalop);
            }
            catch (Exception)
            {

                
            }
           
        }

        private void CmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.rptMaMh = cmbMonHoc.SelectedValue.ToString();
                MessageBox.Show(Program.rptMaMh);
            }
            catch (Exception)
            {

                
            }
        }
    }
}