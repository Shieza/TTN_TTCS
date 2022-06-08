using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THICK
{
    public partial class frmDoiPass : Form
    {
        public frmDoiPass()
        {
            InitializeComponent();
        }

        private void frmDoiPass_Load(object sender, EventArgs e)
        {
            txtTK.Text = Program.userName;
        }

        private void btnDOIPASS_Click(object sender, EventArgs e)
        {

            if (txtOLDPASS.Text != Program.loginPwd)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            if (txtNEWPASS.Text != txtRESETPASS.Text)
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu giống với mật khẩu mới!");
                return;
            }    

            string DOI = Program.loginName;
            string PASS = Program.loginPwd;
            Program.loginName = "TSV";
            Program.loginPwd = "12345";

            if (Program.database_Connect() == false) {
                MessageBox.Show("Xảy ra lỗi đổi mật khẩu!",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string sql = 
                         "ALTER LOGIN " + DOI + " WITH PASSWORD=N'" + txtNEWPASS.Text + "'";
            
            if (Program.ExecSqlNonQuery(sql) == 0)
            {
                Program.loginName = DOI;
                Program.loginPwd = PASS;

                if (Program.database_Connect() == false)
                {
                    MessageBox.Show("Xảy ra lỗi đổi mật khẩu!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Đổi mật khẩu thành công!");
                Program.frm_Main.bbtDX_ItemClick(sender, null);
                this.Dispose();
            }
            else
            {
                Program.loginName = DOI;
                Program.loginPwd = PASS;

                if (Program.database_Connect() == false)
                {
                    MessageBox.Show("Xảy ra lỗi đổi mật khẩu!",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
