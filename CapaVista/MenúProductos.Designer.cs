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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenúProductos));
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
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
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(38, 97);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(932, 430);
            this.dgvProductos.TabIndex = 2;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(38, 549);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(108, 31);
            this.btnNuevoProducto.TabIndex = 3;
            this.btnNuevoProducto.Text = "Agregar\r\n";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(862, 549);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar\r\n";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // MenúProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBoxFiltro);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenúProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Mantenimiento Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnCancelar;
    }
}