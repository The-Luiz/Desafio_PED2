using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class NodoArbol
    {
        public int Codigo;
        public NodoArbol Izquierda;
        public NodoArbol Derecha;
        public int Altura;

        public NodoArbol(int codigo)
        {
            Codigo = codigo;
            Altura = 1;
        }
    }
}
