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
    public partial class Frm_Socio : Form
    {
        public Frm_Socio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sOCIOBindingSource.DataSource =
                Socio_BO.getList(txtfiltrosocio.Text);
        }

        private void txtfiltrosocio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
