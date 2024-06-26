﻿
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
        int _id;

        public RegistroProductos(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda | Edición de Productos";
                btnGuardar.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                bindingSourceProducto.MoveLast();
                bindingSourceProducto.AddNew();
            }

        }

        private void CargarDatos(int id)
        {
            _productoLOG = new ProductoLOG();

            bindingSourceProducto.DataSource = _productoLOG.ObtenerProductoPorId(id);
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

                if (!chkEstado.Checked)
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

                int resultado;

                if (_id >= 0)
                {
                    Producto producto;

                    producto = (Producto)bindingSourceProducto.Current;

                    resultado = _productoLOG.ActualizarProducto(producto, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Usuario actualizado exitosamente!", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el usuario", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    bindingSourceProducto.EndEdit();

                    Producto producto;
                    producto = (Producto)bindingSourceProducto.Current;

                    resultado = _productoLOG.GuardarProducto(producto);

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


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un Error: " + ex.Message, "UNAB|Chalatenango",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }
    }
}



