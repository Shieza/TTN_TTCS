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
    public partial class frmQLSV : Form
    {

        private int indexTHEM = 0;

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = -1;
            age = DateTime.Now.Year - dateOfBirth.Year;
            return age;
        }


        public frmQLSV()
        {
            InitializeComponent();
        }


        private void frmQLSV_Load(object sender, EventArgs e)
        {

            DATA.EnforceConstraints = false;

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DATA.SINHVIEN);

            this.kETQUATHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kETQUATHITableAdapter.Fill(this.DATA.KETQUATHI);


            this.btnTHOAT.Enabled = true;
            txtMASV.Enabled = false;
            btnSUA.Enabled = true;

            gridVSV.OptionsBehavior.Editable = false;
        }




        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indexTHEM = bdsSV.Position;

            this.gcSV.Enabled = false;
            this.pcCTSV.Enabled = true;

            bdsSV.AddNew();

            dateNS.EditValue = "01/01/2001";

            this.txtMASV.Enabled = true;
            this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnTHOAT.Enabled = this.btnSUA.Enabled = false;
            this.btnGHI.Enabled = this.btnPHUCHOI.Enabled = true;
        }

        private bool checktt()
        {
            if (txtMASV.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã sinh viên !", "Thông báo", MessageBoxButtons.OK);
                txtMASV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMASV.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Mã sinh viên chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMASV.Focus();
                return false;
            }


            //test họ
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


            //test tên
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên !", "Thông báo", MessageBoxButtons.OK);
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


            //TEST NGAY SINH
            if (CalculateAge(dateNS.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dateNS.Focus();
                return false;
            }


            //TEST DIA CHI
            if (txtDC.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtDC.Focus();
                return false;
            }
            if (Regex.IsMatch(txtDC.Text, @"^[a-zA-Z0-9,áàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ  ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDC.Focus();
                return false;
            }
            if (txtDC.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 ký tự", "Thông báo", MessageBoxButtons.OK);
                txtDC.Focus();
                return false;
            }

            if (txtMALOP.Text == "")
            {
                MessageBox.Show("Không bỏ trống MALOP", "Thông báo", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }
            if (txtMALOP.Text != "D18CQAT01-N" && txtMALOP.Text != "D19CQMR01-N" && txtMALOP.Text != "D19CQCN01-N")
            {
                MessageBox.Show("MALOP chỉ nhận lớp đã được tạo ra", "Thông báo", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }


            if (txtMASV.Text.Trim() != gridVSV.GetFocusedDataRow()[0].ToString().Trim())
            {
                int check_MASV = Program.alreadyExist_check("MASV", "'" + txtMASV.Text.Trim() + "'");
                if (check_MASV == -1) return false;
                else if (check_MASV == 1)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại rồi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMASV.Focus();
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

                    bdsSV.EndEdit();
                    this.sINHVIENTableAdapter.Connection = Program.conn;
                    this.sINHVIENTableAdapter.Update(this.DATA.SINHVIEN);

                    gcSV.Enabled = true;

                    MessageBox.Show("Ghi thành công", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTHEM.Enabled = btnXOA.Enabled = btnSUA.Enabled = btnPHUCHOI.Enabled = btnTHOAT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên!\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String MASV = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();

            if (MASV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsKQT.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên này vì đã có trong kết quả thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {


                    bdsSV.RemoveCurrent();

                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DATA.SINHVIEN);


                    MessageBox.Show("Xóa thành công! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string strLenh = "EXEC sp_Xoa_Login_SV '" + MASV.Trim() + "'";



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.sINHVIENTableAdapter.Fill(this.DATA.SINHVIEN);
                    return;
                }
            }
            if (bdsSV.Count == 0) btnXOA.Enabled = false;
        }



        private void sINHVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTHEM.Enabled = btnTHOAT.Enabled = btnXOA.Enabled = true;
            gcSV.Enabled = true;
            txtMASV.Enabled = btnHUY.Enabled = false;

            bdsSV.CancelEdit();
            this.sINHVIENTableAdapter.Fill(this.DATA.SINHVIEN);
            bdsSV.Position = indexTHEM;
        }
    }
}
