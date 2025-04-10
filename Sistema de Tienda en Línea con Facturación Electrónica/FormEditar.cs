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
            if (txtDescuentoE.Text  =="")
            {
                MessageBox.Show("El descuento no puede estar en blanco:\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (Fila != null)
            {
                Fila.Cells["Codigo"].Value = txtCodigoE.Text;
                Fila.Cells["Nombre"].Value = txtNombreE.Text;
                Fila.Cells["Precio"].Value = txtPrecioE.Text;
                Fila.Cells["Categoria"].Value = txtCategoriaE.Text;
                Fila.Cells["Stock"].Value = txtStockE.Text;
                Fila.Cells["Descuento"].Value = txtDescuentoE.Text; // Esto se te olvido
                MessageBox.Show("Producto Editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormEditar_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#d7e1fd");
        }


        private void txtPrecioE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCategoriaE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuentoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
