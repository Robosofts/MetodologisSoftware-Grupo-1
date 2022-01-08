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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\moises\Desktop\Met.Des.Soft\proyecto\Datos_del_proyecto.txt",true);
            try
            {
                escribir.WriteLine("Nombre" + "\t" + "RUC" + "\t" + "Numero de Telefono" + "\t" + "Direccion" + "\t" + "Producto");
                escribir.WriteLine(txtBnombre.Text + "\t" + txtBRUC.Text + "\t" + txtBNnTe.Text + "\t" + txtBDireccion.Text + "\t" + txtBProducto.Text);
            }
            catch
            {
                MessageBox.Show("ERROR"); 
            }
            escribir.Close();
        }
    }
}
