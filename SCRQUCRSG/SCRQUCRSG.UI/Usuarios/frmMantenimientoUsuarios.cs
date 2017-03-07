using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRQUCRSG.UI.Usuarios
{
    public partial class frmMantenimientoUsuarios : Form
    {
        MODEL.Usuario usuario;
        public frmMantenimientoUsuarios(MODEL.Usuario usuarioRegistrado)
        {
            usuario = usuarioRegistrado;
            InitializeComponent();
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {


        }
    }
}
