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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {

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

    }
}
