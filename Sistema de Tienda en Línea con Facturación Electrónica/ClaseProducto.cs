﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    internal class ClaseProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Codigo { get; set; }
        public string Categoria { get; set; }

        public ClaseProducto(string NuevoNombre, int NuevoPrecio, int NuevoStock,int NuevoCodigo, string NuevaCategoria) 
        {
           Nombre = NuevoNombre;
           Precio = NuevoPrecio;
           Stock = NuevoStock;
           Codigo = NuevoCodigo;
           Categoria = NuevaCategoria;
        }
    }
}
