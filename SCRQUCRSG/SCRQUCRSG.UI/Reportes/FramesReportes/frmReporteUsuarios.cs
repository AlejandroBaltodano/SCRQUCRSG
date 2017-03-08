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
    public partial class frmReporteUsuarios : Form
    {
        public frmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMigracion.ConsultaUsuarios' table. You can move, or remove it, as needed.
            this.consultaUsuariosTableAdapter.Fill(this.dataSetMigracion.ConsultaUsuarios);


            this.reportViewer1.RefreshReport();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
