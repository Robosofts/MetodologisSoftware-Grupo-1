namespace WindowsFormsAppProyectoMDS1
{
    partial class frmProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.txtBTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.RichTextBox();
            this.atras = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBCodigo.Location = new System.Drawing.Point(205, 46);
            this.txtBCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBCodigo.MaxLength = 4;
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(132, 15);
            this.txtBCodigo.TabIndex = 2;
            // 
            // txtBTipo
            // 
            this.txtBTipo.Location = new System.Drawing.Point(205, 73);
            this.txtBTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBTipo.Name = "txtBTipo";
            this.txtBTipo.Size = new System.Drawing.Size(132, 22);
            this.txtBTipo.TabIndex = 3;
            this.txtBTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBTipo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo";
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(205, 179);
            this.txtBPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBPrecio.MaxLength = 4;
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtBPrecio.TabIndex = 7;
            this.txtBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPrecio_KeyPress);
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(205, 107);
            this.txtBDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBDescripcion.MaxLength = 200;
            this.txtBDescripcion.Multiline = true;
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(271, 64);
            this.txtBDescripcion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agregar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 298);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Visualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(508, 29);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(735, 380);
            this.txtP.TabIndex = 18;
            this.txtP.Text = "";
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(1003, 434);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(100, 34);
            this.atras.TabIndex = 19;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(1143, 434);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 34);
            this.salir.TabIndex = 20;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1279, 484);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBPrecio);
            this.Controls.Add(this.txtBDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBTipo);
            this.Controls.Add(this.txtBCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.Text = "Ingreso de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.TextBox txtBTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox txtP;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button salir;
    }
}

