﻿using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista
{
    public partial class RegistroVenta : Form
    {
        VentaLOG _ventaLOG;
        ProductoLOG _productoLOG;
        DataTable detalleVenta;

        public RegistroVenta()
        {
            InitializeComponent();
            CargarProductos();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("ProductoId", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            productobindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        private void btnCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btnCodigo.Text))
            {
                _productoLOG = new ProductoLOG();
                int codigo = int.Parse(btnCodigo.Text);
                var producto = _productoLOG.ObtenerProductoPorId(codigo);

                if (producto != null && producto.Estado == true)
                {
                    btnNombre.Text = producto.Nombre;
                }
                else
                {
                    btnNombre.Text = "";
                }


            }
            else
            {
                CargarProductos();
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _productoLOG = new ProductoLOG();

                int ProductoId = int.Parse(btnCodigo.Text);
                int Cantidad = int.Parse(btnCantidad.Text);

                var producto = (Producto)productobindingSource.Current;

                if (producto != null)
                {
                    detalleVenta.Rows.Add(ProductoId, producto.Nombre, producto.PrecioUnitario,
                        Cantidad, (Cantidad * producto.PrecioUnitario));

                    dgvDetalleVenta.DataSource = detalleVenta;

                    CalcularMontoTotal();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Tienda | Registro Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }

            //foreach (DataRow row in detalleVenta.Rows)
            //{
            //    montoTotal += (int)row["SubTotal"];
            //}

            btnTotal.Text = montoTotal.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                _ventaLOG = new VentaLOG();

                Ventas ventas = new Ventas();

                ventas.Fecha = DateTime.Now;
                ventas.Total = decimal.Parse(btnTotal.Text);

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    var detalle = new DetalleVenta()
                    {
                        ProductoId = int.Parse(row.Cells["ProductoId"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString())
                    };

                    ventas.Detalles.Add(detalle);
                }

                int resultado = _ventaLOG.GuardarVenta(ventas);

                if (resultado > 0)
                {
                    MessageBox.Show("Venta Guardada con Exito");
                }
                else
                {
                
                    MessageBox.Show("No se logro guardar la venta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message, "Tienda ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegistroVenta_Load(object sender, EventArgs e)
        {

        }


        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal Precio);
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (precioValido && cantidad > 0)
                    {
                        decimal SubTotal = Precio * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = SubTotal;

                        CalcularMontoTotal();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un precio valido");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



