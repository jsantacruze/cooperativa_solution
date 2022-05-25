using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cooperativa_negocio;

namespace cooperativa_presentacion_desktop
{
    public partial class Frm_Empleado : Form
    {
        public Frm_Empleado()
        {
            InitializeComponent();
        }

        
        private void txtfiltroempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfiltroempleado_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnbuscarempleado_Click_1(object sender, EventArgs e)
        {
            eMPLEADOBindingSource.DataSource =
                Empleado_BO.GetList(txtempleado.Text);
        }

        private void textBoxempleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
