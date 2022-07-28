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
                Credito_BO.getList(Text);
        }

        private void txtcredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregarcredito_Click(object sender, EventArgs e)
        {

            frmagregar_credito frm = new frmagregar_credito();

            frm.Show();
        }

        private void btneliminarcredito_Click(object sender, EventArgs e)
        {
            cREDITODataGridView.Rows.RemoveAt(cREDITODataGridView.CurrentRow.Index);
        }

        private void btnsalircredito_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
