
namespace THICK
{
    partial class frmCHONGT
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
            this.DATA = new THICK.DATA();
            this.bdsGT = new System.Windows.Forms.BindingSource(this.components);
            this.pGVTableAdapter = new THICK.DATATableAdapters.PGVTableAdapter();
            this.tableAdapterManager = new THICK.DATATableAdapters.TableAdapterManager();
            this.gcGT = new DevExpress.XtraGrid.GridControl();
            this.gridVGT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnCHON = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.colMAGIAMTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.DataSetName = "DATA";
            this.DATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsGT
            // 
            this.bdsGT.DataMember = "PGV";
            this.bdsGT.DataSource = this.DATA;
            // 
            // pGVTableAdapter
            // 
            this.pGVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIANGVIEN1TableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KETQUATHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOC1TableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PGVTableAdapter = this.pGVTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THICK.DATATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLICHTHITableAdapter = null;
            // 
            // gcGT
            // 
            this.gcGT.DataSource = this.bdsGT;
            this.gcGT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcGT.Location = new System.Drawing.Point(0, 0);
            this.gcGT.MainView = this.gridVGT;
            this.gcGT.Name = "gcGT";
            this.gcGT.Size = new System.Drawing.Size(905, 292);
            this.gcGT.TabIndex = 1;
            this.gcGT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVGT});
            // 
            // gridVGT
            // 
            this.gridVGT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGIAMTHI,
            this.colHO,
            this.colTEN});
            this.gridVGT.GridControl = this.gcGT;
            this.gridVGT.Name = "gridVGT";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnHUY);
            this.panelControl1.Controls.Add(this.btnCHON);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 292);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(905, 220);
            this.panelControl1.TabIndex = 2;
            // 
            // btnCHON
            // 
            this.btnCHON.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHON.Location = new System.Drawing.Point(254, 87);
            this.btnCHON.Name = "btnCHON";
            this.btnCHON.Size = new System.Drawing.Size(100, 50);
            this.btnCHON.TabIndex = 0;
            this.btnCHON.Text = "Chọn";
            this.btnCHON.UseVisualStyleBackColor = true;
            this.btnCHON.Click += new System.EventHandler(this.btnCHON_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHUY.Location = new System.Drawing.Point(523, 87);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(100, 50);
            this.btnHUY.TabIndex = 1;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // colMAGIAMTHI
            // 
            this.colMAGIAMTHI.FieldName = "MAGIAMTHI";
            this.colMAGIAMTHI.MinWidth = 25;
            this.colMAGIAMTHI.Name = "colMAGIAMTHI";
            this.colMAGIAMTHI.Visible = true;
            this.colMAGIAMTHI.VisibleIndex = 0;
            this.colMAGIAMTHI.Width = 94;
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
            // frmCHONGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 512);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcGT);
            this.Name = "frmCHONGT";
            this.Text = "frmCHONND";
            this.Load += new System.EventHandler(this.frmCHONGT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DATA DATA;
        private System.Windows.Forms.BindingSource bdsGT;
        private DATATableAdapters.PGVTableAdapter pGVTableAdapter;
        private DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcGT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVGT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGIAMTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnCHON;
    }
}