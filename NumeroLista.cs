using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sotf4
{
    internal class NumeroLista
    {
        private List<int> numeros = new List<int>();

        public void asignar(DataGridView matriz)
        {
            for (int i = 0; i < matriz.Columns.Count; i++)
            {
                numeros.Add(Convert.ToInt32(matriz.Rows[0].Cells[i].Value));
            }
        }

        public List<int> eliminar(int n)
        {
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] == n)
                {
                    numeros.RemoveAt(i);
                    i--;
                }
            }
            return numeros;
        }
    }
}
