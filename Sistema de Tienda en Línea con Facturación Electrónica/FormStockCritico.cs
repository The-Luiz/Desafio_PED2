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
    public partial class FormStockCritico : Form
    {
        private List<ClaseProducto> productosCriticos;
        public FormStockCritico()
        {
            InitializeComponent();
        }

        private void FormStockCritico_Load(object sender, EventArgs e)
        {

        }

        public FormStockCritico(List<ClaseProducto> productos)
        {
            InitializeComponent();
            productosCriticos = productos;
            MostrarStockCritico();
        }

        private void MostrarStockCritico()
        {
            // Mostrar los productos en el DataGridView
            dgvStockCritico.DataSource = productosCriticos;

            // Personalizar columnas si es necesario
            dgvStockCritico.Columns["Precio"].HeaderText = "Precio";
            dgvStockCritico.Columns["Categoria"].HeaderText = "Categoría";
            dgvStockCritico.Columns["Stock"].HeaderText = "Stock Actual";
            dgvStockCritico.Columns["CantidadEnCarrito"].Visible = false;
            dgvStockCritico.Columns["Descuento"].Visible = false;
            dgvStockCritico.Columns["Precio"].DefaultCellStyle.Format = "C";
        }
    }
}
