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
        private ArbolAVL arbolCodigos;

        public FormAgregarProductos(BindingList<ClaseProducto> productos, ArbolAVL arbolCodigos)
        {
            InitializeComponent();
            this.productos = productos;
            this.arbolCodigos = arbolCodigos;
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
            int codigo = int.Parse(txtID.Text);
            

            // Validar con el árbol AVL
            if (!arbolCodigos.Insertar(codigo))
            {
                MessageBox.Show("Ya existe un producto con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Convertir y validar campos si es necesario
            int descuentooferta = int.Parse(txtDescuento.Text);
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            //int codigo = int.Parse(txtID.Text);
            string categoria = txtCategoria.Text;

            // Crear el producto y agregarlo a la lista
            var nuevoProducto = new ClaseProducto(nombre, precio, stock, codigo, categoria,descuentooferta);
            productos.Add(nuevoProducto);

            MessageBox.Show("Producto agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario luego de agregar
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
