using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLDSV1
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinhVien frm = new SinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BarButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormClass fcl = new FormClass();
            fcl.MdiParent = this;
            fcl.Show();
        }

        private void BarButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DiemSinhVien dsv = new DiemSinhVien();
            dsv.MdiParent = this;
            dsv.Show();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Summer");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Springtime");
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //btnMonHoc
            frmMonHoc mh = new frmMonHoc();
            mh.MdiParent = this;
            mh.Show();
        }
    }
}