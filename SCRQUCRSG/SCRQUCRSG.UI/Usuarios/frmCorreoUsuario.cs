using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRQUCRSG.UI.Usuarios
{
    public partial class frmCorreoUsuario : Form
    {
        public int idUsuarioCorreo = 0;
        public string nombreUsuario = "";
        public int idCorreoEditar = 0;
        public frmCorreoUsuario(int IdUsuario, string Nombre)
        {
            idUsuarioCorreo = IdUsuario;
            nombreUsuario = Nombre;
            InitializeComponent();
        }

        private void frmCorreoUsuario_Load(object sender, EventArgs e)
        {
            SeleccionarPrimero();
            llenarGrid();

        }
        public void SeleccionarPrimero()
        {
            txtCorreo.Select();
            txtCorreo.Focus();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevoCorreo.Enabled = true;
            lblNombreUsuario.Text = nombreUsuario;

        }
        public void llenarGrid()
        {
            ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
            string query = "select c.IDCORREOUSUARIO,c.IDUSUARIO,c.CORREO,u.CEDULA," +
"u.NOMBRECOMPLETO from TABLA_USUARIO u inner join TABLA_CORREO_USUARIO c " +
" on u.IDUSUARIO = c.IDUSUARIO where u.IDUSUARIO =" + idUsuarioCorreo + " ";
            conexion.LlenarGrid(query, dgvCorreosUsuario);
            PropiedadesGrip();
        }

        //metodo verifica si es correo valido
        public bool formatoCorreo()
        {
            String Formato;
            Formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtCorreo.Text, Formato))
            {
                if (Regex.Replace(txtCorreo.Text, Formato, String.Empty).Length == 0)
                {
                    return true;//es correcto
                }
                else
                {
                    return false;//es incorrecto
                }
            }
            else
            {
                return false;
            }
        }//fin metodo 

        public bool ValidarCampos()
        {
            bool bandera = false;

            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                bandera = true;
            }

            return bandera;

        }
        public void PropiedadesGrip()
        {

            this.dgvCorreosUsuario.Columns[1].Visible = false;
            this.dgvCorreosUsuario.Columns[0].HeaderText = "# CORREO";
            this.dgvCorreosUsuario.Columns[4].HeaderText = "NOMBRE COMPLETO";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (formatoCorreo())
                    {
                        ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
                        string query = "begin " +
" INSERTARCORREOUSUARIO(" + idUsuarioCorreo + ", '" + txtCorreo.Text + "'); end; ";
                        conexion.OperacionDML(query);
                        MessageBox.Show("Transaccion realizada con exito", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        txtCorreo.Clear();
                        SeleccionarPrimero();
                    }
                    else
                    {
                        MessageBox.Show("Formato de email incorrecto\nFormato correcto: ejmplo@dominio.com", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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
                    if (formatoCorreo())
                    {
                        ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();
                        string query = "begin " +
" ACTUALIZARCORREOUSUARIO(" + idCorreoEditar + ", '" + txtCorreo.Text + "'); end; ";
                        conexion.OperacionDML(query);
                        MessageBox.Show("Transaccion realizada con exito", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenarGrid();
                        txtCorreo.Clear();
                        SeleccionarPrimero();
                    }
                    else
                    {
                        MessageBox.Show("Formato de email incorrecto\nFormato correcto: ejmplo@dominio.com", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Debe de llenar el campo", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.Select();
                    txtCorreo.Focus();
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al realizar la transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCorreosUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCorreo.Text = this.dgvCorreosUsuario.CurrentRow.Cells[2].Value.ToString();
            idCorreoEditar = int.Parse(this.dgvCorreosUsuario.CurrentRow.Cells[0].Value.ToString());
            btnNuevoCorreo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea Eliminar el Correo?", "Informacion Requerida",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
  == DialogResult.Yes)
                {
                    ACCESOADATOS.ConexionOracle conexion = new ACCESOADATOS.ConexionOracle();

                    String query = " begin " +
             " ELIMINARCORREOUSUARIO(" + idCorreoEditar + "); " +
                            " end; ";
                    conexion.OperacionDML(query);

                    MessageBox.Show("Transaccion realizada con exito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Clear();
                    SeleccionarPrimero();
                    llenarGrid();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al realizar la Transaccion", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnImprimirCorreosUnUsuario_Click(object sender, EventArgs e)
        {
            //new Reportes.frmConsultaCorreosDeUnUsuario(idUsuarioCorreo).ShowDialog();
        }
    }
}
