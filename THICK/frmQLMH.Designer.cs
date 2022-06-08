
namespace THICK
{
    partial class frmQLMH
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
            System.Windows.Forms.Label mAMONLabel;
            System.Windows.Forms.Label tENMONLabel;
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLMH));
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
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new THICK.DATATableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new THICK.DATATableAdapters.TableAdapterManager();
            this.cAUHOITableAdapter = new THICK.DATATableAdapters.CAUHOITableAdapter();
            this.xEPLICHTHITableAdapter = new THICK.DATATableAdapters.XEPLICHTHITableAdapter();
            this.gcMH = new DevExpress.XtraGrid.GridControl();
            this.gridVMH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcCTMH = new DevExpress.XtraEditors.PanelControl();
            this.txtSTTH = new DevExpress.XtraEditors.SpinEdit();
            this.txtSTLT = new DevExpress.XtraEditors.SpinEdit();
            this.txtTENMON = new DevExpress.XtraEditors.TextEdit();
            this.txtMAMON = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsXLT = new System.Windows.Forms.BindingSource(this.components);
            mAMONLabel = new System.Windows.Forms.Label();
            tENMONLabel = new System.Windows.Forms.Label();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCTMH)).BeginInit();
            this.pcCTMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTTH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTLT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXLT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMONLabel
            // 
            mAMONLabel.AutoSize = true;
            mAMONLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMONLabel.Location = new System.Drawing.Point(130, 125);
            mAMONLabel.Name = "mAMONLabel";
            mAMONLabel.Size = new System.Drawing.Size(79, 19);
            mAMONLabel.TabIndex = 1;
            mAMONLabel.Text = "MAMON:";
            // 
            // tENMONLabel
            // 
            tENMONLabel.AutoSize = true;
            tENMONLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMONLabel.Location = new System.Drawing.Point(130, 185);
            tENMONLabel.Name = "tENMONLabel";
            tENMONLabel.Size = new System.Drawing.Size(84, 19);
            tENMONLabel.TabIndex = 3;
            tENMONLabel.Text = "TENMON:";
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIET_LTLabel.Location = new System.Drawing.Point(600, 125);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(88, 19);
            sOTIET_LTLabel.TabIndex = 5;
            sOTIET_LTLabel.Text = "SOTIET LT:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIET_THLabel.Location = new System.Drawing.Point(600, 183);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(93, 19);
            sOTIET_THLabel.TabIndex = 7;
            sOTIET_THLabel.Text = "SOTIET TH:";
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
            this.barDockControl4.Size = new System.Drawing.Size(1292, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 783);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1292, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 746);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1292, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 746);
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
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.DATA;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = this.cAUHOITableAdapter;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KETQUATHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
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
            // gcMH
            // 
            this.gcMH.DataSource = this.bdsMH;
            this.gcMH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMH.Location = new System.Drawing.Point(0, 37);
            this.gcMH.MainView = this.gridVMH;
            this.gcMH.MenuManager = this.barManager1;
            this.gcMH.Name = "gcMH";
            this.gcMH.Size = new System.Drawing.Size(1292, 220);
            this.gcMH.TabIndex = 11;
            this.gcMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVMH});
            // 
            // gridVMH
            // 
            this.gridVMH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMON,
            this.colTENMON,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridVMH.GridControl = this.gcMH;
            this.gridVMH.Name = "gridVMH";
            // 
            // colMAMON
            // 
            this.colMAMON.FieldName = "MAMON";
            this.colMAMON.MinWidth = 25;
            this.colMAMON.Name = "colMAMON";
            this.colMAMON.Visible = true;
            this.colMAMON.VisibleIndex = 0;
            this.colMAMON.Width = 94;
            // 
            // colTENMON
            // 
            this.colTENMON.FieldName = "TENMON";
            this.colTENMON.MinWidth = 25;
            this.colTENMON.Name = "colTENMON";
            this.colTENMON.Visible = true;
            this.colTENMON.VisibleIndex = 1;
            this.colTENMON.Width = 94;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 25;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            this.colSOTIET_LT.Width = 94;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 25;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            this.colSOTIET_TH.Width = 94;
            // 
            // pcCTMH
            // 
            this.pcCTMH.Controls.Add(sOTIET_THLabel);
            this.pcCTMH.Controls.Add(this.txtSTTH);
            this.pcCTMH.Controls.Add(sOTIET_LTLabel);
            this.pcCTMH.Controls.Add(this.txtSTLT);
            this.pcCTMH.Controls.Add(tENMONLabel);
            this.pcCTMH.Controls.Add(this.txtTENMON);
            this.pcCTMH.Controls.Add(mAMONLabel);
            this.pcCTMH.Controls.Add(this.txtMAMON);
            this.pcCTMH.Controls.Add(this.label1);
            this.pcCTMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcCTMH.Location = new System.Drawing.Point(0, 257);
            this.pcCTMH.Name = "pcCTMH";
            this.pcCTMH.Size = new System.Drawing.Size(1292, 526);
            this.pcCTMH.TabIndex = 12;
            // 
            // txtSTTH
            // 
            this.txtSTTH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "SOTIET_TH", true));
            this.txtSTTH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSTTH.Location = new System.Drawing.Point(710, 180);
            this.txtSTTH.MenuManager = this.barManager1;
            this.txtSTTH.Name = "txtSTTH";
            this.txtSTTH.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTTH.Properties.Appearance.Options.UseFont = true;
            this.txtSTTH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSTTH.Size = new System.Drawing.Size(125, 26);
            this.txtSTTH.TabIndex = 8;
            // 
            // txtSTLT
            // 
            this.txtSTLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "SOTIET_LT", true));
            this.txtSTLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSTLT.Location = new System.Drawing.Point(710, 120);
            this.txtSTLT.MenuManager = this.barManager1;
            this.txtSTLT.Name = "txtSTLT";
            this.txtSTLT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTLT.Properties.Appearance.Options.UseFont = true;
            this.txtSTLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSTLT.Size = new System.Drawing.Size(125, 26);
            this.txtSTLT.TabIndex = 6;
            // 
            // txtTENMON
            // 
            this.txtTENMON.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "TENMON", true));
            this.txtTENMON.Location = new System.Drawing.Point(230, 180);
            this.txtTENMON.MenuManager = this.barManager1;
            this.txtTENMON.Name = "txtTENMON";
            this.txtTENMON.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTENMON.Properties.Appearance.Options.UseFont = true;
            this.txtTENMON.Size = new System.Drawing.Size(125, 26);
            this.txtTENMON.TabIndex = 4;
            // 
            // txtMAMON
            // 
            this.txtMAMON.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMH, "MAMON", true));
            this.txtMAMON.Location = new System.Drawing.Point(230, 120);
            this.txtMAMON.MenuManager = this.barManager1;
            this.txtMAMON.Name = "txtMAMON";
            this.txtMAMON.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAMON.Properties.Appearance.Options.UseFont = true;
            this.txtMAMON.Size = new System.Drawing.Size(125, 26);
            this.txtMAMON.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN MÔN HỌC";
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "FK__CAUHOI__MAMON__3B75D760";
            this.bdsCH.DataSource = this.bdsMH;
            // 
            // bdsXLT
            // 
            this.bdsXLT.DataMember = "FK__XEPLICHTH__MAMON__403A8C7D";
            this.bdsXLT.DataSource = this.bdsMH;
            // 
            // frmQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 783);
            this.Controls.Add(this.pcCTMH);
            this.Controls.Add(this.gcMH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl4);
            this.Name = "frmQLMH";
            this.Text = "frmQLMH";
            this.Load += new System.EventHandler(this.frmQLMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCTMH)).EndInit();
            this.pcCTMH.ResumeLayout(false);
            this.pcCTMH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTTH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTLT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTENMON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAMON.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsMH;
        private DATA DATA;
        private DATATableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMON;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMON;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraEditors.PanelControl pcCTMH;
        private DevExpress.XtraEditors.SpinEdit txtSTTH;
        private DevExpress.XtraEditors.SpinEdit txtSTLT;
        private DevExpress.XtraEditors.TextEdit txtTENMON;
        private DevExpress.XtraEditors.TextEdit txtMAMON;
        private System.Windows.Forms.Label label1;
        private DATATableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private System.Windows.Forms.BindingSource bdsCH;
        private DATATableAdapters.XEPLICHTHITableAdapter xEPLICHTHITableAdapter;
        private System.Windows.Forms.BindingSource bdsXLT;
    }
}