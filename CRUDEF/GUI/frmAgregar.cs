using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(int id , int codigo, string cedula, string nombre, string apellido1, string apellido2, DateTime fecha,
            string genero, string email)
        {
            InitializeComponent();
            txtID.Text = id.ToString();
            txtCodigo.Text = codigo.ToString();
            txtCedula.Text = cedula;
            txtNombre.Text = nombre;
            txtApellido1.Text = apellido1;
            txtApellido2.Text = apellido2;
            dtpFecha.Value = fecha;
            cboGenero.Text = genero;
            txtEmail.Text = email;
        }

        NPersona persona = new NPersona();
        private void frmAgregar_Load(object sender, EventArgs e)
        {
            LlenarGeneros();
        }

        private static frmAgregar Instancia = null;
        public static frmAgregar InstanciaAgregar {
            get {
                if (Instancia == null)
                {
                    Instancia = new frmAgregar();
                    Instancia.Disposed += new EventHandler(frmAgregarDispose);
                }
                return Instancia;
            }
        }

        public static void frmAgregarDispose(object o, EventArgs e) {
            Instancia = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        public void LlenarGeneros() {

            var dicGenero = new Dictionary<int, string> {
                { 0,"FEMENINO"},
                { 1,"MASCULINO"},

            }.ToList();
            cboGenero.DataSource = dicGenero;
            cboGenero.ValueMember = "Key";
            cboGenero.DisplayMember = "Value";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            GuardarPersona();
            Limpieza();
            Mensajes.Notificacion("Datos Almacenados Correctamente ");

        }

        public void GuardarPersona() {

            if (txtID.Text=="")
            {
                txtID.Text = "0";
            }
            
            string genero = cboGenero.SelectedValue.ToString();
            persona.GuardarPersona(
                int.Parse(txtCodigo.Text),
                txtCedula.Text,
                txtNombre.Text,
                txtApellido1.Text,
                txtApellido2.Text,
                dtpFecha.Value,
                int.Parse(genero),
                txtEmail.Text,
                int.Parse(txtID.Text)


                );
            
        
        }
        public void Limpieza() {


            txtCodigo.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtEmail.Text = "";
        }

    }
}
