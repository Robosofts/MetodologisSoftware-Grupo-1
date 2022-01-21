
namespace WindowsFormsAppProyectoMDS1
{
    partial class MenuProductos
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
            this.productos = new System.Windows.Forms.Button();
            this.proveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productos
            // 
            this.productos.Location = new System.Drawing.Point(93, 130);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(286, 61);
            this.productos.TabIndex = 1;
            this.productos.Text = "PRODUCTOS";
            this.productos.UseVisualStyleBackColor = true;
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // proveedores
            // 
            this.proveedores.Location = new System.Drawing.Point(93, 44);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(286, 61);
            this.proveedores.TabIndex = 2;
            this.proveedores.Text = "PROVEEDORES";
            this.proveedores.UseVisualStyleBackColor = true;
            this.proveedores.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // MenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 264);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.productos);
            this.Name = "MenuProductos";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button productos;
        private System.Windows.Forms.Button proveedores;
    }
}