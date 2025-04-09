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
    public partial class FormOfertas : Form
    {
        private Heap heapOfertas;
        // Cambia esto en FormOfertas:
        private BindingList<ClaseProducto> productos;

        public FormOfertas(BindingList<ClaseProducto> productos)
        {
            InitializeComponent();
            this.productos = productos;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormOfertas_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Producto", 120);
            listView1.Columns.Add("Precio", 70);
            listView1.Columns.Add("Descuento", 70);
            listView1.Columns.Add("Categoría", 120);
            heapOfertas = new Heap();

            foreach (var producto in productos)
            {
                if (producto.Descuento > 0)
                {
                    heapOfertas.Insertar(producto);
                }
            }
            MostrarOfertasEnListView();
        }
        private void MostrarOfertasEnListView()
        {
            listView1.Items.Clear();

            var ofertas = heapOfertas.ObtenerTodos();
            foreach (var producto in ofertas)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString("C2"));
                item.SubItems.Add($"{producto.Descuento}%");
                item.SubItems.Add(producto.Categoria);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
