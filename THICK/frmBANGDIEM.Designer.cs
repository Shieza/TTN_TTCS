
namespace THICK
{
    partial class frmBANGDIEM
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
            this.bdsKQT = new System.Windows.Forms.BindingSource(this.components);
            this.kETQUATHITableAdapter = new THICK.DATATableAdapters.KETQUATHITableAdapter();
            this.tableAdapterManager = new THICK.DATATableAdapters.TableAdapterManager();
            this.bdsCTBT = new System.Windows.Forms.BindingSource(this.components);
            this.cT_BAITHITableAdapter = new THICK.DATATableAdapters.CT_BAITHITableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kETQUATHIGridControl = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUATHIGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.DataSetName = "DATA";
            this.DATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKQT
            // 
            this.bdsKQT.DataMember = "KETQUATHI";
            this.bdsKQT.DataSource = this.DATA;
            // 
            // kETQUATHITableAdapter
            // 
            this.kETQUATHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = this.cT_BAITHITableAdapter;
            this.tableAdapterManager.GIANGVIEN1TableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KETQUATHITableAdapter = this.kETQUATHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOC1TableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.PGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THICK.DATATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XEPLICHTHITableAdapter = null;
            // 
            // bdsCTBT
            // 
            this.bdsCTBT.DataMember = "FK__CT_BAITHI__KETQUATHI";
            this.bdsCTBT.DataSource = this.bdsKQT;
            // 
            // cT_BAITHITableAdapter
            // 
            this.cT_BAITHITableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDXL,
            this.colMASV,
            this.colDIEM});
            this.gridView1.GridControl = this.kETQUATHIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colIDXL
            // 
            this.colIDXL.FieldName = "IDXL";
            this.colIDXL.MinWidth = 25;
            this.colIDXL.Name = "colIDXL";
            this.colIDXL.Visible = true;
            this.colIDXL.VisibleIndex = 0;
            this.colIDXL.Width = 94;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 1;
            this.colMASV.Width = 94;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.MinWidth = 25;
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 2;
            this.colDIEM.Width = 94;
            // 
            // kETQUATHIGridControl
            // 
            this.kETQUATHIGridControl.DataSource = this.bdsCTBT;
            this.kETQUATHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kETQUATHIGridControl.Location = new System.Drawing.Point(0, 0);
            this.kETQUATHIGridControl.MainView = this.gridView1;
            this.kETQUATHIGridControl.Name = "kETQUATHIGridControl";
            this.kETQUATHIGridControl.Size = new System.Drawing.Size(921, 597);
            this.kETQUATHIGridControl.TabIndex = 1;
            this.kETQUATHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmBANGDIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 597);
            this.Controls.Add(this.kETQUATHIGridControl);
            this.Name = "frmBANGDIEM";
            this.Text = "frmBANGDIEM";
            this.Load += new System.EventHandler(this.frmBANGDIEM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kETQUATHIGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DATA DATA;
        private System.Windows.Forms.BindingSource bdsKQT;
        private DATATableAdapters.KETQUATHITableAdapter kETQUATHITableAdapter;
        private DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DATATableAdapters.CT_BAITHITableAdapter cT_BAITHITableAdapter;
        private System.Windows.Forms.BindingSource bdsCTBT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDXL;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private DevExpress.XtraGrid.GridControl kETQUATHIGridControl;
    }
}