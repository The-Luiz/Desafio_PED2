using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class ClaseProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public override string ToString()
        {
            return $"{Codigo}: {Nombre} (${Precio}) - Stock: {Stock} - Cat: {Categoria}";
        }
        public int CantidadEnCarrito { get; set; } = 1;
        public double Descuento { get; set; }

        public ClaseProducto(string NuevoNombre, double NuevoPrecio, int NuevoStock, int NuevoCodigo, string NuevaCategoria, double descuento =0) 
        {
            Codigo = NuevoCodigo;
            Nombre = NuevoNombre;
           Precio = NuevoPrecio;
           Stock = NuevoStock;
           Categoria = NuevaCategoria;
            Descuento = descuento;
            
        }
    }
}
