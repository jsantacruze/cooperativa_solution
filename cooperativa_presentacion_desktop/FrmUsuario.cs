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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {
            uSUARIOBindingSource.DataSource =
                Usuario_BO.getList(txtusuario.Text);
        }
    }
}
