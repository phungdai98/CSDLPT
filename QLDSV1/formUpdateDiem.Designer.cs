namespace QLDSV1
{
    partial class formUpdateDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdateDiem));
            this.table_diem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV1.DS();
            this.mONHOCTableAdapter = new QLDSV1.DSTableAdapters.MONHOCTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtlanthi = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.table_diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // table_diem
            // 
            this.table_diem.Location = new System.Drawing.Point(590, 29);
            this.table_diem.MainView = this.gridView1;
            this.table_diem.Name = "table_diem";
            this.table_diem.Size = new System.Drawing.Size(427, 329);
            this.table_diem.TabIndex = 0;
            this.table_diem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.table_diem.Click += new System.EventHandler(this.Table_diem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.table_diem;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã sinh viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(306, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã môn học";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(125, 56);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(129, 21);
            this.txtmasv.TabIndex = 3;
            // 
            // txtmamh
            // 
            this.txtmamh.DataSource = this.mONHOCBindingSource;
            this.txtmamh.DisplayMember = "TENMH";
            this.txtmamh.FormattingEnabled = true;
            this.txtmamh.Location = new System.Drawing.Point(398, 56);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(129, 21);
            this.txtmamh.TabIndex = 4;
            this.txtmamh.ValueMember = "MAMH";
            this.txtmamh.SelectedIndexChanged += new System.EventHandler(this.Txtmamh_SelectedIndexChanged);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(248, 133);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 40);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Kiem tra";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // txtlanthi
            // 
            this.txtlanthi.Location = new System.Drawing.Point(125, 255);
            this.txtlanthi.Name = "txtlanthi";
            this.txtlanthi.Size = new System.Drawing.Size(129, 21);
            this.txtlanthi.TabIndex = 6;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(398, 255);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(129, 21);
            this.txtdiem.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 263);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Lần thi";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(306, 263);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Điểm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(255, 335);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(108, 35);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Lưu lại";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // formUpdateDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 408);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txtlanthi);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtmamh);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.table_diem);
            this.Name = "formUpdateDiem";
            this.Text = "formUpdateDiem";
            this.Load += new System.EventHandler(this.FormUpdateDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl table_diem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.ComboBox txtmamh;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtlanthi;
        private System.Windows.Forms.TextBox txtdiem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}