﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenúMantenimientoProducto_Click(object sender, EventArgs e)
        {
        MenúProductos objMttProducto = new MenúProductos();
        objMttProducto.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuRegistroVentas_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistroVenta = new RegistroVenta();
            objRegistroVenta.ShowDialog();
        }
    }
}
