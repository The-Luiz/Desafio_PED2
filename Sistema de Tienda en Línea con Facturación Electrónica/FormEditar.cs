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
    public partial class FormEditar : Form
    {
        public FormEditar()
        {
            InitializeComponent();
        }
        public DataGridViewRow Fila { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Fila != null)
            {
                Fila.Cells["Codigo"].Value = txtCodigoE.Text;
                Fila.Cells["Nombre"].Value = txtNombreE.Text;
                Fila.Cells["Precio"].Value = txtPrecioE.Text;
                Fila.Cells["Categoria"].Value = txtCategoriaE.Text;
                Fila.Cells["Stock"].Value = txtStockE.Text;

                this.Close(); // Cierra la ventana de edición
            }
        }
        public string CodigoE
        {
            get { return txtCodigoE.Text; }
            set { txtCodigoE.Text = value; }
        }

        public string NombreE
        {
            get { return txtNombreE.Text; }
            set { txtNombreE.Text = value; }
        }

        public string PrecioE
        {
            get { return txtPrecioE.Text; }
            set { txtPrecioE.Text = value; }
        }

        public string CategoriaE
        {
            get { return txtCategoriaE.Text; }
            set { txtCategoriaE.Text = value; }
        }

        public string StockE
        {
            get { return txtStockE.Text; }
            set { txtStockE.Text = value; }
        }

        public string DescuentoE
        {
            get { return txtDescuentoE.Text; }
            set { txtDescuentoE.Text = value; }
        }

    }
}
