namespace QLDSV1
{
    partial class DiemSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemSinhVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableDiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtlop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmonhoc = new DevExpress.XtraEditors.TextEdit();
            this.txtlanthi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDiem = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANH2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1 = new QLDSV1.QLDSVDataSet1();
            this.v_DS_PHANMANH2TableAdapter = new QLDSV1.QLDSVDataSet1TableAdapters.V_DS_PHANMANH2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonhoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlanthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnSave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bắt đầu";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu lại";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem2_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1269, 53);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1269, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 431);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1269, 53);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 431);
            // 
            // tableDiem
            // 
            this.tableDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableDiem.Location = new System.Drawing.Point(0, 53);
            this.tableDiem.MainView = this.gridView1;
            this.tableDiem.MenuManager = this.barManager1;
            this.tableDiem.Name = "tableDiem";
            this.tableDiem.Size = new System.Drawing.Size(1269, 200);
            this.tableDiem.TabIndex = 4;
            this.tableDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tableDiem;
            this.gridView1.Name = "gridView1";
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(327, 33);
            this.txtlop.MenuManager = this.barManager1;
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 20);
            this.txtlop.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(264, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Lớp";
            // 
            // txtmonhoc
            // 
            this.txtmonhoc.Location = new System.Drawing.Point(601, 33);
            this.txtmonhoc.MenuManager = this.barManager1;
            this.txtmonhoc.Name = "txtmonhoc";
            this.txtmonhoc.Size = new System.Drawing.Size(100, 20);
            this.txtmonhoc.TabIndex = 7;
            // 
            // txtlanthi
            // 
            this.txtlanthi.Location = new System.Drawing.Point(866, 29);
            this.txtlanthi.MenuManager = this.barManager1;
            this.txtlanthi.Name = "txtlanthi";
            this.txtlanthi.Size = new System.Drawing.Size(100, 20);
            this.txtlanthi.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(514, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Môn học";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(787, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Lần thi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(835, 290);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 40);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Kết thuc";
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // cmbDiem
            // 
            this.cmbDiem.DataSource = this.vDSPHANMANH2BindingSource;
            this.cmbDiem.DisplayMember = "TENKHOA";
            this.cmbDiem.FormattingEnabled = true;
            this.cmbDiem.Location = new System.Drawing.Point(1070, 28);
            this.cmbDiem.Name = "cmbDiem";
            this.cmbDiem.Size = new System.Drawing.Size(121, 21);
            this.cmbDiem.TabIndex = 20;
            this.cmbDiem.ValueMember = "TENSERVER";
            this.cmbDiem.SelectedIndexChanged += new System.EventHandler(this.CmbDiem_SelectedIndexChanged);
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
            // v_DS_PHANMANH2TableAdapter
            // 
            this.v_DS_PHANMANH2TableAdapter.ClearBeforeFill = true;
            // 
            // DiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 507);
            this.Controls.Add(this.cmbDiem);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtlanthi);
            this.Controls.Add(this.txtmonhoc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.tableDiem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DiemSinhVien";
            this.Text = "DiemSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmonhoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlanthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANH2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl tableDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtlanthi;
        private DevExpress.XtraEditors.TextEdit txtmonhoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtlop;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmbDiem;
        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource vDSPHANMANH2BindingSource;
        private QLDSVDataSet1TableAdapters.V_DS_PHANMANH2TableAdapter v_DS_PHANMANH2TableAdapter;
    }
}