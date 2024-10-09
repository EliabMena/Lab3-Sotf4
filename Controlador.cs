using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Sotf4
{
    public class Controlador
    {
        private Tienda tienda = new Tienda(); 

        private DataGridView dgvCalculo; 

        
        public Controlador(DataGridView dgvCalculo)
        {
            this.dgvCalculo = dgvCalculo;

            InicializarGridView();
        }

        
        private void InicializarGridView()
        {
            dgvCalculo.Columns.Clear();

            dgvCalculo.Columns.Add("Importe", "Importe"); 
        }

        
        private void CargarVentasEnGridView(List<Venta> ventas)
        {
            dgvCalculo.Rows.Clear();

            foreach (var venta in ventas)
            {
                dgvCalculo.Rows.Add(venta.Importe); 

            }
        }

        

        public void ProcesarVentas(string datos)
        {
            tienda.Ventas.Clear(); 

            string[] valores = datos.Split(',');
            foreach (var valor in valores)
            {
                if (decimal.TryParse(valor.Trim(), out decimal importe)) 
                {
                    tienda.AgregarVenta(new Venta(importe)); 
                }
            }

            
            tienda.OrdenarVentas();

            CargarVentasEnGridView(tienda.Ventas); 
        }

        
        public void MostrarVentasEnRango()
        {
            
            var ventasEnRango = tienda.ObtenerVentasEnRango(50, 287);

            CargarVentasEnGridView(ventasEnRango);
        }
    }
}
