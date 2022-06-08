using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THICK
{
    public partial class frmQLGV : Form
    {
        private int indexTHEM = 0;
        public frmQLGV()
        {
            InitializeComponent();
        }


        private void frmQLGV_Load(object sender, EventArgs e)
        {

            DATA.EnforceConstraints = false;

            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.DATA.GIANGVIEN);

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.DATA.CAUHOI);

            this.xEPLICHTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.xEPLICHTHITableAdapter.Fill(this.DATA.XEPLICHTHI);

            this.btnTHOAT.Enabled = true;
            txtMAGV.Enabled = btnHUY.Enabled = false;
            txtMAKHOA.Enabled = true;

            gridVGV.OptionsBehavior.Editable = false;
        }


        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indexTHEM = bdsGV.Position;

            this.gcGV.Enabled = false;
            this.pcChiTiet.Enabled = true;

            bdsGV.AddNew();


            this.txtMAGV.Enabled = true;
            this.btnTHEM.Enabled = this.btnXOA.Enabled  = this.btnTHOAT.Enabled = false;
            this.btnGHI.Enabled = this.btnHUY.Enabled = true;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MAGV = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();

            if (MAGV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsXLT.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã có trong xếp lịch thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCH.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã tạo câu hỏi thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {


                    bdsGV.RemoveCurrent();

                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Update(this.DATA.GIANGVIEN);

                    MessageBox.Show("Xóa thành công! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string strLenh = "EXEC sp_Xoa_Login_GV '" + MAGV.Trim() + "'";


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.gIANGVIENTableAdapter.Fill(this.DATA.GIANGVIEN);
                    return;
                }
            }
            if (bdsGV.Count == 0) btnXOA.Enabled = false;
        }

        private bool checktt()
        {
            //Test MAGV
            if (txtMAGV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtMAGV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMAGV.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Mã giảng viên chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMAGV.Focus();
                txtMAGV.Focus();
                return false;
            }
            if (txtMAGV.Text.Length > 10)
            {
                MessageBox.Show("Họ không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }


            //Test Họ
            if (txtHO.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (Regex.IsMatch(txtHO.Text, @"^[A-Za-záàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ ]+$") == false)
            {
                MessageBox.Show("Họ chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (txtHO.Text.Length > 20)
            {
                MessageBox.Show("Họ không thể lớn hơn 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }


            //Test Tên
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTEN.Text, @"^[a-zA-Z,áàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ  ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (txtTEN.Text.Length > 50)
            {
                MessageBox.Show("Tên không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }


            //Test PHAI
            if (txtPHAI.Text == "")
            {
                MessageBox.Show("Không bỏ trống PHAI", "Thông báo", MessageBoxButtons.OK);
                txtPHAI.Focus();
                return false;
            }

            if (txtPHAI.Text != "Nam" && txtPHAI.Text != "Nữ")
            {
                MessageBox.Show("PHAI chỉ nhận Nam hoặc Nữ", "Thông báo", MessageBoxButtons.OK);
                txtPHAI.Focus();
                return false;
            }


            //Test HOCVI
            if (txtHOCVI.Text == "")
            {
                MessageBox.Show("Không bỏ trống học vị", "Thông báo", MessageBoxButtons.OK);
                txtHOCVI.Focus();
                return false;
            }
            if (txtHOCVI.Text != "Tiến Sĩ" && txtHOCVI.Text != "Thạc Sĩ" && txtHOCVI.Text != "Kĩ Sư")
            {
                MessageBox.Show("HOCVI chỉ nhận Tiến Sĩ, Thạc Sĩ và Kĩ Sư", "Thông báo", MessageBoxButtons.OK);
                txtHOCVI.Focus();
                return false;
            }



            //TEST MAKHOA
            if (txtMAKHOA.Text == "")
            {
                MessageBox.Show("Không bỏ trống MAKHOA", "Thông báo", MessageBoxButtons.OK);
                txtMAKHOA.Focus();
                return false;
            }
            if (txtMAKHOA.Text != "DT2" && txtMAKHOA.Text != "CN2" && txtMAKHOA.Text != "QT2")
            {
                MessageBox.Show("MAKHOA chỉ nhận DT2, CN2 và QT2", "Thông báo", MessageBoxButtons.OK);
                txtMAKHOA.Focus();
                return false;
            }


            if (txtMAGV.Text.Trim() != gridVGV.GetFocusedDataRow()[0].ToString().Trim())
            {
                int check_MAGV = Program.alreadyExist_check("MAGV", "'" + txtMAGV.Text.Trim() + "'");
                if (check_MAGV == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại rồi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMAGV.Focus();
                    return false;
                }
            }
                    return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(!checktt())
            {
                return;
            }    

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    bdsGV.EndEdit();
                    this.gIANGVIENTableAdapter.Connection = Program.conn;
                    this.gIANGVIENTableAdapter.Update(this.DATA.GIANGVIEN);

                    gcGV.Enabled = true;

                    MessageBox.Show("Ghi thành công", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSUA.Enabled = btnTHEM.Enabled = btnXOA.Enabled = btnHUY.Enabled = btnTHOAT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi giảng viên!\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTHEM.Enabled = btnTHOAT.Enabled = btnXOA.Enabled = true;
            gcGV.Enabled = true;
            txtMAGV.Enabled = btnHUY.Enabled = false;

            bdsGV.CancelEdit();
            this.gIANGVIENTableAdapter.Fill(this.DATA.GIANGVIEN);
            bdsGV.Position = indexTHEM;
        }
    }
}
