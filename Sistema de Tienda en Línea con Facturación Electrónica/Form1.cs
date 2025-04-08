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
            AjustarDGV();
            
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
            if (textBox1.Text == "Busca productos ;)")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
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
            
            productos.Add(new ClaseProducto("Teclado", 50, 2, 1, "Electrodoméstico"));
            productos.Add(new ClaseProducto("Silla", 100, 10, 2, "Mueble"));
            productos.Add(new ClaseProducto("Cepillos", 3, 0, 3, "Cosas"));
            productos.Add(new ClaseProducto("Libros", 5, 7, 4, "Cosas"));

            //DGV.AutoGenerateColumns = true;
            DGV.DataSource = productos;
            DGV.Columns["CantidadEnCarrito"].Visible = false;
            ColumnasDGV();
            DGV.Columns["Precio"].DefaultCellStyle.Format = "C";

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

                m.MenuItems.Add(borrarItem);
                m.MenuItems.Add(agregarcarrito);

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

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            FormAgregarProductos formAgregar = new FormAgregarProductos();
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
    }
}
