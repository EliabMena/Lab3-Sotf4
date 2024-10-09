using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sotf4
{
    public class Tienda
    {
        public List<Venta> Ventas { get; set; } = new List<Venta>();

        
        public void AgregarVenta(Venta venta)
        {
            Ventas.Add(venta);
        }

        
        public void OrdenarVentas()
        {
            Ventas = Ventas.OrderBy(v => v.Importe).ToList();
        }

        
        public List<Venta> ObtenerVentasEnRango(decimal minimo, decimal maximo)
        {

            return Ventas.Where(v => v.Importe >= minimo && v.Importe <= maximo).ToList();

        }
    }
}
