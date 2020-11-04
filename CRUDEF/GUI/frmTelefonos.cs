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

namespace GUI
{
    public partial class frmTelefonos : Form
    {
        public frmTelefonos()
        {
            InitializeComponent();
        }

        NPersona persona = new NPersona();
        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            LlenarTelefonos();
        }
        public void LlenarTelefonos() {
            dgvTelefono.DataSource = persona.TelefonosPersona();
        
        }

    }
}
