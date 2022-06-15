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
            uSUARIOBindingSource1.DataSource =
                Usuario_BO.getList(txtusuario.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            this.Hide();

           frm_agregar frm = new frm_agregar();

            frm.Show();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            uSUARIODataGridView.Rows.RemoveAt(uSUARIODataGridView.CurrentRow.Index);
        }
    }
}
