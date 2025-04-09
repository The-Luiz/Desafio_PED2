using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public partial class Form1 : Form
    {
        BindingList<ClaseProducto> productos = new BindingList<ClaseProducto>();
        private Lista_Carrito carrito = new Lista_Carrito();
        private ArbolAVL arbolCodigos = new ArbolAVL();


        public Form1()
        {
            InitializeComponent();
            panel1.Paint += Panel1_Paint;
            panel1.Resize += (s, e) => panel1.Invalidate();
            panel2.BackColor = ColorTranslator.FromHtml("#5047c3");
            Pruebas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DGV.MultiSelect = false;
            this.BackColor = ColorTranslator.FromHtml("#d7e1fd");
            AjustarDGV();
            CB_Filtro.Items.Add("Sin Filtro");
            CB_Filtro.Items.Add("Nombre");
            CB_Filtro.Items.Add("Precio");
            CB_Filtro.SelectedIndex = 0; // Selecciona la opción neutral por defecto


        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Definir colores del degradado
            Color color1 = ColorTranslator.FromHtml("#5d77e6");
            Color color2 = ColorTranslator.FromHtml("#2f2186");

            // Crear el degradado de arriba hacia abajo (Vertical)
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel1.ClientRectangle, color1, color2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Carrito ventanaCarrito = new Carrito(carrito);
            ventanaCarrito.ShowDialog(); // o Show()
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ignorar esto
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //Esto es para que se esconda las palabras del textbox
            if (txtBusqueda.Text == "Busca productos ;)")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.Black;
            }
        }
        private void AjustarDGV()
        {
            int height = DGV.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in DGV.Rows)
                height += dr.Height;

            DGV.Height = height;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.MaximumSize = new Size(500, 250);
        }

        private void ColumnasDGV()
        {
            DGV.Columns["Codigo"].DisplayIndex = 0;
            DGV.Columns["Nombre"].DisplayIndex = 1;
            DGV.Columns["Precio"].DisplayIndex = 2;
            DGV.Columns["Stock"].DisplayIndex = 3;
            DGV.Columns["Categoria"].DisplayIndex = 4;

        }
        public void Pruebas()
        {
            
            productos.Add(new ClaseProducto("Teclado", 50, 2, 1, "Electrodoméstico",0));
            productos.Add(new ClaseProducto("Silla", 100, 10, 2, "Mueble",20));
            productos.Add(new ClaseProducto("Cepillos", 3, 2, 3, "Cosas",0));
            productos.Add(new ClaseProducto("Libros", 5, 7, 4, "Cosas",0));

            //DGV.AutoGenerateColumns = true;
            DGV.DataSource = productos;
            DGV.Columns["CantidadEnCarrito"].Visible = false;
            DGV.Columns["Descuento"].Visible = false;
            ColumnasDGV();
            DGV.Columns["Precio"].DefaultCellStyle.Format = "C";

        }
        private void EditarProducto(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                FormEditar editarForm = new FormEditar();

                editarForm.CodigoE = DGV.CurrentRow.Cells["Codigo"].Value.ToString();
                editarForm.NombreE = DGV.CurrentRow.Cells["Nombre"].Value.ToString();
                editarForm.PrecioE = DGV.CurrentRow.Cells["Precio"].Value.ToString();
                editarForm.CategoriaE = DGV.CurrentRow.Cells["Categoria"].Value.ToString();
                editarForm.StockE = DGV.CurrentRow.Cells["Stock"].Value.ToString();


                editarForm.Fila = DGV.CurrentRow; // La fila seleccionada
                editarForm.ShowDialog();
            }
        }

        private void DGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.Button == MouseButtons.Right)
            {
                DGV.ClearSelection();
                DGV.Rows[e.RowIndex].Selected = true;
                ContextMenu m = new ContextMenu();

                MenuItem borrarItem = new MenuItem("Borrar",BorrarFila);
                MenuItem agregarcarrito = new MenuItem("Agregar al Carrito",AgregarCarrito);
                MenuItem editarItem = new MenuItem("Editar", (s, ev) => EditarProducto(s, ev));
                m.MenuItems.Add(borrarItem);
                m.MenuItems.Add(agregarcarrito);
                m.MenuItems.Add(editarItem);

                m.Show(DGV, new Point(e.X, e.Y));
            }
        }
        private void BorrarFila(object sender, EventArgs e)
        {
            if (DGV.CurrentRow?.DataBoundItem is ClaseProducto ProductoSeleccionado)
            {
                productos.Remove(ProductoSeleccionado);
                MessageBox.Show("Producto borrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AgregarCarrito (object sender, EventArgs e)
        {
            if (DGV.CurrentRow?.DataBoundItem is ClaseProducto ProductoSeleccionado)
            {
                carrito.AgregarProducto(ProductoSeleccionado);
                MessageBox.Show("Producto agregado al carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EditarF(object sender, EventArgs e)
        {
            if (DGV.CurrentRow?.DataBoundItem is ClaseProducto ProductoSeleccionado)
            {
               
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormAgregarProductos formAgregar = new FormAgregarProductos(productos, arbolCodigos);
            formAgregar.Show();
            
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var productosCriticos = productos.Where(p => p.Stock < 5).ToList();

            // Crear una nueva instancia del formulario
            FormStockCritico formStockCritico = new FormStockCritico(productosCriticos);

            // Mostrar el formulario con los productos críticos
            formStockCritico.Show();

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBusqueda.Text.Trim().ToLower();
            IEnumerable<ClaseProducto> resultados = null;
            if (string.IsNullOrEmpty(texto))
            {
               // Si el textbox está vacío, mostrar la lista original
                DGV.DataSource = null;
                DGV.DataSource = productos;
                DGV.Columns["CantidadEnCarrito"].Visible = false;
                DGV.Columns["Descuento"].Visible = false;
                ColumnasDGV();
                DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
                return;
            }
            if (RD_ID.Checked && int.TryParse(txtBusqueda.Text, out int codigo))
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    row.Selected = false;
                    if ((int)row.Cells["Codigo"].Value == codigo)
                    {
                        row.Selected = true;
                        DGV.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            if (RD_Nombre.Checked )
            {
                // Buscar por nombre
                resultados = productos.Where(p => p.Nombre.ToLower().Contains(texto));
                DGV.Columns["CantidadEnCarrito"].Visible = false;
                DGV.Columns["Descuento"].Visible = false;
                ColumnasDGV();
                DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
            }
            if (RD_Categoria.Checked)
            {
                resultados = productos.Where(p=> p.Categoria.ToLower().Contains(texto));
                DGV.Columns["CantidadEnCarrito"].Visible = false;
                DGV.Columns["Descuento"].Visible = false;
                ColumnasDGV();
                DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
            }
            if (resultados != null)
            {
                DGV.DataSource = null;
                DGV.DataSource = resultados.ToList();
                DGV.Columns["CantidadEnCarrito"].Visible = false;
                DGV.Columns["Descuento"].Visible = false;
                ColumnasDGV();
                DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
            }
        }

        private void CB_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Filtro.SelectedItem == null) return;

            string seleccion = CB_Filtro.SelectedItem.ToString();

            if (seleccion == "Sin Filtro")
            {
                DGV.DataSource = null;
                DGV.DataSource = productos; // ← Mostrar la lista original
                DGV.Columns["CantidadEnCarrito"].Visible = false;
                DGV.Columns["Descuento"].Visible = false;
                ColumnasDGV();
                DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
                return;
            }

            ArbolABB arbol;

            if (seleccion == "Nombre")
                arbol = new ArbolABB(p => p.Nombre);
            else if (seleccion == "Precio")
                arbol = new ArbolABB(p => p.Precio);
            else
                return;

            foreach (var producto in productos)
                arbol.Insertar(producto);

            var listaOrdenada = arbol.ObtenerProductosOrdenados();

            DGV.DataSource = null;
            DGV.DataSource = listaOrdenada;
            DGV.Columns["CantidadEnCarrito"].Visible = false;
            DGV.Columns["Descuento"].Visible = false;
            ColumnasDGV();
            DGV.Columns["Precio"].DefaultCellStyle.Format = "C";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormOfertas formOfertas = new FormOfertas(productos); // importante: esta misma instancia
            formOfertas.Show();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
