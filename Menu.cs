using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sotf4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void problema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalcularOrden frmCalcularOrden = new FrmCalcularOrden();
            frmCalcularOrden.MdiParent = this;
            frmCalcularOrden.WindowState = FormWindowState.Maximized;
            frmCalcularOrden.Show();
        }

        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaNum obj = new FrmListaNum();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }
    }
}
