namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    partial class FormEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoE = new System.Windows.Forms.TextBox();
            this.txtPrecioE = new System.Windows.Forms.TextBox();
            this.txtCategoriaE = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.txtStockE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescuentoE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoE
            // 
            this.txtCodigoE.Location = new System.Drawing.Point(288, 66);
            this.txtCodigoE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoE.Multiline = true;
            this.txtCodigoE.Name = "txtCodigoE";
            this.txtCodigoE.Size = new System.Drawing.Size(318, 46);
            this.txtCodigoE.TabIndex = 6;
            this.txtCodigoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoE_KeyPress);
            // 
            // txtPrecioE
            // 
            this.txtPrecioE.Location = new System.Drawing.Point(288, 256);
            this.txtPrecioE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioE.Multiline = true;
            this.txtPrecioE.Name = "txtPrecioE";
            this.txtPrecioE.Size = new System.Drawing.Size(318, 46);
            this.txtPrecioE.TabIndex = 7;
            this.txtPrecioE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioE_KeyPress_1);
            // 
            // txtCategoriaE
            // 
            this.txtCategoriaE.Location = new System.Drawing.Point(288, 341);
            this.txtCategoriaE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoriaE.Multiline = true;
            this.txtCategoriaE.Name = "txtCategoriaE";
            this.txtCategoriaE.Size = new System.Drawing.Size(318, 46);
            this.txtCategoriaE.TabIndex = 8;
            this.txtCategoriaE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaE_KeyPress);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(288, 168);
            this.txtNombreE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreE.Multiline = true;
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(318, 46);
            this.txtNombreE.TabIndex = 9;
            this.txtNombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreE_KeyPress);
            // 
            // txtStockE
            // 
            this.txtStockE.Location = new System.Drawing.Point(288, 435);
            this.txtStockE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStockE.Multiline = true;
            this.txtStockE.Name = "txtStockE";
            this.txtStockE.Size = new System.Drawing.Size(318, 46);
            this.txtStockE.TabIndex = 10;
            this.txtStockE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoría";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stock";
            // 
            // txtDescuentoE
            // 
            this.txtDescuentoE.Location = new System.Drawing.Point(288, 510);
            this.txtDescuentoE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescuentoE.Multiline = true;
            this.txtDescuentoE.Name = "txtDescuentoE";
            this.txtDescuentoE.Size = new System.Drawing.Size(318, 46);
            this.txtDescuentoE.TabIndex = 16;
            this.txtDescuentoE.TextChanged += new System.EventHandler(this.txtDescuentoE_TextChanged);
            this.txtDescuentoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentoE_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descuento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(708, 284);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 59);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 592);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescuentoE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.txtCategoriaE);
            this.Controls.Add(this.txtPrecioE);
            this.Controls.Add(this.txtCodigoE);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoE;
        private System.Windows.Forms.TextBox txtPrecioE;
        private System.Windows.Forms.TextBox txtCategoriaE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.TextBox txtStockE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescuentoE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
    }
}