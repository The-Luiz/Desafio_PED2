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

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public partial class Form1 : Form
    {
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
            Carrito NuevoCarrito = new Carrito();
            NuevoCarrito.ShowDialog();
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
        //Hay que ver donde ponerlo xd
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
            DGV.Columns.Add("Codigo", "ID");
            DGV.Columns.Add("Nombre", "Producto");
            DGV.Columns.Add("Categoria", "Categoria");
            DGV.Columns.Add("Stock", "Stock");
        }
        private void Pruebas()
        {
            ColumnasDGV();
            List<ClaseProducto> list = new List<ClaseProducto>();
            list.Add(new ClaseProducto("Teclado", 50, 2, 1, "Electrodomestico"));
            list.Add(new ClaseProducto("Silla", 100,10, 2, "Mueble"));
            list.Add(new ClaseProducto("Cepillos", 3, 0, 9, "Cosas"));
            list.Add(new ClaseProducto("Lirbos", 5, 7, 3, "Cosas"));
            foreach (ClaseProducto p in list)
            {
                int rowIndex = DGV.Rows.Add();
                DataGridViewRow row = DGV.Rows[rowIndex];
                row.Cells[0].Value = p.Codigo;
                row.Cells[1].Value = p.Nombre;
                row.Cells[2].Value = p.Categoria;
                row.Cells[3].Value = p.Stock;
            }
        }
    }
}
