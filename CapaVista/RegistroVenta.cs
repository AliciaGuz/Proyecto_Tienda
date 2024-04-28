using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
