using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace GUI
{
    public partial class frmPrincipal : Form
    {
        NPersona persona = new NPersona();
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public void llenarPersonas() {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = persona.cargarPersonas("MASCULINO");
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            llenarPersonas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //frmAgregar nuevo = new frmAgregar();
            //nuevo.MdiParent = this;
            //this.splitContainer.Panel2.Controls.Add(nuevo);
            //dgvPersonas.Visible = false;
            //nuevo.ShowDialog();

            frmAgregar.InstanciaAgregar.MdiParent = this;
            this.splitContainer.Panel2.Controls.Add(frmAgregar.InstanciaAgregar);
            frmAgregar.InstanciaAgregar.Show();
            dgvPersonas.Visible = false;

        }
    }
}
