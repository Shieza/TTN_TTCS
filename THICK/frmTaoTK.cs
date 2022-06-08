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
    public partial class frmTaoTK : Form
    {
        public frmTaoTK()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void layDanhSachRole()
        {
            string sql = "SELECT * FROM V_GetRoles";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Program.conn.Close();

            cboVAITRO.DataSource = dt;
            cboVAITRO.DisplayMember = "name";
            cboVAITRO.ValueMember = "name";
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            layDanhSachRole();
            

        }

    

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtMAND.Text == "")
            {
                MessageBox.Show("Chưa chọn mã ND");
                btnMAND.Focus();
                return;
            }


            string sql = "CREATE LOGIN " + txtTaiKhoan.Text + " WITH PASSWORD = N'123', " +
                            "default_database = master, " +
                            "check_expiration = off, " +
                            "check_policy = off ";

            sql += ("\nCREATE USER " + txtTaiKhoan.Text + " FOR LOGIN " + txtTaiKhoan.Text);

            //phan quyen tren db
            sql += ("\nEXEC sp_addrolemember '" + cboVAITRO.SelectedValue.ToString() + "', N'" + txtTaiKhoan.Text + "'");

            if (cboVAITRO.SelectedValue.ToString() == "Adminnn")
            {
                // cho phép tạo login nếu tạo tài khoản có vai trò là QUANLY
                sql += ("\nEXEC sp_addsrvrolemember '" + txtTaiKhoan.Text + "', 'SecurityAdmin'");
            }

            //cho phep thuc thi sp dang nhap
            sql += ("\nGRANT EXECUTE ON SP_DANGNHAP TO " + txtTaiKhoan.Text);

            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                MessageBox.Show("Tạo tài khoản " + txtTaiKhoan.Text + " thành công!\nMật khẩu mặc định là: 123");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại do người dùng đã có tài khoản !");
                return;
            }


        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMAND_Click(object sender, EventArgs e)
        {
            if (cboVAITRO.Text == "Adminnn")
            {
                Form frm = CheckExists(typeof(frmCHONGT));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmCHONGT f = new frmCHONGT();
                    f.ShowDialog();
                    this.txtMAND.Text = Program.maNDDaChon;
                    txtTaiKhoan.Text = Program.maNDDaChon.Trim();
                }
            }
            if (cboVAITRO.Text == "GiamThi")
            {
                Form frm = CheckExists(typeof(frmCHONGT));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmCHONGT f = new frmCHONGT();
                    f.ShowDialog();
                    this.txtMAND.Text = Program.maNDDaChon;
                    txtTaiKhoan.Text = Program.maNDDaChon.Trim();
                }
            }
            if (cboVAITRO.Text == "GiangVien")
            {
                Form frm = CheckExists(typeof(frmCHONGV));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmCHONGV f = new frmCHONGV();
                    f.ShowDialog();
                    this.txtMAND.Text = Program.maNDDaChon;
                    txtTaiKhoan.Text = Program.maNDDaChon.Trim();
                }
            }
            if (cboVAITRO.Text == "SinhVien")
            {
                Form frm = CheckExists(typeof(frmCHONSV));
                if (frm != null)
                    frm.Activate();
                else
                {
                    frmCHONSV f = new frmCHONSV();
                    f.ShowDialog();
                    this.txtMAND.Text = Program.maNDDaChon;
                    txtTaiKhoan.Text = Program.maNDDaChon.Trim();
                }
            }


        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
