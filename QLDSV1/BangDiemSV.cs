using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV1
{
    public partial class BangDiemSV : DevExpress.XtraReports.UI.XtraReport
    {
        public BangDiemSV(string malop,string mamh,int lanthi)
        {
            InitializeComponent();
            ds4.EnforceConstraints = false;
            this.sP_BANGDIEMTableAdapter1.Fill(ds4.SP_BANGDIEM, malop, mamh, lanthi);

        }

    }
}
