using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppProyectoMDS1
{
    public partial class frmProductos : Form
    {
        private Productos A = new Productos();
        public frmProductos()
        {
            InitializeComponent();
        }

        //validacion de las cajas te texto para ingreso eclusivo de letras o numeros

        private void txtBTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }


        private void txtBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A.Agregar(txtBCodigo, txtBTipo, txtBDescripcion, txtBPrecio);
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\User\Documents\Sariah\WindowsFormsAppProyectoMDS1\Productos.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    txtP.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            MenuProductos frm = new MenuProductos();
            frm.Show();
            Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
   
