
namespace THICK
{
    partial class frmQLGV
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label hOCVILabel;
            System.Windows.Forms.Label mAKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLGV));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnGHI = new DevExpress.XtraBars.BarButtonItem();
            this.btnHUY = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnSUA = new DevExpress.XtraBars.BarButtonItem();
            this.DATA = new THICK.DATA();
            this.bdsGV = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGVIENTableAdapter = new THICK.DATATableAdapters.GIANGVIENTableAdapter();
            this.tableAdapterManager = new THICK.DATATableAdapters.TableAdapterManager();
            this.cAUHOITableAdapter = new THICK.DATATableAdapters.CAUHOITableAdapter();
            this.xEPLICHTHITableAdapter = new THICK.DATATableAdapters.XEPLICHTHITableAdapter();
            this.gcGV = new DevExpress.XtraGrid.GridControl();
            this.gridVGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcChiTiet = new DevExpress.XtraEditors.PanelControl();
            this.txtMAKHOA = new DevExpress.XtraEditors.TextEdit();
            this.txtHOCVI = new DevExpress.XtraEditors.TextEdit();
            this.txtPHAI = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsXLT = new System.Windows.Forms.BindingSource(this.components);
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            hOCVILabel = new System.Windows.Forms.Label();
            mAKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChiTiet)).BeginInit();
            this.pcChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOCVI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXLT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAGVLabel.Location = new System.Drawing.Point(125, 140);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(62, 19);
            mAGVLabel.TabIndex = 1;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(125, 191);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(38, 19);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(125, 245);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 19);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "TEN:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pHAILabel.Location = new System.Drawing.Point(555, 140);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(52, 19);
            pHAILabel.TabIndex = 7;
            pHAILabel.Text = "PHAI:";
            // 
            // hOCVILabel
            // 
            hOCVILabel.AutoSize = true;
            hOCVILabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCVILabel.Location = new System.Drawing.Point(555, 191);
            hOCVILabel.Name = "hOCVILabel";
            hOCVILabel.Size = new System.Drawing.Size(65, 19);
            hOCVILabel.TabIndex = 9;
            hOCVILabel.Text = "HOCVI:";
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(555, 245);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(87, 19);
            mAKHOALabel.TabIndex = 11;
            mAKHOALabel.Text = "MAKHOA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnSUA,
            this.btnGHI,
            this.btnHUY,
            this.btnTHOAT});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTHEM),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXOA),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGHI),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHUY),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTHOAT)});
            this.bar1.Text = "Tools";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 0;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTHEM.Size = new System.Drawing.Size(130, 30);
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Caption = "Xóa";
            this.btnXOA.Id = 1;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXOA.Size = new System.Drawing.Size(130, 30);
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnGHI
            // 
            this.btnGHI.Caption = "Ghi";
            this.btnGHI.Id = 3;
            this.btnGHI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGHI.ImageOptions.SvgImage")));
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGHI.Size = new System.Drawing.Size(130, 30);
            this.btnGHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnHUY
            // 
            this.btnHUY.Caption = "Hủy";
            this.btnHUY.Id = 4;
            this.btnHUY.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHUY.ImageOptions.SvgImage")));
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHUY.Size = new System.Drawing.Size(130, 30);
            this.btnHUY.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHUY_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 5;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTHOAT.Size = new System.Drawing.Size(130, 30);
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl4.Location = new System.Drawing.Point(0, 0);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(1227, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 705);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1227, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 668);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1227, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 668);
            // 
            // btnSUA
            // 
            this.btnSUA.Caption = "Hiệu Chỉnh";
            this.btnSUA.Id = 2;
            this.btnSUA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSUA.ImageOptions.SvgImage")));
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSUA.Size = new System.Drawing.Size(130, 30);
            // 
            // DATA
            // 
            this.DATA.DataSetName = "DATA";
            this.DATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGV
            // 
            this.bdsGV.DataMember = "GIANGVIEN";
            this.bdsGV.DataSource = this.DATA;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = this.cAUHOITableAdapter;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = this.gIANGVIENTableAdapter;
            this.tableAdapterManager.KETQUATHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THICK.DATATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLICHTHITableAdapter = this.xEPLICHTHITableAdapter;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // xEPLICHTHITableAdapter
            // 
            this.xEPLICHTHITableAdapter.ClearBeforeFill = true;
            // 
            // gcGV
            // 
            this.gcGV.DataSource = this.bdsGV;
            this.gcGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGV.Location = new System.Drawing.Point(0, 37);
            this.gcGV.MainView = this.gridVGV;
            this.gcGV.MenuManager = this.barManager1;
            this.gcGV.Name = "gcGV";
            this.gcGV.Size = new System.Drawing.Size(1227, 220);
            this.gcGV.TabIndex = 10;
            this.gcGV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVGV});
            // 
            // gridVGV
            // 
            this.gridVGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colHOCVI,
            this.colMAKHOA});
            this.gridVGV.GridControl = this.gcGV;
            this.gridVGV.Name = "gridVGV";
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            this.colMAGV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 94;
            // 
            // colHOCVI
            // 
            this.colHOCVI.FieldName = "HOCVI";
            this.colHOCVI.MinWidth = 25;
            this.colHOCVI.Name = "colHOCVI";
            this.colHOCVI.Visible = true;
            this.colHOCVI.VisibleIndex = 4;
            this.colHOCVI.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 5;
            this.colMAKHOA.Width = 94;
            // 
            // pcChiTiet
            // 
            this.pcChiTiet.Controls.Add(mAKHOALabel);
            this.pcChiTiet.Controls.Add(this.txtMAKHOA);
            this.pcChiTiet.Controls.Add(hOCVILabel);
            this.pcChiTiet.Controls.Add(this.txtHOCVI);
            this.pcChiTiet.Controls.Add(pHAILabel);
            this.pcChiTiet.Controls.Add(this.txtPHAI);
            this.pcChiTiet.Controls.Add(tENLabel);
            this.pcChiTiet.Controls.Add(this.txtTEN);
            this.pcChiTiet.Controls.Add(hOLabel);
            this.pcChiTiet.Controls.Add(this.txtHO);
            this.pcChiTiet.Controls.Add(mAGVLabel);
            this.pcChiTiet.Controls.Add(this.txtMAGV);
            this.pcChiTiet.Controls.Add(this.label1);
            this.pcChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcChiTiet.Location = new System.Drawing.Point(0, 257);
            this.pcChiTiet.Margin = new System.Windows.Forms.Padding(8);
            this.pcChiTiet.Name = "pcChiTiet";
            this.pcChiTiet.Size = new System.Drawing.Size(1227, 448);
            this.pcChiTiet.TabIndex = 11;
            // 
            // txtMAKHOA
            // 
            this.txtMAKHOA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAKHOA", true));
            this.txtMAKHOA.Location = new System.Drawing.Point(655, 242);
            this.txtMAKHOA.MenuManager = this.barManager1;
            this.txtMAKHOA.Name = "txtMAKHOA";
            this.txtMAKHOA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAKHOA.Properties.Appearance.Options.UseFont = true;
            this.txtMAKHOA.Size = new System.Drawing.Size(125, 26);
            this.txtMAKHOA.TabIndex = 12;
            // 
            // txtHOCVI
            // 
            this.txtHOCVI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HOCVI", true));
            this.txtHOCVI.Location = new System.Drawing.Point(655, 186);
            this.txtHOCVI.MenuManager = this.barManager1;
            this.txtHOCVI.Name = "txtHOCVI";
            this.txtHOCVI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOCVI.Properties.Appearance.Options.UseFont = true;
            this.txtHOCVI.Size = new System.Drawing.Size(184, 26);
            this.txtHOCVI.TabIndex = 10;
            // 
            // txtPHAI
            // 
            this.txtPHAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "PHAI", true));
            this.txtPHAI.Location = new System.Drawing.Point(655, 135);
            this.txtPHAI.MenuManager = this.barManager1;
            this.txtPHAI.Name = "txtPHAI";
            this.txtPHAI.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHAI.Properties.Appearance.Options.UseFont = true;
            this.txtPHAI.Size = new System.Drawing.Size(125, 26);
            this.txtPHAI.TabIndex = 8;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(200, 242);
            this.txtTEN.MenuManager = this.barManager1;
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTEN.Properties.Appearance.Options.UseFont = true;
            this.txtTEN.Size = new System.Drawing.Size(237, 26);
            this.txtTEN.TabIndex = 6;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(200, 188);
            this.txtHO.MenuManager = this.barManager1;
            this.txtHO.Name = "txtHO";
            this.txtHO.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHO.Properties.Appearance.Options.UseFont = true;
            this.txtHO.Size = new System.Drawing.Size(125, 26);
            this.txtHO.TabIndex = 4;
            // 
            // txtMAGV
            // 
            this.txtMAGV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsGV, "MAGV", true));
            this.txtMAGV.Location = new System.Drawing.Point(200, 135);
            this.txtMAGV.MenuManager = this.barManager1;
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Size = new System.Drawing.Size(125, 26);
            this.txtMAGV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIẢNG VIÊN";
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "FK__CAUHOI__MAGV__3A81B327";
            this.bdsCH.DataSource = this.bdsGV;
            // 
            // bdsXLT
            // 
            this.bdsXLT.DataMember = "FK__XEPLICHTHI__MAGV__412EB0B6";
            this.bdsXLT.DataSource = this.bdsGV;
            // 
            // frmQLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 705);
            this.Controls.Add(this.pcChiTiet);
            this.Controls.Add(this.gcGV);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl4);
            this.Name = "frmQLGV";
            this.Text = "frmQLGV";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmQLGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcChiTiet)).EndInit();
            this.pcChiTiet.ResumeLayout(false);
            this.pcChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOCVI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnSUA;
        private DevExpress.XtraBars.BarButtonItem btnGHI;
        private DevExpress.XtraBars.BarButtonItem btnHUY;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsGV;
        private DATA DATA;
        private DATATableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVGV;
        private DevExpress.XtraEditors.PanelControl pcChiTiet;
        private DevExpress.XtraEditors.TextEdit txtMAKHOA;
        private DevExpress.XtraEditors.TextEdit txtHOCVI;
        private DevExpress.XtraEditors.TextEdit txtPHAI;
        private DevExpress.XtraEditors.TextEdit txtTEN;
        private DevExpress.XtraEditors.TextEdit txtHO;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DATATableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private System.Windows.Forms.BindingSource bdsCH;
        private DATATableAdapters.XEPLICHTHITableAdapter xEPLICHTHITableAdapter;
        private System.Windows.Forms.BindingSource bdsXLT;
    }
}