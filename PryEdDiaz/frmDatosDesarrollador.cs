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
    public partial class frmDatosdelDesarrollador : Form
    {
        public frmDatosdelDesarrollador()
        {
            InitializeComponent();
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
