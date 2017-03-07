using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace SCRQUCRSG.UI.Usuarios
{
    public partial class frmNuevoUsuario : Form
    {
   

        public frmNuevoUsuario()
        {
           
            InitializeComponent();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            SeleccionarPrimero();
        }

        public void SeleccionarPrimero()
        {

            txtNombreUsuario.Select();
            txtNombreUsuario.Focus();
        }

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtNombreUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text) &&
            !string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        public bool ValidarUsuario()
        {
            String cedula = String.Empty;
            String login = String.Empty;

            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            String query = "SELECT CEDULA,USUARIOLOGIN FROM TABLA_USUARIO WHERE " +
 " USUARIOLOGIN = upper('" + txtNombreUsuario.Text + "') or CEDULA = '" + txtCedula.Text + "'";

            OracleDataReader reader = conexion.Query(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cedula = reader.GetString(0);
                    login = reader.GetString(1);

                }

            }
            if (txtCedula.Text == cedula || txtNombreUsuario.Text.ToUpper() == login)
            {
                return false;

            }
            else
            {
                return true;
            }


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (ValidarUsuario())
                    {
                       ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
                        string Query = "begin " +
                           "INSERTARUSUARIO('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtNombreUsuario.Text + "','" + txtContraseña.Text + "'," + cbROL.SelectedValue + " ); " +
                                              "end; ";
                        // se envia los parametros en la consulta
                        conexion.OperacionDML(Query);
                        MessageBox.Show("Transaccion Realizada exitosamente", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La cedula o el nombre de usuario ya existen en el sistema\nDebe de ingresar otro regsitro diferente", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Debe ingresar datos en los campos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al Realizar la Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void llenarComboBoxRoles()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string Query = "select * from TABLA_ROLES_USUARIOS";//procedimiento almacenado que me realiza la consulta
            string id = "IDROLUSUARIO"; //id de la tabla
            string descripcion = "NOMBREROL";
            string nombreTabla = "TABLA_ROLES_USUARIOS";//nombre de la tabla
            conexion.LlenarCombo(Query, cbROL, id, descripcion, nombreTabla);// se invoca el metodo

        }
    }
}
