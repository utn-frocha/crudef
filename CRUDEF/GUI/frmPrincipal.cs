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
        public void llenarPersonas(string genero =null) {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = persona.cargarPersonas(genero);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string dato = cboGenero.Text.ToString();
            llenarPersonas(dato);
        }

        private void dgvPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pid = IdPersona();
            int codigo=int.Parse(  dgvPersonas.CurrentRow.Cells["Codigo"].Value.ToString());
          string cedula = dgvPersonas.CurrentRow.Cells["Cedula"].Value.ToString();
           string nombre =dgvPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
           string apellido1 = dgvPersonas.CurrentRow.Cells["Apellido1"].Value.ToString();
          string  apellido2 =dgvPersonas.CurrentRow.Cells["Apellido2"].Value.ToString();
           string genero = dgvPersonas.CurrentRow.Cells["Genero"].Value.ToString();
            string fecha = dgvPersonas.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
           DateTime ofecha = Convert.ToDateTime(fecha);
           string email =dgvPersonas.CurrentRow.Cells["Email"].Value.ToString();

            frmAgregar agregar = new frmAgregar(pid,codigo, cedula, nombre, apellido1, apellido2, ofecha, genero, email);
            agregar.Show();
        }

        private int IdPersona() {
            int pid;
            return    pid = int.Parse(dgvPersonas.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.EliminaPersona(IdPersona());
            Mensajes.Notificacion("Datos Eliminados  Correctamente ");
            llenarPersonas();
        }

        private void btnCargarCompra_Click(object sender, EventArgs e)
        {
            frmCompras nuevo = new frmCompras();
            nuevo.MdiParent = this;
            this.splitContainer.Panel2.Controls.Add(nuevo);
            dgvPersonas.Visible = false;
            nuevo.Show();
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            frmTelefonos nuevo = new frmTelefonos();
            nuevo.MdiParent = this;
            this.splitContainer.Panel2.Controls.Add(nuevo);
            dgvPersonas.Visible = false;
            nuevo.Show();
        }
    }
}
