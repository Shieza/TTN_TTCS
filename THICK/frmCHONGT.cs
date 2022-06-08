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
    public partial class frmCHONGT : Form
    {
        public frmCHONGT()
        {
            InitializeComponent();
        }

        private void pGVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void frmCHONGT_Load(object sender, EventArgs e)
        {
            this.pGVTableAdapter.Connection = Program.conn;
            this.pGVTableAdapter.Fill(this.DATA.PGV);
            

        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            Program.maNDDaChon = ((DataRowView)bdsGT[bdsGT.Position])["MAGIAMTHI"].ToString();
            this.Dispose();
        }
    }
}
