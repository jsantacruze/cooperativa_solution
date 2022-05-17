using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cooperativa_datos;
using cooperativa_negocio;

namespace cooperativa_presentacion_desktop
{
    public partial class frmPersonaList : Form
    {
        public frmPersonaList()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                pERSONABindingSource.DataSource = PersonaBO.getList(txtFiltro.Text);
                Cursor.Current = Cursors.Arrow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Personas", MessageBoxButtons.OK);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
