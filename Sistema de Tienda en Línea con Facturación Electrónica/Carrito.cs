﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Sistema_de_Tienda_en_Línea_con_Facturación_Electrónica
{
    public partial class Carrito : Form
    {
        private Lista_Carrito carrito;

        public Carrito(Lista_Carrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#d7e1fd");
            MostrarProductosEnListView();
            RefrescarListView();
            listView1.Columns.Add("Producto", 120);
            listView1.Columns.Add("Cantidad", 80);
            listView1.Columns.Add("Precio", 70);
            listView1.Columns.Add("Categoría", 120);
        }
        private void MostrarProductosEnListView()
        {
            listView1.Items.Clear();
            foreach (var producto in carrito.Productos)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add(producto.Categoria.ToString());
                listView1.Items.Add(item);
            }
        }
        private void RefrescarListView()
        {
            listView1.Items.Clear();
            //SubTotalLabel
            SubTotalPrecio.Text = $" {SubTotal():C}";
            //Impuestos
            Impuestos.Text = $" {ImpuestosTotal():C}";
            //Total final
            Total.Text = $" {TotalFinal():C}";
            foreach (var producto in carrito.Productos)
            {
                var item = new ListViewItem(producto.Nombre);
                item.SubItems.Add(producto.CantidadEnCarrito.ToString()); // ← Mostramos cantidad
                item.SubItems.Add(producto.Precio.ToString("C"));
                item.SubItems.Add(producto.Categoria);
                listView1.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var itemSeleccionado = listView1.SelectedItems[0];
                string nombreProducto = itemSeleccionado.Text;

                // Buscar el producto en la lista por el nombre
                var productoABorrar = carrito.Productos.FirstOrDefault(p => p.Nombre == nombreProducto);

                if (productoABorrar != null)
                {
                    carrito.EliminarProducto(productoABorrar);
                    MessageBox.Show("Producto eliminado del carrito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarListView();
                }
                else
                {
                    MessageBox.Show("No se encontró el producto en la lista del carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto del carrito para eliminarlo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private double SubTotal()
        {
            double total = 0;
            foreach (var producto in carrito.Productos)
            {
                total += producto.Precio * producto.CantidadEnCarrito;
            }
            return total;
        }
        private double ImpuestosTotal()
        {
            double impuestosTotal = 0;
            foreach (var producto in carrito.Productos)
            {
                impuestosTotal += (producto.Precio * producto.CantidadEnCarrito) * 0.13;
            }
            return impuestosTotal;
        }
        private double TotalFinal()
        {
            double totalFinal = 0;
            foreach (var producto in carrito.Productos)
            {
                totalFinal = SubTotal()+ ImpuestosTotal();
            }
            return totalFinal;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (carrito.Productos.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Filter = "Archivos JSON (*.json)|*.json";
            saveFileDialog1.Title = "Guardar factura";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var factura = new
                {
                    Fecha = DateTime.Now,
                    Productos = carrito.Productos.Select(p => new
                    {
                        p.Nombre,
                        p.Codigo,
                        p.Categoria,
                        p.CantidadEnCarrito,
                        PrecioUnitario = p.Precio,
                        Total = p.Precio * p.CantidadEnCarrito
                    }),
                    TotalFactura = carrito.Productos.Sum(p => p.Precio * p.CantidadEnCarrito)
                };

                string json = JsonConvert.SerializeObject(factura, Formatting.Indented);

                File.WriteAllText(saveFileDialog1.FileName, json);

                MessageBox.Show("Factura generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
