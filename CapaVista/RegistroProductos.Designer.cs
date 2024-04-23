namespace CapaVista
{
    partial class RegistroProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrecioUnitario = new System.Windows.Forms.TextBox();
            this.bindingSourceProducto = new System.Windows.Forms.BindingSource(this.components);
            this.btnDecripción = new System.Windows.Forms.TextBox();
            this.btnNombreProducto = new System.Windows.Forms.TextBox();
            this.btnExistencias = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Por Unidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // btnPrecioUnitario
            // 
            this.btnPrecioUnitario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProducto, "PrecioUnitario", true));
            this.btnPrecioUnitario.Location = new System.Drawing.Point(213, 231);
            this.btnPrecioUnitario.Name = "btnPrecioUnitario";
            this.btnPrecioUnitario.Size = new System.Drawing.Size(131, 35);
            this.btnPrecioUnitario.TabIndex = 8;
            // 
            // bindingSourceProducto
            // 
            this.bindingSourceProducto.DataSource = typeof(CapaEntidades.Producto);
            // 
            // btnDecripción
            // 
            this.btnDecripción.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProducto, "Descripcion", true));
            this.btnDecripción.Location = new System.Drawing.Point(213, 66);
            this.btnDecripción.Multiline = true;
            this.btnDecripción.Name = "btnDecripción";
            this.btnDecripción.Size = new System.Drawing.Size(501, 149);
            this.btnDecripción.TabIndex = 9;
            // 
            // btnNombreProducto
            // 
            this.btnNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProducto, "Nombre", true));
            this.btnNombreProducto.Location = new System.Drawing.Point(213, 22);
            this.btnNombreProducto.Name = "btnNombreProducto";
            this.btnNombreProducto.Size = new System.Drawing.Size(412, 35);
            this.btnNombreProducto.TabIndex = 10;
            this.btnNombreProducto.TextChanged += new System.EventHandler(this.btnNombreProducto_TextChanged);
            // 
            // btnExistencias
            // 
            this.btnExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceProducto, "Stock", true));
            this.btnExistencias.Location = new System.Drawing.Point(213, 291);
            this.btnExistencias.Name = "btnExistencias";
            this.btnExistencias.Size = new System.Drawing.Size(131, 35);
            this.btnExistencias.TabIndex = 12;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceProducto, "Estado", true));
            this.chkEstado.Location = new System.Drawing.Point(213, 349);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(104, 30);
            this.chkEstado.TabIndex = 13;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(259, 417);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 38);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(461, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 473);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnExistencias);
            this.Controls.Add(this.btnNombreProducto);
            this.Controls.Add(this.btnDecripción);
            this.Controls.Add(this.btnPrecioUnitario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Registro de Productos";
            this.Load += new System.EventHandler(this.RegistroProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox btnPrecioUnitario;
        private System.Windows.Forms.TextBox btnDecripción;
        private System.Windows.Forms.TextBox btnNombreProducto;
        private System.Windows.Forms.TextBox btnExistencias;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bindingSourceProducto;
    }
}