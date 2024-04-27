namespace CapaVista
{
    partial class MenúProductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenúProductos));
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(663, 79);
            this.groupBoxFiltro.TabIndex = 1;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtros Por Producto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.Descripcion,
            this.PrecioUnitario,
            this.Stock,
            this.Estado});
            this.dgvProductos.Location = new System.Drawing.Point(12, 83);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(680, 327);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Green;
            this.btnNuevoProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoProducto.Location = new System.Drawing.Point(66, 433);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(108, 31);
            this.btnNuevoProducto.TabIndex = 3;
            this.btnNuevoProducto.Text = "Agregar\r\n";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(495, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar\r\n";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción ";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            this.Descripcion.Width = 250;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Existencias";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 110;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // MenúProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBoxFiltro);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenúProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Mantenimiento Productos";
            this.Load += new System.EventHandler(this.MenúProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}