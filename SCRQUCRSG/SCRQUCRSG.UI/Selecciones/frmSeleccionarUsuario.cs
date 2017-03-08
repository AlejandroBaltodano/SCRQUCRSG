using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRQUCRSG.UI.Selecciones
{
    public partial class frmSeleccionarUsuario : Form
    {
        public frmSeleccionarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeleccionarUsuario_Load(object sender, EventArgs e)
        {
            SeleccionarPrimero();
            LlenarGridUsuarios();
          
        }
        public void SeleccionarPrimero()
        {
            txtBuscarUsuario.Select();
            txtBuscarUsuario.Focus();

        }
        public void LlenarGridUsuarios()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query = "select u.IDUSUARIO,u.CEDULA,u.NOMBRECOMPLETO,u.USUARIOLOGIN," +
                  "u.PASSWORDLOGIN,r.NOMBREROL from TABLA_USUARIO u inner join TABLA_ROLES_USUARIOS r " +
                  "on u.IDROLUSUARIO = r.IDROLUSUARIO";//procedimiento que realiza la consulta
            conexion.LlenarGrid(query, dgvSeleccionarUsuario);// se invoca el metodo y se envia la consulta y el grid a llenar
            PropiedadesGrip();
        }
        public void PropiedadesGrip()
        {
            //this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvSeleccionarUsuario.Columns[3].Visible = false;
            this.dgvSeleccionarUsuario.Columns[4].Visible = false;
            this.dgvSeleccionarUsuario.Columns[0].HeaderText = "# Usuario";
            this.dgvSeleccionarUsuario.Columns[2].HeaderText = "NOMBRE COMPLETO";
            this.dgvSeleccionarUsuario.Columns[5].HeaderText = "ROL";

        }
        public void BuscarUsuario()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query = "select u.IDUSUARIO,u.CEDULA,u.NOMBRECOMPLETO,u.USUARIOLOGIN," +
                  "u.PASSWORDLOGIN,r.NOMBREROL from TABLA_USUARIO u inner join TABLA_ROLES_USUARIOS r " +
                  "on u.IDROLUSUARIO = r.IDROLUSUARIO where u.NOMBRECOMPLETO LIKE '%" + txtBuscarUsuario.Text + "%'" +
                  " or u.CEDULA LIKE '" + txtBuscarUsuario.Text + "%' ";

            conexion.LlenarGrid(query, dgvSeleccionarUsuario);
            PropiedadesGrip();



        }

        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarUsuario();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            new Usuarios.frmNuevoUsuario().ShowDialog();
            LlenarGridUsuarios();
        }

        private void dgvSeleccionarUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSeleccionarUsuario.SelectedRows.Count == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
