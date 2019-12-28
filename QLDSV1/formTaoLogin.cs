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
    public partial class formTaoLogin : DevExpress.XtraEditors.XtraForm
    {
        public formTaoLogin()
        {
            InitializeComponent();
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet1.V_DS_PHANMANH2' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANH2TableAdapter.Fill(this.qLDSVDataSet1.V_DS_PHANMANH2);

        }
    }
}