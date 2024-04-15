namespace CapaVista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenúMantenimientoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistroVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenúMantenimientoProducto});
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.productoToolStripMenuItem.Text = "Productos";
            // 
            // MenúMantenimientoProducto
            // 
            this.MenúMantenimientoProducto.Name = "MenúMantenimientoProducto";
            this.MenúMantenimientoProducto.Size = new System.Drawing.Size(260, 26);
            this.MenúMantenimientoProducto.Text = "Mantenimiento Productos";
            this.MenúMantenimientoProducto.Click += new System.EventHandler(this.MenúMantenimientoProducto_Click);
            // 
            // MenuRegistroVentas
            // 
            this.MenuRegistroVentas.Name = "MenuRegistroVentas";
            this.MenuRegistroVentas.Size = new System.Drawing.Size(224, 26);
            this.MenuRegistroVentas.Text = "Registro de Ventas";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistroVentas});
            this.ventasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenúMantenimientoProducto;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistroVentas;
    }
}

