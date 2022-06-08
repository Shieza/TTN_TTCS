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
    public partial class frmBANGDIEM : Form
    {
        public frmBANGDIEM()
        {
            InitializeComponent();
        }

        private void kETQUATHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKQT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DATA);

        }

        private void frmBANGDIEM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DATA.CT_BAITHI' table. You can move, or remove it, as needed.
            this.cT_BAITHITableAdapter.Fill(this.DATA.CT_BAITHI);
            // TODO: This line of code loads data into the 'dATA.KETQUATHI' table. You can move, or remove it, as needed.
            this.kETQUATHITableAdapter.Fill(this.DATA.KETQUATHI);

        }
    }
}
