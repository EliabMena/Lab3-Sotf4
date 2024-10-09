using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problema1
{
    internal class ClassProblema1
    {
        public double metodoRetirar(double saldoActual,ref double dinero)
        {
            string dineroTxt = Microsoft.VisualBasic.Interaction.InputBox("Por favor, ingrese el monto que desea retirar:");
            double monto = 0;
            if (double.TryParse(dineroTxt, out monto) && monto <= saldoActual)
            {
                dinero = monto;
                saldoActual -= monto; 
                return saldoActual; 
            }
            else
            {
                MessageBox.Show("El monto ingresado excede su saldo disponible. Por favor, ingrese un monto menor.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return saldoActual;
            }
        }
        public double metodoDepositar(double saldoActual, ref double dinero)
        {
            string dineroTxt = Microsoft.VisualBasic.Interaction.InputBox("Por favor, ingrese el monto que desea depositar:");
            double monto = 0;

            if (double.TryParse(dineroTxt, out monto))
            {
                dinero = monto;
                saldoActual += monto;
                return saldoActual;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return saldoActual;
            }
        }

    }
}
