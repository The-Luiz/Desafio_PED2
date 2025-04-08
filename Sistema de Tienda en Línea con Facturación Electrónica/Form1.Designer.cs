namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RD_ID = new System.Windows.Forms.RadioButton();
            this.RD_Categoria = new System.Windows.Forms.RadioButton();
            this.RD_Nombre = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(490, 142);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(460, 189);
            this.DGV.TabIndex = 0;
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tienda UDB ;)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 108);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.RD_ID);
            this.panel2.Controls.Add(this.RD_Categoria);
            this.panel2.Controls.Add(this.RD_Nombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-2, 164);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 222);
            this.panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(28, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Busca productos ;)";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // RD_ID
            // 
            this.RD_ID.AutoSize = true;
            this.RD_ID.BackColor = System.Drawing.Color.Transparent;
            this.RD_ID.ForeColor = System.Drawing.SystemColors.Control;
            this.RD_ID.Location = new System.Drawing.Point(41, 120);
            this.RD_ID.Margin = new System.Windows.Forms.Padding(4);
            this.RD_ID.Name = "RD_ID";
            this.RD_ID.Size = new System.Drawing.Size(98, 20);
            this.RD_ID.TabIndex = 3;
            this.RD_ID.Text = "ID Producto";
            this.RD_ID.UseVisualStyleBackColor = false;
            // 
            // RD_Categoria
            // 
            this.RD_Categoria.AutoSize = true;
            this.RD_Categoria.BackColor = System.Drawing.Color.Transparent;
            this.RD_Categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.RD_Categoria.Location = new System.Drawing.Point(41, 93);
            this.RD_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.RD_Categoria.Name = "RD_Categoria";
            this.RD_Categoria.Size = new System.Drawing.Size(87, 20);
            this.RD_Categoria.TabIndex = 2;
            this.RD_Categoria.Text = "Categoria";
            this.RD_Categoria.UseVisualStyleBackColor = false;
            // 
            // RD_Nombre
            // 
            this.RD_Nombre.AutoSize = true;
            this.RD_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.RD_Nombre.Checked = true;
            this.RD_Nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.RD_Nombre.Location = new System.Drawing.Point(41, 66);
            this.RD_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.RD_Nombre.Name = "RD_Nombre";
            this.RD_Nombre.Size = new System.Drawing.Size(155, 20);
            this.RD_Nombre.TabIndex = 1;
            this.RD_Nombre.TabStop = true;
            this.RD_Nombre.Text = "Nombre del producto";
            this.RD_Nombre.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar productos por";
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(490, 358);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(189, 60);
            this.btnAgregarProductos.TabIndex = 5;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(731, 358);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(189, 60);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Stock Critico";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 530);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RD_ID;
        private System.Windows.Forms.RadioButton RD_Categoria;
        private System.Windows.Forms.RadioButton RD_Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnStock;
    }
}

