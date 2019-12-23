namespace QLDSV1
{
    partial class formReportBangDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANH2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1 = new QLDSV1.QLDSVDataSet1();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV1.DS();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLan = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lOPTableAdapter = new QLDSV1.DSTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QLDSV1.DSTableAdapters.MONHOCTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.v_DS_PHANMANH2TableAdapter = new QLDSV1.QLDSVDataSet1TableAdapters.V_DS_PHANMANH2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.DataSource = this.vDSPHANMANH2BindingSource;
            this.cmbkhoa.DisplayMember = "TENKHOA";
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Location = new System.Drawing.Point(513, 12);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(121, 21);
            this.cmbkhoa.TabIndex = 0;
            this.cmbkhoa.ValueMember = "TENSERVER";
            this.cmbkhoa.SelectedIndexChanged += new System.EventHandler(this.Cmbkhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANH2BindingSource
            // 
            this.vDSPHANMANH2BindingSource.DataMember = "V_DS_PHANMANH2";
            this.vDSPHANMANH2BindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.lOPBindingSource;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(289, 77);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(121, 21);
            this.cmbTenLop.TabIndex = 1;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.CmbTenLop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(289, 139);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cmbMonHoc.TabIndex = 2;
            this.cmbMonHoc.ValueMember = "MAMH";
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.CmbMonHoc_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // txtLan
            // 
            this.txtLan.Location = new System.Drawing.Point(289, 207);
            this.txtLan.Name = "txtLan";
            this.txtLan.Size = new System.Drawing.Size(121, 21);
            this.txtLan.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(179, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên lớp";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Môn học";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(179, 215);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lần thi";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(572, 139);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 42);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "IN";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // v_DS_PHANMANH2TableAdapter
            // 
            this.v_DS_PHANMANH2TableAdapter.ClearBeforeFill = true;
            // 
            // formReportBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 322);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtLan);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(this.cmbkhoa);
            this.Name = "formReportBangDiem";
            this.Text = "formReportBangDiem";
            this.Load += new System.EventHandler(this.FormReportBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.TextBox txtLan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DS dS;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource vDSPHANMANH2BindingSource;
        private QLDSVDataSet1TableAdapters.V_DS_PHANMANH2TableAdapter v_DS_PHANMANH2TableAdapter;
    }
}