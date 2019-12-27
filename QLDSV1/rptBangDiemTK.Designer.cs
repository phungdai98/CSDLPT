namespace QLDSV1
{
    partial class rptBangDiemTK
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBangDiemTK));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ds1 = new QLDSV1.DS();
            this.dIEMTableAdapter = new QLDSV1.DSTableAdapters.DIEMTableAdapter();
            this.sP_BANGDIEMTONGKETTableAdapter = new QLDSV1.DSTableAdapters.SP_BANGDIEMTONGKETTableAdapter();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fieldMASV1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldHOVATEN1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.xrPivotGridField1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDIEM1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldTENMH1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 192F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.HeightF = 295.4166F;
            this.Detail.Name = "Detail";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV1.Properties.Settings.QLDSVConnectionString1";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "SP_BANGDIEMTONGKET";
            queryParameter2.Name = "@MALOP";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "D16CQCN1";
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "SP_BANGDIEMTONGKET";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "QLDSV1.Properties.Settings.QLDSVConnectionString1";
            this.sqlDataSource2.Name = "sqlDataSource2";
            storedProcQuery3.Name = "SP_BANGDIEMTONGKET";
            queryParameter3.Name = "@MALOP";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "D16CQCN1";
            storedProcQuery3.Parameters.Add(queryParameter3);
            storedProcQuery3.StoredProcName = "SP_BANGDIEMTONGKET";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "QLDSV1.Properties.Settings.QLDSVConnectionString1";
            this.sqlDataSource3.Name = "sqlDataSource3";
            storedProcQuery4.Name = "SP_BANGDIEMTONGKET";
            queryParameter4.Name = "@MALOP";
            queryParameter4.Type = typeof(string);
            queryParameter4.ValueInfo = "D16CQCN1";
            storedProcQuery4.Parameters.Add(queryParameter4);
            storedProcQuery4.StoredProcName = "SP_BANGDIEMTONGKET";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // sP_BANGDIEMTONGKETTableAdapter
            // 
            this.sP_BANGDIEMTONGKETTableAdapter.ClearBeforeFill = true;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.Lines.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrPivotGrid1.DataMember = "SP_BANGDIEMTONGKET";
            this.xrPivotGrid1.DataSource = this.sqlDataSource4;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldMASV1,
            this.fieldHOVATEN1,
            this.xrPivotGridField1,
            this.fieldDIEM1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.29167F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(640F, 237.5F);
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "QLDSV1.Properties.Settings.QLDSVConnectionString1";
            this.sqlDataSource4.Name = "sqlDataSource4";
            storedProcQuery1.Name = "SP_BANGDIEMTONGKET";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D16CQCN1";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_BANGDIEMTONGKET";
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // fieldMASV1
            // 
            this.fieldMASV1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMASV1.AreaIndex = 0;
            this.fieldMASV1.Caption = "MASV";
            this.fieldMASV1.FieldName = "MASV";
            this.fieldMASV1.Name = "fieldMASV1";
            // 
            // fieldHOVATEN1
            // 
            this.fieldHOVATEN1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldHOVATEN1.AreaIndex = 1;
            this.fieldHOVATEN1.Caption = "HOVATEN";
            this.fieldHOVATEN1.FieldName = "HOVATEN";
            this.fieldHOVATEN1.Name = "fieldHOVATEN1";
            // 
            // xrPivotGridField1
            // 
            this.xrPivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.xrPivotGridField1.AreaIndex = 0;
            this.xrPivotGridField1.Caption = "TENMH";
            this.xrPivotGridField1.FieldName = "TENMH";
            this.xrPivotGridField1.Name = "xrPivotGridField1";
            // 
            // fieldDIEM1
            // 
            this.fieldDIEM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDIEM1.AreaIndex = 0;
            this.fieldDIEM1.Caption = "DIEM";
            this.fieldDIEM1.FieldName = "DIEM";
            this.fieldDIEM1.Name = "fieldDIEM1";
            // 
            // fieldTENMH1
            // 
            this.fieldTENMH1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTENMH1.AreaIndex = 0;
            this.fieldTENMH1.Caption = "TENMH";
            this.fieldTENMH1.FieldName = "TENMH";
            this.fieldTENMH1.Name = "fieldTENMH1";
            // 
            // rptBangDiemTK
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.ds1,
            this.sqlDataSource1,
            this.sqlDataSource2,
            this.sqlDataSource3,
            this.sqlDataSource4});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 192);
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DSTableAdapters.SP_BANGDIEMTONGKETTableAdapter sP_BANGDIEMTONGKETTableAdapter;
        private DS ds1;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldTENMH1;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldMASV1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldHOVATEN1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField xrPivotGridField1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDIEM1;
    }
}
