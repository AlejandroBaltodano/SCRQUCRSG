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
    public partial class frmReporteTodosUsuarios : Form
    {
        public frmReporteTodosUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteTodosUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMigracion.TABLA_TELEFONO_USUARIOS' table. You can move, or remove it, as needed.
            this.tABLA_TELEFONO_USUARIOSTableAdapter.Fill(this.dataSetMigracion.TABLA_TELEFONO_USUARIOS);
            // TODO: This line of code loads data into the 'dataSetMigracion.TABLA_CORREO_USUARIO' table. You can move, or remove it, as needed.
            this.tABLA_CORREO_USUARIOTableAdapter.Fill(this.dataSetMigracion.TABLA_CORREO_USUARIO);

            this.reportViewer1.RefreshReport();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
