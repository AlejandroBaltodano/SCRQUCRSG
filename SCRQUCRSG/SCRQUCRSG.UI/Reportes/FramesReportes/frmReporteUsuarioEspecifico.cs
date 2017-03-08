using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRQUCRSG.UI.Reportes.FramesReportes
{
    public partial class frmReporteUsuarioEspecifico : Form
    {
       
        public frmReporteUsuarioEspecifico()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarioEspecifico_Load(object sender, EventArgs e)
        {
            btnBuscar.Select();
            btnBuscar.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Selecciones.frmSeleccionarUsuario seleccionUsuario = new Selecciones.frmSeleccionarUsuario();
            int idUsuario = 0;
        string nombreUsuario = "";
            string cedula = "";


            if (seleccionUsuario.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow item in seleccionUsuario.dgvSeleccionarUsuario.SelectedRows)
                {
                    idUsuario = int.Parse(item.Cells[0].Value.ToString());
                    cedula = item.Cells[1].Value.ToString();
                    nombreUsuario = item.Cells[2].Value.ToString();
                   

                }

                

            }
            txtFiltro.Text = cedula + " - " + nombreUsuario;
            imprimir(idUsuario);
        }


        public void imprimir(int idUsuarioSeleccionado) {

            // TODO: This line of code loads data into the 'dataSetMigracion.TABLA_TELEFONO_USUARIOS' table. You can move, or remove it, as needed.
            this.tABLA_TELEFONO_USUARIOSTableAdapter.FillTelefonoUsuario(this.dataSetMigracion.TABLA_TELEFONO_USUARIOS,idUsuarioSeleccionado);
            // TODO: This line of code loads data into the 'dataSetMigracion.TABLA_CORREO_USUARIO' table. You can move, or remove it, as needed.
            this.tABLA_CORREO_USUARIOTableAdapter.FillCorreoIdUsuario(this.dataSetMigracion.TABLA_CORREO_USUARIO,idUsuarioSeleccionado);

            this.reportViewer1.RefreshReport();

        }
    }
}
