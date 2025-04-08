using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class ArbolABB
    {
        private NodoABB raiz;
        private Func<ClaseProducto, IComparable> criterio;

        public ArbolABB(Func<ClaseProducto, IComparable> criterioOrden)
        {
            criterio = criterioOrden;
        }

        public void Insertar(ClaseProducto producto)
        {
            raiz = InsertarRec(raiz, producto);
        }

        private NodoABB InsertarRec(NodoABB nodo, ClaseProducto producto)
        {
            if (nodo == null) return new NodoABB(producto);

            if (criterio(producto).CompareTo(criterio(nodo.Producto)) < 0)
                nodo.Izquierda = InsertarRec(nodo.Izquierda, producto);
            else
                nodo.Derecha = InsertarRec(nodo.Derecha, producto);

            return nodo;
        }

        public List<ClaseProducto> ObtenerProductosOrdenados()
        {
            List<ClaseProducto> lista = new List<ClaseProducto>();
            InOrden(raiz, lista);
            return lista;
        }

        private void InOrden(NodoABB nodo, List<ClaseProducto> lista)
        {
            if (nodo == null) return;

            InOrden(nodo.Izquierda, lista);
            lista.Add(nodo.Producto);
            InOrden(nodo.Derecha, lista);
        }
    }
    public class NodoABB
    {
        public ClaseProducto Producto;
        public NodoABB Izquierda, Derecha;

        public NodoABB(ClaseProducto producto)
        {
            Producto = producto;
        }
    }
}
