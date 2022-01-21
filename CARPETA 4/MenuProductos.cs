using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProyectoMDS1
{
    public partial class MenuProductos : Form
    {
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
            this.Hide();
        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            frmproveedores frm = new frmproveedores();
            frm.Show();
            this.Hide();
        }
    }
}
