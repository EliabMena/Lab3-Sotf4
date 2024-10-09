using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problema1
{
    public partial class frmProblem1 : Form
    {
        public frmProblem1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClassProblema1 objProblema1 = new ClassProblema1();
            double saldoActual = double.Parse(txtSaldo.Text);
            double dinero = 0;

            if (rdbRetiros.Checked)
            {
                saldoActual = objProblema1.metodoRetirar(saldoActual, ref dinero);
                txtSaldo.Text = saldoActual.ToString();
                if (dinero > 0) 
                { 
                    lstRetiro.Items.Add(dinero); 
                }
            }
            else if (rdbDeposito.Checked)
            {
                saldoActual =  objProblema1.metodoDepositar(saldoActual, ref dinero);
                txtSaldo.Text = saldoActual.ToString();
                if (dinero > 0)
                {
                    lstDeposito.Items.Add(dinero);
                }
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            txtSaldo.Text = txtMonto.Text;
            btnCuenta.Enabled = false;
            txtCliente.Enabled = false;
            txtMonto.Enabled = false;
        }
    }
}
