﻿using System;
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
        public FormAgregarProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1  = new Form1();
            form1.Show();
        }
    }
}
