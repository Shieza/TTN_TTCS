using System;
using System.Collections;
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
    public partial class frmQLCH : Form
    {
        private int indexTHEM = 0;

        public frmQLCH()
        {
            InitializeComponent();
        }



        private void frmQLCH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DATA.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.DATA.MONHOC);
            // TODO: This line of code loads data into the 'DATA.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Fill(this.DATA.GIANGVIEN);

            DATA.EnforceConstraints = false;

            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.DATA.CAUHOI);

            this.cT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BAITHITableAdapter.Fill(this.DATA.CT_BAITHI);


            this.btnTHOAT.Enabled = true;
            txtIDCH.Enabled = btnHUY.Enabled = false;

            gridVCH.OptionsBehavior.Editable = false;

        }


        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            indexTHEM = bdsCH.Position;

            this.gcCH.Enabled = false;
            this.pcCTCH.Enabled = true;

            bdsCH.AddNew();

            this.txtIDCH.Enabled = true;
            this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnTHOAT.Enabled = this.btnSUA.Enabled = false;
            this.btnGHI.Enabled = this.btnHUY.Enabled = true;
        }

        private void cAUHOIBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }


        private bool checktt()
        {
            //test IDCH
            if (txtIDCH.Value == 0 || txtIDCH.Value < 1)
            {
                MessageBox.Show("ID CÂU HỎI không thể bỏ trống hoặc nhỏ hơn 1 tiết!", "Thông báo", MessageBoxButtons.OK);
                txtIDCH.Focus();
                return false;
            }


            //TEST LOAI
            if (txtTRINHDO.Text != "Đại Học" && txtTRINHDO.Text != "Cao Đẳng")
            {
                MessageBox.Show("Trình độ chỉ nhận Đại Học và Cao Đẳng", "Thông báo", MessageBoxButtons.OK);
                txtTRINHDO.Focus();
                return false;
            }
            if (txtTRINHDO.Text == "")
            {
                MessageBox.Show("Không bỏ trống loại trình độ", "Thông báo", MessageBoxButtons.OK);
                txtTRINHDO.Focus();
                return false;
            }


            //TEST LOAI
            if (txtLOAI.Text != "Trắc Nghiệm" && txtLOAI.Text != "Ðiền khuyết" && txtLOAI.Text != "Yes/No")
            {
                MessageBox.Show("Loại chỉ nhận trắc nghiệm, điền khuyết và yes/no", "Thông báo", MessageBoxButtons.OK);
                txtLOAI.Focus();
                return false;
            }
            if (txtLOAI.Text == "")
            {
                MessageBox.Show("Không bỏ trống loại câu hỏi", "Thông báo", MessageBoxButtons.OK);
                txtLOAI.Focus();
                return false;
            }

            //test nội dung
            if (txtND.Text == "")
            {
                MessageBox.Show("Không bỏ trống nội dung câu hỏi", "Thông báo", MessageBoxButtons.OK);
                txtND.Focus();
                return false;
            }

            //test ĐÁP ÁN 
            if (txtDAPAN.Text == "")
            {
                MessageBox.Show("Không bỏ trống trình độ", "Thông báo", MessageBoxButtons.OK);
                txtDAPAN.Focus();
                return false;
            }
            if (txtDAPAN.Text != "A" && txtDAPAN.Text != "B" && txtDAPAN.Text != "C" && txtDAPAN.Text != "D")
            {
                MessageBox.Show("DAP AN chỉ nhận A,B,C,D", "Thông báo", MessageBoxButtons.OK);
                txtDAPAN.Focus();
                return false;
            }

            //test CHUONG
            if (txtCHUONG.Value == 0 || txtCHUONG.Value < 1)
            {
                MessageBox.Show("CHƯƠNG không thể bỏ trống hoặc nhỏ hơn 1 tiết!", "Thông báo", MessageBoxButtons.OK);
                txtCHUONG.Focus();
                return false;
            }

            //test A
            if (txtA.Text == "")
            {
                MessageBox.Show("Không bỏ trống nội dung A", "Thông báo", MessageBoxButtons.OK);
                txtA.Focus();
                return false;
            }

            //test B
            if (txtB.Text == "")
            {
                MessageBox.Show("Không bỏ trống nội dung B", "Thông báo", MessageBoxButtons.OK);
                txtB.Focus();
                return false;
            }


            //test C
            if (txtC.Text == "")
            {
                MessageBox.Show("Không bỏ trống nội dung C", "Thông báo", MessageBoxButtons.OK);
                txtC.Focus();
                return false;
            }

            //test D
            if (txtD.Text == "")
            {
                MessageBox.Show("Không bỏ trống nội dung D", "Thông báo", MessageBoxButtons.OK);
                txtD.Focus();
                return false;
            }
            return true;
        }
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checktt())
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                    bdsCH.EndEdit();
                    this.cAUHOITableAdapter.Connection = Program.conn;
                    this.cAUHOITableAdapter.Update(this.DATA.CAUHOI);

                    gcCH.Enabled = true;

                    MessageBox.Show("Ghi thành công", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnTHEM.Enabled = btnXOA.Enabled = btnSUA.Enabled = btnHUY.Enabled = btnTHOAT.Enabled = true;
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

            if (bdsCTBT.Count > 0)
            {
                MessageBox.Show("Không thể xóa câu hỏi này vì đã có trong chi tiết lịch thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    bdsCH.RemoveCurrent();

                    this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cAUHOITableAdapter.Update(this.DATA.CAUHOI);


                    MessageBox.Show("Xóa thành công! ", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi. Hãy thử lại\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cAUHOITableAdapter.Fill(this.DATA.CAUHOI);
                    return;
                }
            }
            if (bdsCH.Count == 0) btnXOA.Enabled = false;
        }

        private void btnHUY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTHEM.Enabled = btnTHOAT.Enabled = btnXOA.Enabled = true;
            gcCH.Enabled = true;
            txtIDCH.Enabled = btnHUY.Enabled = false;

            bdsCH.CancelEdit();
            this.cAUHOITableAdapter.Fill(this.DATA.CAUHOI);
            bdsCH.Position = indexTHEM;
        }
    }
}
