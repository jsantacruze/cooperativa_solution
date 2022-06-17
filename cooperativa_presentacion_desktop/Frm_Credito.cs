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
    public partial class Frm_Credito : Form
    {
        public Frm_Credito()
        {
            InitializeComponent();
        }

        private void btnbuscarcredito_Click(object sender, EventArgs e)
        {
            cREDITOBindingSource.DataSource =
                Credito_BO.getList(txtcredito.Text);
        }
    }
}
