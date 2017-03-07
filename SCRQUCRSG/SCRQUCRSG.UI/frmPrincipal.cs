using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRQUCRSG.UI
{
    public partial class frmPrincipal : Form
    {
        MODEL.Usuario usuario;
        public frmPrincipal(MODEL.Usuario usuarioRegistrado)
        {
            usuario = usuarioRegistrado;
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
