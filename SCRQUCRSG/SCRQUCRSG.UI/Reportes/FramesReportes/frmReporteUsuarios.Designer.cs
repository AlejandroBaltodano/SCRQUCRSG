namespace SCRQUCRSG.UI.Reportes.FramesReportes
{
    partial class frmReporteUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMigracion = new SCRQUCRSG.UI.DataSetMigracion();
            this.dataSetMigracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaUsuariosTableAdapter = new SCRQUCRSG.UI.DataSetMigracionTableAdapters.ConsultaUsuariosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Image = global::SCRQUCRSG.UI.Properties.Resources.arrow_redo;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(148, 39);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuarios";
            reportDataSource1.Value = this.consultaUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCRQUCRSG.UI.Reportes.Informes.ReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(660, 353);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataSetMigracion
            // 
            this.dataSetMigracion.DataSetName = "DataSetMigracion";
            this.dataSetMigracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetMigracionBindingSource
            // 
            this.dataSetMigracionBindingSource.DataSource = this.dataSetMigracion;
            this.dataSetMigracionBindingSource.Position = 0;
            // 
            // consultaUsuariosBindingSource
            // 
            this.consultaUsuariosBindingSource.DataMember = "ConsultaUsuarios";
            this.consultaUsuariosBindingSource.DataSource = this.dataSetMigracionBindingSource;
            // 
            // consultaUsuariosTableAdapter
            // 
            this.consultaUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Usuarios";
            this.Load += new System.EventHandler(this.frmReporteUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetMigracionBindingSource;
        private DataSetMigracion dataSetMigracion;
        private System.Windows.Forms.BindingSource consultaUsuariosBindingSource;
        private DataSetMigracionTableAdapters.ConsultaUsuariosTableAdapter consultaUsuariosTableAdapter;
    }
}