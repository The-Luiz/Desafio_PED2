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
    public partial class FormAgregarProductos : Form
    {
        private BindingList<ClaseProducto> productos;

        public FormAgregarProductos(BindingList<ClaseProducto> productos)
        {
            InitializeComponent();
            this.productos = productos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void FormAgregarProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            // Convertir y validar campos si es necesario
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            int codigo = int.Parse(txtID.Text);
            string categoria = txtCategoria.Text;

            // Crear el producto y agregarlo a la lista
            var nuevoProducto = new ClaseProducto(nombre, precio, stock, codigo, categoria);
            productos.Add(nuevoProducto);

            MessageBox.Show("Producto agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario luego de agregar
        }
    }
}
