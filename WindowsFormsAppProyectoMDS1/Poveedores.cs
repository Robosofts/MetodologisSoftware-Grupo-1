﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsAppProyectoMDS1
{
    public class Poveedores
    {
        
        public void Agregar(TextBox txtBnombre, TextBox txtBRUC, TextBox txtBNnTe, TextBox txtBDireccion, TextBox txtBProducto)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\moises\Desktop\Met.Des.Soft\proyecto\Datos_del_proyecto.txt", true);
            try
            {

                escribir.WriteLine("Nombre: " + nombreP() + "\t" + "RUC: " + txtBRUC.Text + "\t" + "Num.Tel: " + txtBNnTe.Text + "\t" + "Direccion: " + txtBDireccion.Text + "\t" + "Producto: " + txtBProducto.Text);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            escribir.Close();
        }

        
        //funciones para las pruebas 
        public static string nombreP(TextBox txtBnombre)
        {
            return "cualquier nombre";
        }

        
        public static string RucP(string texto)
        {
            if( texto.Length == 13)
            {
                return texto;
            }else
            {
                return "ruc invalido";
            }
            
        }

        public static string NumTelfP(string texto)
        {
            if (texto.Length == 10)
            {
                return texto;
            }
            else
            {
                return "el numero de telefono no existe";
            }

        }

        public static string DirP(string texto)
        {
            if ((texto == "loja") || (texto == "ibarra") || (texto == "ambato") || (texto == "otabalo")  || (texto == "quito"))
            {
                return texto;
            }
            else
            {
                return "ingrese nueva cuidad del Proveedor ";
            }

        }

        public static string ProdP(string texto)
        {
            if ((texto == "sacos") || (texto == "pantalones") || (texto == "camisetas") || (texto == "gorras") )
            {
                return texto;
            }
            else
            {
                return "realise un ingreso de nuevo producto";
            }

        }

    }
}