using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class Heap
    {
        private List<ClaseProducto> heap = new List<ClaseProducto>();

        public int Count => heap.Count;

        public void Insertar(ClaseProducto producto)
        {
            heap.Add(producto);
            Subir(heap.Count - 1);
        }

        public ClaseProducto ExtraerMax()
        {
            if (heap.Count == 0) return null;

            var max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            Bajar(0);
            return max;
        }

        private void Subir(int i)
        {
            while (i > 0)
            {
                int padre = (i - 1) / 2;
                if (heap[i].Descuento <= heap[padre].Descuento) break;

                (heap[i], heap[padre]) = (heap[padre], heap[i]);
                i = padre;
            }
        }

        private void Bajar(int i)
        {
            int n = heap.Count;
            while (true)
            {
                int izq = 2 * i + 1;
                int der = 2 * i + 2;
                int mayor = i;

                if (izq < n && heap[izq].Descuento > heap[mayor].Descuento) mayor = izq;
                if (der < n && heap[der].Descuento > heap[mayor].Descuento) mayor = der;

                if (mayor == i) break;

                (heap[i], heap[mayor]) = (heap[mayor], heap[i]);
                i = mayor;
            }
        }

        public List<ClaseProducto> ObtenerTodos()
        {
            return new List<ClaseProducto>(heap);
        }
    }
}
