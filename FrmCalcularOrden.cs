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
    public partial class FrmCalcularOrden : Form

    {
        private Controlador controlador;
        public FrmCalcularOrden()
        {
            InitializeComponent();

            controlador = new Controlador(dgvCalculo);

        }

        private void txtDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDatos.Text)) 
            {
                controlador.ProcesarVentas(txtDatos.Text); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los datos de ventas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            controlador.MostrarVentasEnRango();
        }


    }
}