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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        NPersona persona = new NPersona();
        private void btnCompras_Click(object sender, EventArgs e)
        {
            dgvCompras.DataSource = null;
            dgvCompras.DataSource = persona.CargaCompras();

        }

        private void btnAplcarDescuento_Click(object sender, EventArgs e)
        {
            persona.AplicarDescuentos(int.Parse(txtDescuento.Text));
            dgvCompras.DataSource = persona.CargaCompras();
        }
    }
}
