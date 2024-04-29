using CapaEntidades;
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
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("Subtotal", typeof(decimal));
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
                _productoLOG= new ProductoLOG();
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

                int codigo = int.Parse(btnCodigo.Text);
                int cantidad = int.Parse(btnCantidad.Text);

                var producto = (Producto)productobindingSource.Current;

                if (producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.PrecioUnitario,
                        cantidad, (cantidad * producto.PrecioUnitario));

                    dgvDetalleVenta.DataSource = detalleVenta;

                    decimal montoTotal = 0;

                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                    {
                        montoTotal += (decimal)row.Cells["SubTotal"].Value;
                    }

                    foreach (DataRow row in dgvDetalleVenta.Rows)
                    {
                        montoTotal += (int)row["SubTotal"];
                    }

                    btnTotal.Text = montoTotal.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "UNAB|Chalatenango",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

