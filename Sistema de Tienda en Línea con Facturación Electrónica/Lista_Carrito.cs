using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class Lista_Carrito
    {
        //Aqui se guardara los elementos incluidos en el carrito
        public List<ClaseProducto> Productos {get;private set;}
        public Lista_Carrito()
        {
            Productos = new List<ClaseProducto>();
        }

        // Método opcional para agregar productos
        public void AgregarProducto(ClaseProducto producto)
        {
            Productos.Add(producto);
        }
        public void EliminarProducto(ClaseProducto producto)
        {
            Productos.Remove(producto);
        }
    }
}
