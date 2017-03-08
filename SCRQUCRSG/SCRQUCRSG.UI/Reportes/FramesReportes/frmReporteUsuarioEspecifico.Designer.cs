namespace SCRQUCRSG.UI.Reportes.FramesReportes
{
    partial class frmReporteUsuarioEspecifico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteUsuarioEspecifico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMigracion = new SCRQUCRSG.UI.DataSetMigracion();
            this.dataSetMigracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLACORREOUSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLA_CORREO_USUARIOTableAdapter = new SCRQUCRSG.UI.DataSetMigracionTableAdapters.TABLA_CORREO_USUARIOTableAdapter();
            this.tABLATELEFONOUSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tABLA_TELEFONO_USUARIOSTableAdapter = new SCRQUCRSG.UI.DataSetMigracionTableAdapters.TABLA_TELEFONO_USUARIOSTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLACORREOUSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLATELEFONOUSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 49);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtFiltro);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 75);
            this.panel2.TabIndex = 3;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Enabled = false;
            this.txtFiltro.Location = new System.Drawing.Point(189, 10);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(241, 26);
            this.txtFiltro.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::SCRQUCRSG.UI.Properties.Resources.book_add;
            this.btnBuscar.Location = new System.Drawing.Point(436, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(209, 62);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Presione para Buscar...";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un Usuario:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCorreos";
            reportDataSource1.Value = this.tABLACORREOUSUARIOBindingSource;
            reportDataSource2.Name = "DataSetTelefonos";
            reportDataSource2.Value = this.tABLATELEFONOUSUARIOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SCRQUCRSG.UI.Reportes.Informes.ReporteUsuarioEspecifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(650, 276);
            this.reportViewer1.TabIndex = 4;
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
            // tABLACORREOUSUARIOBindingSource
            // 
            this.tABLACORREOUSUARIOBindingSource.DataMember = "TABLA_CORREO_USUARIO";
            this.tABLACORREOUSUARIOBindingSource.DataSource = this.dataSetMigracionBindingSource;
            // 
            // tABLA_CORREO_USUARIOTableAdapter
            // 
            this.tABLA_CORREO_USUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tABLATELEFONOUSUARIOSBindingSource
            // 
            this.tABLATELEFONOUSUARIOSBindingSource.DataMember = "TABLA_TELEFONO_USUARIOS";
            this.tABLATELEFONOUSUARIOSBindingSource.DataSource = this.dataSetMigracionBindingSource;
            // 
            // tABLA_TELEFONO_USUARIOSTableAdapter
            // 
            this.tABLA_TELEFONO_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuarioEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporteUsuarioEspecifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Usuario Especifico";
            this.Load += new System.EventHandler(this.frmReporteUsuarioEspecifico_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMigracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLACORREOUSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLATELEFONOUSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private DataSetMigracion dataSetMigracion;
        private System.Windows.Forms.BindingSource dataSetMigracionBindingSource;
        private System.Windows.Forms.BindingSource tABLACORREOUSUARIOBindingSource;
        private DataSetMigracionTableAdapters.TABLA_CORREO_USUARIOTableAdapter tABLA_CORREO_USUARIOTableAdapter;
        private System.Windows.Forms.BindingSource tABLATELEFONOUSUARIOSBindingSource;
        private DataSetMigracionTableAdapters.TABLA_TELEFONO_USUARIOSTableAdapter tABLA_TELEFONO_USUARIOSTableAdapter;
    }
}