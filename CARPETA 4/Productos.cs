using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsAppProyectoMDS1
{
    public class Productos
    {
        
        public void Agregar(TextBox txtBCodigo, TextBox txtBTipo,  TextBox txtBDescripcion, TextBox txtBPrecio)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\User\Documents\Sariah\WindowsFormsAppProyectoMDS1\Productos.txt", true);
            try
            {

                escribir.WriteLine("Codigo: " + txtBCodigo.Text + "\t" + "Tipo: " + txtBTipo.Text + "\t" + "Descripcion: " + txtBDescripcion.Text + "\t" + "Precio: $" + txtBPrecio.Text + "\t");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            escribir.Close();
        }

        
        //funciones para 
        public static string TipoP()
        {
            return "Cualquier Tipo";
        }

        
        public static string CodigoP(string texto)
        {
            if( texto.Length == 4)
            {
                return texto;
            }else
            {
                return "Codigo Invalido";
            }
            
        }

        public static string PrecioP(string texto)
        {
            if (texto.Length <= 4)
            {
                return texto;
            }
            else
            {
                return "Ingrese un valor valido";
            }

        }

        public static string DescripcionP(string texto)
        {

        return "Cualquier Descripcion";

        }

    }
}
