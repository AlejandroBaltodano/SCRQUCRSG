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
            SeleccionarPrimero();

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
            conexion.LlenarGrid(query, dgvUsuarios);// se invoca el metodo y se envia la consulta y el grid a llenar
            PropiedadesGrip();
        }
        public void PropiedadesGrip()
        {
            //this.dgvUsuarios.Columns[0].Visible = false;
            this.dgvUsuarios.Columns[3].Visible = false;
            this.dgvUsuarios.Columns[4].Visible = false;
            this.dgvUsuarios.Columns[0].HeaderText = "# Usuario";
            this.dgvUsuarios.Columns[2].HeaderText = "NOMBRE COMPLETO";
            this.dgvUsuarios.Columns[5].HeaderText = "ROL";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            new Usuarios.frmNuevoUsuario().ShowDialog();
            LlenarGridUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int codigoUnicoUsuario = 0;
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro a Editar", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                codigoUnicoUsuario = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                new Usuarios.frmEditarUsuario(usuario, codigoUnicoUsuario).ShowDialog();
                LlenarGridUsuarios();

            }
        }

        private void btnNuevoCorreo_Click(object sender, EventArgs e)
        {
            int codigoUnicoUsuario = 0;
            String nombreUsuario = String.Empty;
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                codigoUnicoUsuario = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                nombreUsuario = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                new Usuarios.frmCorreoUsuario(codigoUnicoUsuario, nombreUsuario).ShowDialog();
                LlenarGridUsuarios();

            }
        }
        public void BuscarUsuario()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query = "select u.IDUSUARIO,u.CEDULA,u.NOMBRECOMPLETO,u.USUARIOLOGIN," +
                  "u.PASSWORDLOGIN,r.NOMBREROL from TABLA_USUARIO u inner join TABLA_ROLES_USUARIOS r " +
                  "on u.IDROLUSUARIO = r.IDROLUSUARIO where u.NOMBRECOMPLETO LIKE '%" + txtBuscarUsuario.Text + "%'" +
                  " or u.CEDULA LIKE '" + txtBuscarUsuario.Text + "%' ";

            conexion.LlenarGrid(query, dgvUsuarios);
            PropiedadesGrip();



        }


        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarUsuario();
        }

        private void btnImprimirUnUsuario_Click(object sender, EventArgs e)
        {
            //int codigoUnicoUsuario = 0;
            //String nombreUsuario = String.Empty;
            //if (dgvUsuarios.Rows.Count == 0)
            //{
            //    MessageBox.Show("Selecione un registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            //    codigoUnicoUsuario = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            //    new Reportes.frmReporteDeUnUsuario(codigoUnicoUsuario).ShowDialog();


            //}
        }

        private void btnNuevoTelefono_Click(object sender, EventArgs e)
        {
            int codigoUnicoUsuario = 0;
            String nombreUsuario = String.Empty;
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Selecione un registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                codigoUnicoUsuario = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                nombreUsuario = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                new Usuarios.frmTelefonoUsuario(codigoUnicoUsuario, nombreUsuario).ShowDialog();
                LlenarGridUsuarios();

            }
        }
    }
}
