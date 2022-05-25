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
    public partial class FrmSucursal : Form
    {

        public FrmSucursal()
        {
            InitializeComponent();
        }

        private void txtfiltrosocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sUCURSALBindingSource.DataSource =
               Sucursal_BO.getList(txtfiltrosucursal1.Text);
        }
    }
}
