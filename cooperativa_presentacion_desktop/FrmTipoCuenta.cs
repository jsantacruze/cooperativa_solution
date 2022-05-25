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
    public partial class FrmTipoCuenta : Form
    {
        public FrmTipoCuenta()
        {
            InitializeComponent();
        }

        private void btnbuscartipocuenta_Click(object sender, EventArgs e)
        {
            tIPO_CUENTABindingSource.DataSource =
                TipoCuenta_BO.GetList(txttipocuenta.Text);
        }
    }
}
