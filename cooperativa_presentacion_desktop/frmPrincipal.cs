using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cooperativa_presentacion_desktop;

namespace cooperativa_presentacion_desktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void creditoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form Frm_Empleado = new Frm_Empleado();
                Frm_Empleado.Show();
                
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FrmUsuario = new FrmUsuario();
            FrmUsuario.Show();
        }

        private void tipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmTipoCuenta = new FrmTipoCuenta();
            FrmTipoCuenta.Show();

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmSucursal = new FrmSucursal();
            FrmSucursal.Show();

        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Frm_Socio = new Frm_Socio();
            Frm_Socio.Show();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmUsuario = new FrmUsuario();
            FrmUsuario.Show();
        }
    }
}
