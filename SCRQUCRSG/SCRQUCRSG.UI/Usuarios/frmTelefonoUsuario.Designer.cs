namespace SCRQUCRSG.UI.Usuarios
{
    partial class frmTelefonoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelefonoUsuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevoTelefono = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTelefonosUsuario = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 48);
            this.panel2.TabIndex = 4;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 52);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(325, 14);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(33, 25);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teléfonos del Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevoTelefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(214, 39);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Suprimir";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(297, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(207, 39);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Aplicar Cambios";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevoTelefono
            // 
            this.btnNuevoTelefono.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTelefono.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoTelefono.Image")));
            this.btnNuevoTelefono.Location = new System.Drawing.Point(510, 79);
            this.btnNuevoTelefono.Name = "btnNuevoTelefono";
            this.btnNuevoTelefono.Size = new System.Drawing.Size(199, 39);
            this.btnNuevoTelefono.TabIndex = 2;
            this.btnNuevoTelefono.Text = "Crear";
            this.btnNuevoTelefono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoTelefono.UseVisualStyleBackColor = false;
            this.btnNuevoTelefono.Click += new System.EventHandler(this.btnNuevoTelefono_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(249, 34);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(255, 26);
            this.txtTelefono.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teléfono:";
            // 
            // dgvTelefonosUsuario
            // 
            this.dgvTelefonosUsuario.AllowUserToAddRows = false;
            this.dgvTelefonosUsuario.AllowUserToDeleteRows = false;
            this.dgvTelefonosUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTelefonosUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTelefonosUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelefonosUsuario.Location = new System.Drawing.Point(0, 176);
            this.dgvTelefonosUsuario.Name = "dgvTelefonosUsuario";
            this.dgvTelefonosUsuario.ReadOnly = true;
            this.dgvTelefonosUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonosUsuario.Size = new System.Drawing.Size(711, 268);
            this.dgvTelefonosUsuario.TabIndex = 7;
            this.dgvTelefonosUsuario.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvTelefonosUsuario_MouseDoubleClick);
            // 
            // frmTelefonoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(711, 492);
            this.Controls.Add(this.dgvTelefonosUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTelefonoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefonos Usuario";
            this.Load += new System.EventHandler(this.frmTelefonoUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonosUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTelefonosUsuario;
    }
}