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
    public partial class frmCHONGV : Form
    {
        public frmCHONGV()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void frmCHONGV_Load(object sender, EventArgs e)
        {
            this.gIANGVIENTableAdapter.Connection = Program.conn;
            this.gIANGVIENTableAdapter.Fill(this.DATA.GIANGVIEN);

        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            Program.maNDDaChon = ((DataRowView)bdsGV[bdsGV.Position])["MAGV"].ToString();
            this.Dispose();
        }
    }
}
