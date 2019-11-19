namespace Punto_de_venta.Vistas
{
    partial class FrmUsuarios
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.PnlDatosDelUsuario = new System.Windows.Forms.Panel();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblDatosDelUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblNivelDeUsuario = new System.Windows.Forms.Label();
            this.CmbNivelDeUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.PnlDatosDelUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(366, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(128, 25);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "USUARIOS";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 293);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(851, 302);
            this.DgvUsuarios.TabIndex = 9;
            // 
            // PnlDatosDelUsuario
            // 
            this.PnlDatosDelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PnlDatosDelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDatosDelUsuario.Controls.Add(this.CmbNivelDeUsuario);
            this.PnlDatosDelUsuario.Controls.Add(this.LblNivelDeUsuario);
            this.PnlDatosDelUsuario.Controls.Add(this.LblContraseña);
            this.PnlDatosDelUsuario.Controls.Add(this.TxtContraseña);
            this.PnlDatosDelUsuario.Controls.Add(this.LblUsuario);
            this.PnlDatosDelUsuario.Controls.Add(this.TxtUsuario);
            this.PnlDatosDelUsuario.Controls.Add(this.LblApellidos);
            this.PnlDatosDelUsuario.Controls.Add(this.TxtApellidos);
            this.PnlDatosDelUsuario.Controls.Add(this.LblNombres);
            this.PnlDatosDelUsuario.Controls.Add(this.TxtNombres);
            this.PnlDatosDelUsuario.Enabled = false;
            this.PnlDatosDelUsuario.Location = new System.Drawing.Point(51, 45);
            this.PnlDatosDelUsuario.Name = "PnlDatosDelUsuario";
            this.PnlDatosDelUsuario.Size = new System.Drawing.Size(768, 152);
            this.PnlDatosDelUsuario.TabIndex = 4;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(372, 32);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(74, 16);
            this.LblApellidos.TabIndex = 25;
            this.LblApellidos.Text = "Apellidos";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(462, 29);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(273, 22);
            this.TxtApellidos.TabIndex = 1;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidos_KeyPress);
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(29, 32);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(71, 16);
            this.LblNombres.TabIndex = 23;
            this.LblNombres.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(106, 29);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(250, 22);
            this.TxtNombres.TabIndex = 0;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombres_KeyPress);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Location = new System.Drawing.Point(142, 224);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 36);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAgregar.Location = new System.Drawing.Point(294, 224);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(130, 36);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnModificar.Enabled = false;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnModificar.Location = new System.Drawing.Point(449, 224);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(130, 36);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Location = new System.Drawing.Point(600, 224);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(130, 36);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // LblDatosDelUsuario
            // 
            this.LblDatosDelUsuario.AutoSize = true;
            this.LblDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosDelUsuario.Location = new System.Drawing.Point(58, 37);
            this.LblDatosDelUsuario.Name = "LblDatosDelUsuario";
            this.LblDatosDelUsuario.Size = new System.Drawing.Size(120, 15);
            this.LblDatosDelUsuario.TabIndex = 21;
            this.LblDatosDelUsuario.Text = "Datos del usuario";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(369, 79);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(87, 16);
            this.LblContraseña.TabIndex = 29;
            this.LblContraseña.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.Location = new System.Drawing.Point(462, 76);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(274, 22);
            this.TxtContraseña.TabIndex = 3;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(32, 79);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(62, 16);
            this.LblUsuario.TabIndex = 27;
            this.LblUsuario.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(107, 76);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(250, 22);
            this.TxtUsuario.TabIndex = 2;
            // 
            // LblNivelDeUsuario
            // 
            this.LblNivelDeUsuario.AutoSize = true;
            this.LblNivelDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNivelDeUsuario.Location = new System.Drawing.Point(40, 116);
            this.LblNivelDeUsuario.Name = "LblNivelDeUsuario";
            this.LblNivelDeUsuario.Size = new System.Drawing.Size(44, 16);
            this.LblNivelDeUsuario.TabIndex = 30;
            this.LblNivelDeUsuario.Text = "Nivel";
            // 
            // CmbNivelDeUsuario
            // 
            this.CmbNivelDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNivelDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbNivelDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbNivelDeUsuario.FormattingEnabled = true;
            this.CmbNivelDeUsuario.Location = new System.Drawing.Point(106, 113);
            this.CmbNivelDeUsuario.Name = "CmbNivelDeUsuario";
            this.CmbNivelDeUsuario.Size = new System.Drawing.Size(251, 24);
            this.CmbNivelDeUsuario.TabIndex = 4;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(875, 607);
            this.Controls.Add(this.LblDatosDelUsuario);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.PnlDatosDelUsuario);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.PnlDatosDelUsuario.ResumeLayout(false);
            this.PnlDatosDelUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Panel PnlDatosDelUsuario;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblDatosDelUsuario;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CmbNivelDeUsuario;
        private System.Windows.Forms.Label LblNivelDeUsuario;
    }
}