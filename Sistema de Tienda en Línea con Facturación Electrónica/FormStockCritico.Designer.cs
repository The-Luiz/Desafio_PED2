namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    partial class FormStockCritico
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
            this.dgvStockCritico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCritico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockCritico
            // 
            this.dgvStockCritico.AllowUserToAddRows = false;
            this.dgvStockCritico.AllowUserToDeleteRows = false;
            this.dgvStockCritico.AllowUserToResizeColumns = false;
            this.dgvStockCritico.AllowUserToResizeRows = false;
            this.dgvStockCritico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockCritico.GridColor = System.Drawing.Color.Lime;
            this.dgvStockCritico.Location = new System.Drawing.Point(96, 123);
            this.dgvStockCritico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStockCritico.Name = "dgvStockCritico";
            this.dgvStockCritico.ReadOnly = true;
            this.dgvStockCritico.RowHeadersVisible = false;
            this.dgvStockCritico.RowHeadersWidth = 62;
            this.dgvStockCritico.RowTemplate.Height = 28;
            this.dgvStockCritico.Size = new System.Drawing.Size(538, 161);
            this.dgvStockCritico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Critico";
            // 
            // FormStockCritico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(723, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStockCritico);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStockCritico";
            this.Text = "FormStockCritico";
            this.Load += new System.EventHandler(this.FormStockCritico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockCritico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockCritico;
        private System.Windows.Forms.Label label1;
    }
}