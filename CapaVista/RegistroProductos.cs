
using CapaEntidades;
using CapaLogica;
using System;
using System.CodeDom;
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
    public partial class RegistroProductos : Form
    {
        ProductoLOG _productoLOG;
        public RegistroProductos()
        {
            InitializeComponent();

            bindingSourceProducto.MoveLast();
            bindingSourceProducto.AddNew();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto()
        {
            try
            {
                _productoLOG = new ProductoLOG();
                //throw new Exception();

                if (string.IsNullOrEmpty(btnNombreProducto.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNombreProducto.Focus();
                    btnNombreProducto.BackColor = Color.LightYellow;
                    return;
                }
                if (string.IsNullOrEmpty(btnDecripción.Text))
                {
                    MessageBox.Show("Se requiere la descripción de el producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNombreProducto.Focus();
                    btnNombreProducto.BackColor = Color.LightYellow;
                    return;
                }
                if (string.IsNullOrEmpty(btnPrecioUnitario.Text) || Convert.ToDecimal(btnPrecioUnitario.Text) == 0)
                {
                    MessageBox.Show("Se requiere el precio de el producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnNombreProducto.Focus();
                    btnNombreProducto.BackColor = Color.LightYellow;
                    return;
                }

                if(!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("¿Está seguro que desea guardar el producto inactivo?", "Tienda | Registro Productos",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Productos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }

                Producto producto;
                producto = (Producto)bindingSourceProducto.Current;

                int resultado = _productoLOG.GuardarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario agregado exitosamente!", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro guardar el usuario", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception) 
            {
                MessageBox.Show("Ocurrio un Error", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
