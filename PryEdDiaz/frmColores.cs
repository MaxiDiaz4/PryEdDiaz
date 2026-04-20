using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiaz
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Colores.txt";
            x.Grabar(txtNombreColor.Text);
            MessageBox.Show("Datos Grabados");
            x.Recorrer(lstColores);

            txtNombreColor.Text = "";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Colores.txt";
            x.BorrarTodo();
            x.Recorrer(lstColores);
            MessageBox.Show("Datos Borrados");
            txtNombreColor.Clear();
        }
    }
}
