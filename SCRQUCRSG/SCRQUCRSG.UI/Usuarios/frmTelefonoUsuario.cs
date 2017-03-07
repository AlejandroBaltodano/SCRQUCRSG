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
    public partial class frmTelefonoUsuario : Form
    {
        public int idUsuarioTelefono = 0;
        public string nombreUsuario = "";
        public int idTelefonoEditar = 0;
        public frmTelefonoUsuario(int IdUsuario, string Nombre)
        {
            idUsuarioTelefono = IdUsuario;
            nombreUsuario = Nombre;
            InitializeComponent();
        }

        private void frmTelefonoUsuario_Load(object sender, EventArgs e)
        {
            SeleccionarPrimero();
            llenarGrid();
        }
        public void SeleccionarPrimero()
        {
            txtTelefono.Select();
            txtTelefono.Focus();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevoTelefono.Enabled = true;
            lblNombreUsuario.Text = nombreUsuario;

        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtTelefono.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        public void llenarGrid()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query =
                "SELECT " +
                "t.IDTELEFONOUSUARIO," +
                "t.IDUSUARIO," +
                "t.NUMEROTELEFONO," +
                "u.CEDULA," +
                "u.NOMBRECOMPLETO " +
                "FROM TABLA_USUARIO u INNER JOIN TABLA_TELEFONO_USUARIOS t " +
                " ON u.IDUSUARIO = t.IDUSUARIO " +
                "WHERE u.IDUSUARIO =" + idUsuarioTelefono + " ";
            conexion.LlenarGrid(query, dgvTelefonosUsuario);
            PropiedadesGrip();
        }

        public void PropiedadesGrip()
        {

            this.dgvTelefonosUsuario.Columns[1].Visible = false;
            this.dgvTelefonosUsuario.Columns[0].HeaderText = "# Telefono";
            this.dgvTelefonosUsuario.Columns[4].HeaderText = "NOMBRE COMPLETO";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
                    string query =
                    "BEGIN " +
                    "INSERTARTELEFONO(" + idUsuarioTelefono + ", '" + txtTelefono.Text + "'); " +
                    "END; ";
                    conexion.OperacionDML(query);
                    MessageBox.Show("Transaccion realizada con exito", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrid();
                    txtTelefono.Clear();
                    SeleccionarPrimero();
                }
                else
                {
                    MessageBox.Show("Debe de llenar el campo", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SeleccionarPrimero();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
                    string query =
                    "BEGIN " +
                    "ACTUALIZARTELEFONO(" + idTelefonoEditar + ", '" + txtTelefono.Text + "'); " +
                    "END; ";
                    conexion.OperacionDML(query);
                    MessageBox.Show("Transaccion realizada con exito", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarGrid();
                    txtTelefono.Clear();
                    SeleccionarPrimero();
                }
                else
                {
                    MessageBox.Show("Debe de llenar el campo", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SeleccionarPrimero();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Eliminar este telefono?", "Informacion Requerida",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();

                    String query =
                        " BEGIN " +
                        " ELIMINARTELEFONO(" + idTelefonoEditar + "); " +
                        " END; ";
                    conexion.OperacionDML(query);

                    MessageBox.Show("Transaccion realizada con exito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTelefono.Clear();
                    SeleccionarPrimero();
                    llenarGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al realizar la Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvTelefonosUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTelefono.Text = this.dgvTelefonosUsuario.CurrentRow.Cells[2].Value.ToString();
            idTelefonoEditar = int.Parse(this.dgvTelefonosUsuario.CurrentRow.Cells[0].Value.ToString());
            btnNuevoTelefono.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
