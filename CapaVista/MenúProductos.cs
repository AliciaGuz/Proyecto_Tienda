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
            _ProductoLOG = new ProductoLOG();

            dgvProductos.DataSource = _ProductoLOG.ObtenerProductos();
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

        }

        private void MenúProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
