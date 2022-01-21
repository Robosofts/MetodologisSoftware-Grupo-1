namespace WindowsFormsAppProyectoMDS1
{
    partial class frmproveedores
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
            this.txtBnombre = new System.Windows.Forms.TextBox();
            this.txtBRUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBDireccion = new System.Windows.Forms.TextBox();
            this.txtBNnTe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBProducto = new System.Windows.Forms.TextBox();
            this.visualizar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa";
            // 
            // txtBnombre
            // 
            this.txtBnombre.Location = new System.Drawing.Point(124, 46);
            this.txtBnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBnombre.Name = "txtBnombre";
            this.txtBnombre.Size = new System.Drawing.Size(216, 22);
            this.txtBnombre.TabIndex = 2;
            this.txtBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBnombre_KeyPress);
            // 
            // txtBRUC
            // 
            this.txtBRUC.Location = new System.Drawing.Point(124, 78);
            this.txtBRUC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBRUC.MaxLength = 13;
            this.txtBRUC.Name = "txtBRUC";
            this.txtBRUC.Size = new System.Drawing.Size(216, 22);
            this.txtBRUC.TabIndex = 3;
            this.txtBRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBRUC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Num. Telf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "RUC";
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.Location = new System.Drawing.Point(124, 142);
            this.txtBDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(216, 22);
            this.txtBDireccion.TabIndex = 7;
            this.txtBDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDireccion_KeyPress);
            // 
            // txtBNnTe
            // 
            this.txtBNnTe.Location = new System.Drawing.Point(124, 110);
            this.txtBNnTe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBNnTe.MaxLength = 10;
            this.txtBNnTe.Name = "txtBNnTe";
            this.txtBNnTe.Size = new System.Drawing.Size(216, 22);
            this.txtBNnTe.TabIndex = 6;
            this.txtBNnTe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNnTe_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cuidad";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(178, 229);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(100, 28);
            this.Agregar.TabIndex = 11;
            this.Agregar.Text = "Agregar ";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Producto ";
            // 
            // txtBProducto
            // 
            this.txtBProducto.Location = new System.Drawing.Point(124, 172);
            this.txtBProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBProducto.Name = "txtBProducto";
            this.txtBProducto.Size = new System.Drawing.Size(216, 22);
            this.txtBProducto.TabIndex = 10;
            this.txtBProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBProducto_KeyPress);
            // 
            // visualizar
            // 
            this.visualizar.Location = new System.Drawing.Point(178, 283);
            this.visualizar.Name = "visualizar";
            this.visualizar.Size = new System.Drawing.Size(100, 28);
            this.visualizar.TabIndex = 12;
            this.visualizar.Text = "Visualizar";
            this.visualizar.UseVisualStyleBackColor = true;
            this.visualizar.Click += new System.EventHandler(this.visualizar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(178, 333);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(100, 30);
            this.modificar.TabIndex = 13;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(933, 446);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(100, 34);
            this.atras.TabIndex = 15;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(1056, 446);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 34);
            this.salir.TabIndex = 16;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(408, 41);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(939, 380);
            this.txtP.TabIndex = 17;
            this.txtP.Text = "";
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1376, 505);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.txtBProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBDireccion);
            this.Controls.Add(this.txtBNnTe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBRUC);
            this.Controls.Add(this.txtBnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmproveedores";
            this.Text = "PROVEEDORES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBnombre;
        private System.Windows.Forms.TextBox txtBRUC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBDireccion;
        private System.Windows.Forms.TextBox txtBNnTe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBProducto;
        private System.Windows.Forms.Button visualizar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.RichTextBox txtP;
    }
}

