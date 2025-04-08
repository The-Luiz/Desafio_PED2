using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public class ArbolAVL
    {
        private NodoArbol raiz;

        public bool Insertar(int codigo)
        {
            bool agregado = false;
            raiz = Insertar(raiz, codigo, ref agregado);
            return agregado;
        }

        private NodoArbol Insertar(NodoArbol nodo, int codigo, ref bool agregado)
        {
            if (nodo == null)
            {
                agregado = true;
                return new NodoArbol(codigo);
            }

            if (codigo < nodo.Codigo)
                nodo.Izquierda = Insertar(nodo.Izquierda, codigo, ref agregado);
            else if (codigo > nodo.Codigo)
                nodo.Derecha = Insertar(nodo.Derecha, codigo, ref agregado);
            else
            {
                agregado = false; // código duplicado
                return nodo;
            }

            // Actualizar altura y balancear
            nodo.Altura = 1 + Math.Max(Altura(nodo.Izquierda), Altura(nodo.Derecha));
            int balance = Balance(nodo);

            // Rotaciones
            if (balance > 1 && codigo < nodo.Izquierda.Codigo)
                return RotarDerecha(nodo);
            if (balance < -1 && codigo > nodo.Derecha.Codigo)
                return RotarIzquierda(nodo);
            if (balance > 1 && codigo > nodo.Izquierda.Codigo)
            {
                nodo.Izquierda = RotarIzquierda(nodo.Izquierda);
                return RotarDerecha(nodo);
            }
            if (balance < -1 && codigo < nodo.Derecha.Codigo)
            {
                nodo.Derecha = RotarDerecha(nodo.Derecha);
                return RotarIzquierda(nodo);
            }

            return nodo;
        }

        private int Altura(NodoArbol nodo) => nodo?.Altura ?? 0;

        private int Balance(NodoArbol nodo) => nodo == null ? 0 : Altura(nodo.Izquierda) - Altura(nodo.Derecha);

        private NodoArbol RotarDerecha(NodoArbol y)
        {
            NodoArbol x = y.Izquierda;
            NodoArbol T2 = x.Derecha;

            x.Derecha = y;
            y.Izquierda = T2;

            y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;
            x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;

            return x;
        }

        private NodoArbol RotarIzquierda(NodoArbol x)
        {
            NodoArbol y = x.Derecha;
            NodoArbol T2 = y.Izquierda;

            y.Izquierda = x;
            x.Derecha = T2;

            x.Altura = Math.Max(Altura(x.Izquierda), Altura(x.Derecha)) + 1;
            y.Altura = Math.Max(Altura(y.Izquierda), Altura(y.Derecha)) + 1;

            return y;
        }

        public bool Contiene(int codigo)
        {
            return Buscar(raiz, codigo);
        }

        private bool Buscar(NodoArbol nodo, int codigo)
        {
            if (nodo == null) return false;
            if (codigo == nodo.Codigo) return true;
            if (codigo < nodo.Codigo) return Buscar(nodo.Izquierda, codigo);
            return Buscar(nodo.Derecha, codigo);
        }
    }
}

