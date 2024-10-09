using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sotf4
{
    public partial class FrmListaNum : Form
    {

        private List<int> numeros;

        public FrmListaNum()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            dgvDatos.RowCount = 1;
            dgvDatos.ColumnCount = Convert.ToInt32(txtN.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            NumeroLista objEliminar = new NumeroLista();
            objEliminar.asignar(dgvDatos);
            numeros = objEliminar.eliminar(Convert.ToInt32(txtEliminar.Text));

            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            dgvDatos.RowCount = 1;
            dgvDatos.ColumnCount = Convert.ToInt32(numeros.Count);


            int index = 0;

            foreach (int i in numeros)
            {
                    dgvDatos.Rows[0].Cells[index].Value = i;
                    index++;
            }
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
