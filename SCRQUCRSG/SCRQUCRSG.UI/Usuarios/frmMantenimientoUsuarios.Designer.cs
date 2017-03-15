namespace SCRQUCRSG.UI.Usuarios
{
    partial class frmMantenimientoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuarios));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoCorreo = new System.Windows.Forms.Button();
            this.btnNuevoTelefono = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBuscarUsuario);
            this.panel2.Controls.Add(this.btnNuevoUsuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEditarUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 99);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SCRQUCRSG.UI.Properties.Resources.search16_h;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(366, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BUSCAR:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(97, 70);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(263, 26);
            this.txtBuscarUsuario.TabIndex = 4;
            this.txtBuscarUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarUsuario_KeyUp);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Image = global::SCRQUCRSG.UI.Properties.Resources.add;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(605, 57);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(149, 39);
            this.btnNuevoUsuario.TabIndex = 3;
            this.btnNuevoUsuario.Text = "Crear";
            this.btnNuevoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE USUARIOS DEL SISTEMA";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Image = global::SCRQUCRSG.UI.Properties.Resources.user_edit;
            this.btnEditarUsuario.Location = new System.Drawing.Point(443, 57);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(156, 39);
            this.btnEditarUsuario.TabIndex = 2;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 50);
            this.panel1.TabIndex = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.Image = global::SCRQUCRSG.UI.Properties.Resources.arrow_redo;
            this.btnRegresar.Location = new System.Drawing.Point(12, 6);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(733, 39);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnNuevoCorreo);
            this.panel3.Controls.Add(this.btnNuevoTelefono);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 48);
            this.panel3.TabIndex = 8;
            // 
            // btnNuevoCorreo
            // 
            this.btnNuevoCorreo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoCorreo.Image = global::SCRQUCRSG.UI.Properties.Resources.email_add;
            this.btnNuevoCorreo.Location = new System.Drawing.Point(605, 3);
            this.btnNuevoCorreo.Name = "btnNuevoCorreo";
            this.btnNuevoCorreo.Size = new System.Drawing.Size(148, 39);
            this.btnNuevoCorreo.TabIndex = 6;
            this.btnNuevoCorreo.Text = "Correo Usuario";
            this.btnNuevoCorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCorreo.UseVisualStyleBackColor = false;
            this.btnNuevoCorreo.Click += new System.EventHandler(this.btnNuevoCorreo_Click);
            // 
            // btnNuevoTelefono
            // 
            this.btnNuevoTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevoTelefono.Image = global::SCRQUCRSG.UI.Properties.Resources.phone_add;
            this.btnNuevoTelefono.Location = new System.Drawing.Point(420, 3);
            this.btnNuevoTelefono.Name = "btnNuevoTelefono";
            this.btnNuevoTelefono.Size = new System.Drawing.Size(179, 39);
            this.btnNuevoTelefono.TabIndex = 7;
            this.btnNuevoTelefono.Text = "Teléfono Usuario";
            this.btnNuevoTelefono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoTelefono.UseVisualStyleBackColor = false;
            this.btnNuevoTelefono.Click += new System.EventHandler(this.btnNuevoTelefono_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 99);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(758, 252);
            this.dgvUsuarios.TabIndex = 9;
            // 
            // frmMantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(758, 449);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Usuarios";
            this.Load += new System.EventHandler(this.frmMantenimientoUsuarios_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnNuevoTelefono;
        private System.Windows.Forms.Button btnNuevoCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}