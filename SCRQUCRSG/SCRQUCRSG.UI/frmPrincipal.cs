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
            lblNombreUsuario.Text = usuario.NombreCompleto;
            lblFecha.Text = "" + DateTime.Now;
            BloquearPestañaUsuarios();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del Sistema?", "Informacion Requerida",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void BloquearPestañaUsuarios()
        {
            usuariosToolStripMenuItem.Enabled = false;
            if (usuario.idROL == 3)
            {
                usuariosToolStripMenuItem.Enabled = false;
            }
            else if (usuario.idROL == 2)
            {
                usuariosToolStripMenuItem.Enabled = false;
            }
            else
            {
                usuariosToolStripMenuItem.Enabled = true;
            }
        }

        private void mantenimientoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuarios.frmMantenimientoUsuarios(usuario).ShowDialog();
        }

        private void reporteUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reportes.FramesReportes.frmReporteUsuarios().ShowDialog();
        }
    }
}
