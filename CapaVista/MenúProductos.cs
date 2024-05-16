using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaVista
{
    public partial class MenúProductos : Form
    {
        ProductoLOG _ProductoLOG;
        public MenúProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            RegistroProductos objRegistroProducto = new RegistroProductos();
            objRegistroProducto.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            RegistroProductos objRegistroProducto = new RegistroProductos();
            objRegistroProducto.ShowDialog();
            CargarProductos();

        }


        private void CargarProductos()
        {
            _ProductoLOG = new ProductoLOG();

            if (rbtnActivos.Checked)
            {
                dgvProductos.DataSource = _ProductoLOG.ObtenerProductos();
            }
            else if (rbtnInactivos.Checked)
            {
                dgvProductos.DataSource = _ProductoLOG.ObtenerProductos(true);
            }


        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString());

                    if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroProductos objRegistroProducto = new RegistroProductos(id);
                        objRegistroProducto.ShowDialog();

                        CargarProductos();
                    }
                    else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        // Preguntar al usuario si está seguro de eliminar el producto
                        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación",
                                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.Yes)
                        {
                            int resultadoEliminacion = _ProductoLOG.EliminarProducto(id);

                            if (resultadoEliminacion > 0)
                            {
                                MessageBox.Show("Producto eliminado exitosamente!", "Tienda | Registro Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarProductos();
                            }
                            else
                            {
                                MessageBox.Show("No se logró eliminar el producto", "Tienda | Registro Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

       

        private void rbtnInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void rbtnActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}



