
namespace THICK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtQLGV = new DevExpress.XtraBars.BarButtonItem();
            this.bbtQLSV = new DevExpress.XtraBars.BarButtonItem();
            this.bbtQLMH = new DevExpress.XtraBars.BarButtonItem();
            this.bbtQLCH = new DevExpress.XtraBars.BarButtonItem();
            this.bbtTHI = new DevExpress.XtraBars.BarButtonItem();
            this.bbtDN = new DevExpress.XtraBars.BarButtonItem();
            this.bbtTTK = new DevExpress.XtraBars.BarButtonItem();
            this.bbtDX = new DevExpress.XtraBars.BarButtonItem();
            this.bbtDoiPass = new DevExpress.XtraBars.BarButtonItem();
            this.bbtQLDT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.rbpPGV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpGV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSV = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBR = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolMND = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolHOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolROLE = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbtQLGV,
            this.bbtQLSV,
            this.bbtQLMH,
            this.bbtQLCH,
            this.bbtTHI,
            this.bbtDN,
            this.bbtTTK,
            this.bbtDX,
            this.bbtDoiPass,
            this.bbtQLDT,
            this.barButtonItem1,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(24, 30, 24, 30);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpPGV,
            this.rbpGV,
            this.rbpSV,
            this.rbpHT,
            this.rbpBR});
            this.ribbonControl1.Size = new System.Drawing.Size(1592, 193);
            // 
            // bbtQLGV
            // 
            this.bbtQLGV.Caption = "Quản Lý Giảng Viên";
            this.bbtQLGV.Id = 1;
            this.bbtQLGV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtQLGV.ImageOptions.Image")));
            this.bbtQLGV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtQLGV.ImageOptions.LargeImage")));
            this.bbtQLGV.LargeWidth = 100;
            this.bbtQLGV.Name = "bbtQLGV";
            this.bbtQLGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtQLGV_ItemClick);
            // 
            // bbtQLSV
            // 
            this.bbtQLSV.Caption = "Quản Lý Sinh Viên";
            this.bbtQLSV.Id = 3;
            this.bbtQLSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtQLSV.ImageOptions.SvgImage")));
            this.bbtQLSV.LargeWidth = 100;
            this.bbtQLSV.Name = "bbtQLSV";
            this.bbtQLSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtQLSV_ItemClick);
            // 
            // bbtQLMH
            // 
            this.bbtQLMH.Caption = "Quản Lý Môn Học";
            this.bbtQLMH.Id = 4;
            this.bbtQLMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtQLMH.ImageOptions.Image")));
            this.bbtQLMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtQLMH.ImageOptions.LargeImage")));
            this.bbtQLMH.LargeWidth = 100;
            this.bbtQLMH.Name = "bbtQLMH";
            this.bbtQLMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtQLMH_ItemClick);
            // 
            // bbtQLCH
            // 
            this.bbtQLCH.Caption = "Quản Lý Câu Hỏi";
            this.bbtQLCH.Id = 6;
            this.bbtQLCH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtQLCH.ImageOptions.Image")));
            this.bbtQLCH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtQLCH.ImageOptions.LargeImage")));
            this.bbtQLCH.LargeWidth = 100;
            this.bbtQLCH.Name = "bbtQLCH";
            this.bbtQLCH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtQLCH_ItemClick);
            // 
            // bbtTHI
            // 
            this.bbtTHI.Caption = "Vào Thi";
            this.bbtTHI.Id = 7;
            this.bbtTHI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtTHI.ImageOptions.Image")));
            this.bbtTHI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtTHI.ImageOptions.LargeImage")));
            this.bbtTHI.LargeWidth = 100;
            this.bbtTHI.Name = "bbtTHI";
            this.bbtTHI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtTHI_ItemClick);
            // 
            // bbtDN
            // 
            this.bbtDN.Caption = "Đăng Nhập";
            this.bbtDN.Id = 8;
            this.bbtDN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtDN.ImageOptions.Image")));
            this.bbtDN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtDN.ImageOptions.LargeImage")));
            this.bbtDN.LargeWidth = 100;
            this.bbtDN.Name = "bbtDN";
            this.bbtDN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtDN_ItemClick);
            // 
            // bbtTTK
            // 
            this.bbtTTK.Caption = "Tạo Tài Khoản";
            this.bbtTTK.Enabled = false;
            this.bbtTTK.Id = 9;
            this.bbtTTK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtTTK.ImageOptions.SvgImage")));
            this.bbtTTK.LargeWidth = 100;
            this.bbtTTK.Name = "bbtTTK";
            this.bbtTTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtTTK_ItemClick);
            // 
            // bbtDX
            // 
            this.bbtDX.Caption = "Đăng Xuất";
            this.bbtDX.Enabled = false;
            this.bbtDX.Id = 10;
            this.bbtDX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtDX.ImageOptions.Image")));
            this.bbtDX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtDX.ImageOptions.LargeImage")));
            this.bbtDX.LargeWidth = 100;
            this.bbtDX.Name = "bbtDX";
            this.bbtDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtDX_ItemClick);
            // 
            // bbtDoiPass
            // 
            this.bbtDoiPass.Caption = "Đổi Mật Khẩu";
            this.bbtDoiPass.Enabled = false;
            this.bbtDoiPass.Id = 11;
            this.bbtDoiPass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtDoiPass.ImageOptions.SvgImage")));
            this.bbtDoiPass.LargeWidth = 100;
            this.bbtDoiPass.Name = "bbtDoiPass";
            this.bbtDoiPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtDoiPass_ItemClick);
            // 
            // bbtQLDT
            // 
            this.bbtQLDT.Id = 13;
            this.bbtQLDT.Name = "bbtQLDT";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "BACKUP";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "RESTORE";
            this.barButtonItem5.Id = 15;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.LargeWidth = 100;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // rbpPGV
            // 
            this.rbpPGV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpPGV.Name = "rbpPGV";
            this.rbpPGV.Text = "Phòng Giáo Vụ";
            this.rbpPGV.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtQLGV);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtQLSV);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtQLMH);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý Phần Mềm";
            // 
            // rbpGV
            // 
            this.rbpGV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpGV.Name = "rbpGV";
            this.rbpGV.Text = "Giảng Viên";
            this.rbpGV.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtQLCH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpSV
            // 
            this.rbpSV.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpSV.Name = "rbpSV";
            this.rbpSV.Text = "Sinh Viên";
            this.rbpSV.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtTHI);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpHT
            // 
            this.rbpHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpHT.Name = "rbpHT";
            this.rbpHT.Text = "Hệ Thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtDN);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtDoiPass);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtTTK);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtDX);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản Lý Tài Khoản";
            // 
            // rbpBR
            // 
            this.rbpBR.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.rbpBR.Name = "rbpBR";
            this.rbpBR.Text = "Backup And Restore";
            this.rbpBR.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Sao Lưu Và Khôi Phục";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMND,
            this.toolHOTEN,
            this.toolROLE});
            this.statusStrip1.Location = new System.Drawing.Point(0, 932);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1592, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolMND
            // 
            this.toolMND.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMND.ForeColor = System.Drawing.Color.Black;
            this.toolMND.Name = "toolMND";
            this.toolMND.Size = new System.Drawing.Size(140, 19);
            this.toolMND.Text = "Mã Người Dùng : ";
            // 
            // toolHOTEN
            // 
            this.toolHOTEN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHOTEN.ForeColor = System.Drawing.Color.Black;
            this.toolHOTEN.Name = "toolHOTEN";
            this.toolHOTEN.Size = new System.Drawing.Size(139, 19);
            this.toolHOTEN.Text = "          Họ Và Tên : ";
            // 
            // toolROLE
            // 
            this.toolROLE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolROLE.ForeColor = System.Drawing.Color.Black;
            this.toolROLE.Name = "toolROLE";
            this.toolROLE.Size = new System.Drawing.Size(116, 19);
            this.toolROLE.Text = "          Vai Trò : ";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản Lý Đề Thi";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.LargeWidth = 100;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản Lý Đề Thi";
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.LargeWidth = 100;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản Lý Đề Thi";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.LargeWidth = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Bảng Điểm";
            this.barButtonItem6.Id = 16;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.LargeWidth = 100;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 957);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lí Thi Trắc Nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpPGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbtQLGV;
        private DevExpress.XtraBars.BarButtonItem bbtQLSV;
        private DevExpress.XtraBars.BarButtonItem bbtQLMH;
        private DevExpress.XtraBars.BarButtonItem bbtQLCH;
        private DevExpress.XtraBars.BarButtonItem bbtTHI;
        private DevExpress.XtraBars.BarButtonItem bbtDN;
        private DevExpress.XtraBars.BarButtonItem bbtTTK;
        private DevExpress.XtraBars.BarButtonItem bbtDX;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpSV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolMND;
        public System.Windows.Forms.ToolStripStatusLabel toolHOTEN;
        public System.Windows.Forms.ToolStripStatusLabel toolROLE;
        private DevExpress.XtraBars.BarButtonItem bbtDoiPass;
        private DevExpress.XtraBars.BarButtonItem bbtQLDT;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBR;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}

