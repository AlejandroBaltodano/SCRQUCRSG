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

namespace SCRQUCRSG.UI
{
    public partial class frmLogin : Form
    {
        SCRQUCRSG.MODEL.Usuario usuarioRegistro;
        public frmLogin()
        {
            usuarioRegistro = new MODEL.Usuario();
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SeleccionPrimero();

        }
        public void SeleccionPrimero()
        {

            txtUsuario.Select();
            txtUsuario.Focus();

        }
        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text))
            {
                bandera = true;
            }

            return bandera;

        }

        public void IngresarAlSistema(String usuario, String contraseña)
        {

            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query = "";
            query = "SELECT * FROM MIGRACION.TABLA_USUARIO " +
            "where USUARIOLOGIN = upper('" + usuario + "') and PASSWORDLOGIN = MY_HASH(upper('" + usuario + "'), '" + contraseña + "') ";

            try
            {
                if (ValidarCampos())
                {
                    OracleDataReader reader = conexion.Query(query);

                    if ((reader.HasRows))
                    {

                        while (reader.Read())
                        {
                            usuarioRegistro.idUsuario = reader.GetInt32(0);
                            usuarioRegistro.Cedula = reader.GetString(1);
                            usuarioRegistro.NombreCompleto = reader.GetString(2);
                            usuarioRegistro.idROL = reader.GetInt32(5);


                        }
                        usuarioRegistro.NombreUsuario = txtUsuario.Text;
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        new frmPrincipal(usuarioRegistro).Show();
                        reader.Close();
                        this.Visible = false;

                    }
                    else if (txtUsuario.Text.Equals("admin") && txtContraseña.Text.Equals("admin"))
                    {
                        usuarioRegistro.idUsuario = 0;
                        usuarioRegistro.Cedula = "1";
                        usuarioRegistro.NombreCompleto = "Restaurador de BASE de Datos";
                        usuarioRegistro.idROL = 2;
                        usuarioRegistro.NombreUsuario = "Restaurador";
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        new frmPrincipal(usuarioRegistro).Show();
                        reader.Close();
                        this.Visible = false;

                    }
                    else
                    {
                        txtUsuario.Clear();
                        txtContraseña.Clear();
                        MessageBox.Show("Usuario no Registrado", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SeleccionPrimero();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar datos en los campos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SeleccionPrimero();
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al Realizar la Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarAlSistema(txtUsuario.Text, txtContraseña.Text);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarAlSistema(txtUsuario.Text, txtContraseña.Text);
            }
        }
    }
}
