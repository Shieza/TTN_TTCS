using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THICK
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection connPublisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private bool orgDatabase_Connect()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu!\nBạn xem lại user name và password.\n " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.loginName = txtTaiKhoan.Text.Trim();
            Program.loginPwd = txtMatKhau.Text.Trim();
            if (Program.database_Connect() == false) return;

            String statement = "EXEC SP_DANGNHAP '" + Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            try
            {
                Program.userName = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.userName))
                {
                    MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.crtFullName = Program.myReader.GetString(1);
                Program.crtRole = Program.myReader.GetString(2);
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản này không được dùng để truy cập! \n Hãy thử tài khoản khác", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();

            txtTaiKhoan.Text = "sa";
            txtMatKhau.Text = "123";

            Program.frm_Main.toolMND.Text = "Mã Người Dùng : " + Program.userName;
            Program.frm_Main.toolHOTEN.Text = "          Họ Và Tên : " + Program.crtFullName;
            Program.frm_Main.toolROLE.Text = "          Vai Trò : " + Program.crtRole;

            this.Visible = false;
            Program.frm_Main.buttons_Enable();

        }
    }
}
