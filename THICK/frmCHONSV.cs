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
    public partial class frmCHONSV : Form
    {
        public frmCHONSV()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void frmCHONSV_Load(object sender, EventArgs e)
        {
            this.sINHVIENTableAdapter.Connection = Program.conn;
            this.sINHVIENTableAdapter.Fill(this.DATA.SINHVIEN);

        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            Program.maNDDaChon = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
            this.Dispose();
        }
    }
}
