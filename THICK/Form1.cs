using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THICK
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {

            InitializeComponent();
        }

        //Check bảng có đang hoạt động hay không ?
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void bbtDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDangNhap form = new frmDangNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void bbtTTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmTaoTK));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmTaoTK form = new frmTaoTK();
                form.MdiParent = this;
                form.Show();
            }
        }

        public void buttons_Enable()
        {
            if (Program.crtRole == "GiamThi") 
            {
                bbtDoiPass.Enabled = true;
                bbtTTK.Enabled = false;
                bbtDN.Enabled = false;
                bbtDX.Enabled = true;
                rbpPGV.Visible = true;
            }
            if (Program.crtRole == "GiangVien") {
                bbtDoiPass.Enabled = true;
                bbtTTK.Enabled = false;
                bbtDN.Enabled = false;
                bbtDX.Enabled = true;
                rbpGV.Visible = true;

            }
            
            if (Program.crtRole == "SinhVien") {
                bbtDoiPass.Enabled = true;
                bbtTTK.Enabled = false;
                bbtDN.Enabled = false;
                bbtDX.Enabled = true;
                rbpSV.Visible = true;
            }

            if (Program.crtRole == "Adminnn")
            {
                bbtDoiPass.Enabled = true;
                bbtTTK.Enabled = true;
                bbtDN.Enabled = false;
                bbtDX.Enabled = true;
                rbpBR.Visible = true;
            }
        }


        private void bbtQLGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bbtQLGV.Enabled = false;
            Form f = this.CheckExists(typeof(frmQLGV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmQLGV form = new frmQLGV();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void bbtQLSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bbtQLSV.Enabled = false;
            Form f = this.CheckExists(typeof(frmQLSV));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmQLSV form = new frmQLSV();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void bbtQLMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmQLMH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmQLMH form = new frmQLMH();
                form.MdiParent = this;
                form.Show();
            }
        }

        

        private void bbtQLCH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmQLCH));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmQLCH form = new frmQLCH();
                form.MdiParent = this;
                form.Show();
            }

        }

        private void bbtTHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //bbtQLSV.Enabled = false;
            Form f = this.CheckExists(typeof(frmVaoThi));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmVaoThi form = new frmVaoThi();
                form.MdiParent = this;
                form.Show();
            }
        }

        public void bbtDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn Đăng xuất không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr != DialogResult.Yes) return;

            foreach (Form f in this.MdiChildren) f.Dispose();

            bbtDN.Enabled = true;
            bbtDX.Enabled = false;
            if (Program.crtRole != "")
            {
                bbtTTK.Enabled = false;
                bbtDoiPass.Enabled = false;
            }
                

            rbpGV.Visible = rbpPGV.Visible = rbpSV.Visible = false;

            Program.frm_Main.toolMND.Text = "Mã Người Dùng : ";
            Program.frm_Main.toolHOTEN.Text = "Họ và Tên : ";
            Program.frm_Main.toolROLE.Text = "Vai Trò : ";

            bbtDN_ItemClick(sender, e);
        }

        private void bbtDoiPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDoiPass));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDoiPass form = new frmDoiPass();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //con is the connection string
            if (MessageBox.Show("Xác nhận sao lưu phần mềm?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string aaa = @"Data Source=" + "DESKTOP-9GTOFMI" + ";Integrated Security=True;Initial Catalog = ThiTracNghiem; User ID = Adminnn" + "";
                SqlConnection con = new SqlConnection(aaa);
                con.Open();
                string str = "USE ThiTracNghiem;";
                string str1 = "BACKUP DATABASE ThiTracNghiem TO DISK = 'D:\\backupTTN.Bak' WITH FORMAT," +
                    "MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of ThiTracNghiem';";
                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Backup thành công, file backup được lưu tại địa chỉ: D:\\backupTTN.Bak !",
                    "Thông báo", MessageBoxButtons.OK);
                con.Close();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Bắt lỗi ko tồn tại file backup thì báo lỗi
            if (!File.Exists(@"D:\\backupTTN.Bak"))
            {
                MessageBox.Show("Chưa có file sao lưu," +
                    " không thể khôi phục dữ liệu\n Vui lòng sao lưu trước khi khôi phục dữ liệu!");
                return;
            }


            if (MessageBox.Show("Xác nhận khoi phục phần mềm?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string aaa = @"Data Source=" + "DESKTOP-9GTOFMI" + ";Integrated Security=True;Initial Catalog = ThiTracNghiem; User ID = Adminnn" + "";
                SqlConnection con = new SqlConnection(aaa);
                con.Open();

                string str = "USE master;";
                string str1 = "ALTER DATABASE " + "ThiTracNghiem" + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str3 = "RESTORE DATABASE " + "ThiTracNghiem" + " FROM DISK = 'D:\\backupTTN.Bak' WITH REPLACE ";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Restore thành công, ứng dụng sẽ khởi động lại! ", "Thông báo", MessageBoxButtons.OK);
                con.Close();
                Application.Restart();
                this.Hide();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmBANGDIEM));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmBANGDIEM form = new frmBANGDIEM();
                form.MdiParent = this;
                form.Show();
            }
        }
    }

}
