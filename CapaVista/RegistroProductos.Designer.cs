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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrecioUnitario = new System.Windows.Forms.TextBox();
            this.btnDecripción = new System.Windows.Forms.TextBox();
            this.btnNombreProducto = new System.Windows.Forms.TextBox();
            this.btnExistencias = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Por Unidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // btnPrecioUnitario
            // 
            this.btnPrecioUnitario.Location = new System.Drawing.Point(279, 292);
            this.btnPrecioUnitario.Name = "btnPrecioUnitario";
            this.btnPrecioUnitario.Size = new System.Drawing.Size(131, 30);
            this.btnPrecioUnitario.TabIndex = 8;
            // 
            // btnDecripción
            // 
            this.btnDecripción.Location = new System.Drawing.Point(279, 109);
            this.btnDecripción.Multiline = true;
            this.btnDecripción.Name = "btnDecripción";
            this.btnDecripción.Size = new System.Drawing.Size(501, 149);
            this.btnDecripción.TabIndex = 9;
            // 
            // btnNombreProducto
            // 
            this.btnNombreProducto.Location = new System.Drawing.Point(279, 56);
            this.btnNombreProducto.Name = "btnNombreProducto";
            this.btnNombreProducto.Size = new System.Drawing.Size(412, 30);
            this.btnNombreProducto.TabIndex = 10;
            // 
            // btnExistencias
            // 
            this.btnExistencias.Location = new System.Drawing.Point(279, 385);
            this.btnExistencias.Name = "btnExistencias";
            this.btnExistencias.Size = new System.Drawing.Size(131, 30);
            this.btnExistencias.TabIndex = 12;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(279, 488);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(87, 27);
            this.chkEstado.TabIndex = 13;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(567, 590);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(326, 590);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 34);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 636);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistroProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Registro de Productos";
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}