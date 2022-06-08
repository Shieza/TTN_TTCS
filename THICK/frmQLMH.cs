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
    public partial class frmQLMH : Form
    {

        private int indexTHEM = 0;

        public frmQLMH()
        {
            InitializeComponent();
        }


        private void frmQLMH_Load(object sender, EventArgs e)
        {
            
            DATA.EnforceConstraints = false;

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.DATA.MONHOC);

            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.DATA.CAUHOI);

            this.xEPLICHTHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.xEPLICHTHITableAdapter.Fill(this.DATA.XEPLICHTHI);


            this.btnTHOAT.Enabled = true;
            txtMAMON.Enabled = btnHUY.Enabled = false;

            gridVMH.OptionsBehavior.Editable = false;


        }



        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indexTHEM = bdsMH.Position;

            this.gcMH.Enabled = false;
            this.pcCTMH.Enabled = true;

            bdsMH.AddNew();

            this.txtMAMON.Enabled = true;
            this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnTHOAT.Enabled = false;
            this.btnGHI.Enabled = this.btnHUY.Enabled = true;
        }


        private bool checktt()
        {
            if (txtMAMON.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã sinh viên !", "Thông báo", MessageBoxButtons.OK);
                txtMAMON.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMAMON.Text, @"^[A-Za-z0-9]+$") == false)
            {
                MessageBox.Show("Mã môn học chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMAMON.Focus();
                return false;
            }


            //test tên môn
            if (txtTENMON.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên môn học", "Thông báo", MessageBoxButtons.OK);
                txtTENMON.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTENMON.Text, @"^[A-Za-záàạảãâấầậẩẫăắằặẳẵÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴéèẹẻẽêếềệểễÉÈẸẺẼÊẾỀỆỂỄóòọỏõôốồộổỗơớờợởỡÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠúùụủũưứừựửữÚÙỤỦŨƯỨỪỰỬỮíìịỉĩÍÌỊỈĨđĐýỳỵỷỹÝỲỴỶỸ ]+$") == false)
            {
                MessageBox.Show("Tên môn chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTENMON.Focus();
                return false;
            }
            if (txtTENMON.Text.Length > 50)
            {
                MessageBox.Show("Tên môn không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTENMON.Focus();
                return false;
            }



            //test stlt
            if (txtSTLT.Value == 0 || txtSTLT.Value < 1)
            {
                MessageBox.Show("Số tiết lý thuyết không thể bỏ trống hoặc nhỏ hơn 1 tiết!", "Thông báo", MessageBoxButtons.OK);
                txtSTLT.Focus();
                return false;
            }

            //test stth
            if (txtSTTH.Value < 0)
            {
                MessageBox.Show("Số tiết thực hành không thể nhỏ hơn 0 tiết!", "Thông báo", MessageBoxButtons.OK);
                txtSTTH.Focus();
                return false;
            }

            if (txtMAMON.Text.Trim() != gridVMH.GetFocusedDataRow()[0].ToString().Trim())
            {
                int check_MAMON = Program.alreadyExist_check("MAMON", "'" + txtMAMON.Text.Trim() + "'");
                if (check_MAMON == -1) return false;
                else if (check_MAMON == 1)
                {
                    MessageBox.Show("Mã môn đã tồn tại rồi!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMAMON.Focus();
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

                    bdsMH.EndEdit();
                    this.mONHOCTableAdapter.Connection = Program.conn;
                    this.mONHOCTableAdapter.Update(this.DATA.MONHOC);

                    gcMH.Enabled = true;

                    MessageBox.Show("Ghi thành công", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTHEM.Enabled = btnXOA.Enabled = btnSUA.Enabled = btnHUY.Enabled = btnTHOAT.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi môn học!\n\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsXLT.Count > 0)
            {
                MessageBox.Show("Không thể xóa mon học này vì đã có trong xếp lịch thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCH.Count > 0)
            {
                MessageBox.Show("Không thể xóa mon hoc này vì đã tạo câu hỏi thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    bdsMH.RemoveCurrent();

                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.DATA.MONHOC);


                    MessageBox.Show("Xóa thành công! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. Hãy thử lại\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.mONHOCTableAdapter.Fill(this.DATA.MONHOC);
                    return;
                }
            }
            if (bdsMH.Count == 0) btnXOA.Enabled = false;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTHEM.Enabled = btnTHOAT.Enabled = btnXOA.Enabled = true;
            gcMH.Enabled = true;
            txtMAMON.Enabled = btnHUY.Enabled = false;

            bdsMH.CancelEdit();
            this.mONHOCTableAdapter.Fill(this.DATA.MONHOC);
            bdsMH.Position = indexTHEM;
        }
    }
}
