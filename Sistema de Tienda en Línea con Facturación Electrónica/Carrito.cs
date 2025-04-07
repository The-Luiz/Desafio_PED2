using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public partial class Carrito : Form
    {
        private Lista_Carrito carrito;

        public Carrito(Lista_Carrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            MostrarProductosEnListView();
            RefrescarListView();
            listView1.Columns.Add("Producto", 120);
            listView1.Columns.Add("Precio", 80);
            listView1.Columns.Add("Stock", 70);
            listView1.Columns.Add("Categoría", 120);
        }
        private void MostrarProductosEnListView()
        {
            listView1.Items.Clear();
            foreach (var producto in carrito.Productos)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add(producto.Categoria.ToString());
                listView1.Items.Add(item);
            }
        }
        private void RefrescarListView()
        {
            listView1.Items.Clear();

            foreach (var producto in carrito.Productos)
            {
                ListViewItem item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add(producto.Categoria.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var itemSeleccionado = listView1.SelectedItems[0];
                string nombreProducto = itemSeleccionado.Text;

                // Buscar el producto en la lista por el nombre
                var productoABorrar = carrito.Productos.FirstOrDefault(p => p.Nombre == nombreProducto);

                if (productoABorrar != null)
                {
                    carrito.EliminarProducto(productoABorrar);
                    MessageBox.Show("Producto eliminado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarListView();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto en la lista del carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto del carrito para eliminarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
