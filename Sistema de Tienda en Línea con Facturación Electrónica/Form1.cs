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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
