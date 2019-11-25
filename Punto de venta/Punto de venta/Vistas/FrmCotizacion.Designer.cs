namespace Punto_de_venta.Vistas
{
    partial class FrmCotizacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCotizacion = new System.Windows.Forms.TextBox();
            this.DgvServiciosDelPaquete = new System.Windows.Forms.DataGridView();
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.BtnPersonalizar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.PnlPaquetePersonalizado = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PnlPaquetePredefinido = new System.Windows.Forms.Panel();
            this.PnlDatosPaquetePre = new System.Windows.Forms.Panel();
            this.LblDestallesPaquetePre = new System.Windows.Forms.Label();
            this.PnlDetallesPaquetePre = new System.Windows.Forms.Panel();
            this.RtxDetallesPaquetePre = new System.Windows.Forms.RichTextBox();
            this.CmbPaquetesPredefinidos = new System.Windows.Forms.ComboBox();
            this.LblNombrePaquetePredefinido = new System.Windows.Forms.Label();
            this.LblDatosDelUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvServiciosDelPaquete)).BeginInit();
            this.PnlPaquetePersonalizado.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PnlPaquetePredefinido.SuspendLayout();
            this.PnlDatosPaquetePre.SuspendLayout();
            this.PnlDetallesPaquetePre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.PnlPaquetePersonalizado);
            this.panel1.Controls.Add(this.PnlPaquetePredefinido);
            this.panel1.Controls.Add(this.LblDatosDelUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 788);
            this.panel1.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnGuardar);
            this.panel6.Controls.Add(this.TxtCotizacion);
            this.panel6.Controls.Add(this.DgvServiciosDelPaquete);
            this.panel6.Controls.Add(this.BtnCotizar);
            this.panel6.Controls.Add(this.BtnPersonalizar);
            this.panel6.Controls.Add(this.BtnNuevo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 490);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(875, 284);
            this.panel6.TabIndex = 27;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuardar.Location = new System.Drawing.Point(572, 228);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 36);
            this.BtnGuardar.TabIndex = 29;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtCotizacion
            // 
            this.TxtCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCotizacion.Location = new System.Drawing.Point(679, 196);
            this.TxtCotizacion.Name = "TxtCotizacion";
            this.TxtCotizacion.ReadOnly = true;
            this.TxtCotizacion.Size = new System.Drawing.Size(142, 26);
            this.TxtCotizacion.TabIndex = 28;
            this.TxtCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DgvServiciosDelPaquete
            // 
            this.DgvServiciosDelPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvServiciosDelPaquete.Location = new System.Drawing.Point(53, 19);
            this.DgvServiciosDelPaquete.Name = "DgvServiciosDelPaquete";
            this.DgvServiciosDelPaquete.Size = new System.Drawing.Size(768, 171);
            this.DgvServiciosDelPaquete.TabIndex = 27;
            // 
            // BtnCotizar
            // 
            this.BtnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnCotizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCotizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCotizar.Location = new System.Drawing.Point(436, 228);
            this.BtnCotizar.Name = "BtnCotizar";
            this.BtnCotizar.Size = new System.Drawing.Size(130, 36);
            this.BtnCotizar.TabIndex = 26;
            this.BtnCotizar.Text = "Cotizar";
            this.BtnCotizar.UseVisualStyleBackColor = false;
            this.BtnCotizar.Click += new System.EventHandler(this.BtnCotizar_Click);
            // 
            // BtnPersonalizar
            // 
            this.BtnPersonalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnPersonalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPersonalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnPersonalizar.Location = new System.Drawing.Point(300, 228);
            this.BtnPersonalizar.Name = "BtnPersonalizar";
            this.BtnPersonalizar.Size = new System.Drawing.Size(130, 36);
            this.BtnPersonalizar.TabIndex = 25;
            this.BtnPersonalizar.Text = "Personalizar";
            this.BtnPersonalizar.UseVisualStyleBackColor = false;
            this.BtnPersonalizar.Click += new System.EventHandler(this.BtnPersonalizar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevo.Location = new System.Drawing.Point(164, 228);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(130, 36);
            this.BtnNuevo.TabIndex = 24;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // PnlPaquetePersonalizado
            // 
            this.PnlPaquetePersonalizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.PnlPaquetePersonalizado.Controls.Add(this.panel4);
            this.PnlPaquetePersonalizado.Controls.Add(this.dataGridView1);
            this.PnlPaquetePersonalizado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPaquetePersonalizado.Location = new System.Drawing.Point(0, 181);
            this.PnlPaquetePersonalizado.Name = "PnlPaquetePersonalizado";
            this.PnlPaquetePersonalizado.Size = new System.Drawing.Size(875, 309);
            this.PnlPaquetePersonalizado.TabIndex = 26;
            this.PnlPaquetePersonalizado.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TxtUsuario);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(53, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 119);
            this.panel4.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(718, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Detalles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Costo";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(570, 11);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(142, 22);
            this.TxtUsuario.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.richTextBox2);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(3, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 72);
            this.panel5.TabIndex = 25;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.Location = new System.Drawing.Point(3, 11);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(750, 51);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(404, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Servicio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 144);
            this.dataGridView1.TabIndex = 28;
            // 
            // PnlPaquetePredefinido
            // 
            this.PnlPaquetePredefinido.Controls.Add(this.PnlDatosPaquetePre);
            this.PnlPaquetePredefinido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPaquetePredefinido.Location = new System.Drawing.Point(0, 0);
            this.PnlPaquetePredefinido.Name = "PnlPaquetePredefinido";
            this.PnlPaquetePredefinido.Size = new System.Drawing.Size(875, 181);
            this.PnlPaquetePredefinido.TabIndex = 25;
            // 
            // PnlDatosPaquetePre
            // 
            this.PnlDatosPaquetePre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDatosPaquetePre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PnlDatosPaquetePre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDatosPaquetePre.Controls.Add(this.LblDestallesPaquetePre);
            this.PnlDatosPaquetePre.Controls.Add(this.PnlDetallesPaquetePre);
            this.PnlDatosPaquetePre.Controls.Add(this.CmbPaquetesPredefinidos);
            this.PnlDatosPaquetePre.Controls.Add(this.LblNombrePaquetePredefinido);
            this.PnlDatosPaquetePre.Enabled = false;
            this.PnlDatosPaquetePre.Location = new System.Drawing.Point(53, 12);
            this.PnlDatosPaquetePre.Name = "PnlDatosPaquetePre";
            this.PnlDatosPaquetePre.Size = new System.Drawing.Size(768, 152);
            this.PnlDatosPaquetePre.TabIndex = 23;
            // 
            // LblDestallesPaquetePre
            // 
            this.LblDestallesPaquetePre.AutoSize = true;
            this.LblDestallesPaquetePre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDestallesPaquetePre.Location = new System.Drawing.Point(29, 68);
            this.LblDestallesPaquetePre.Name = "LblDestallesPaquetePre";
            this.LblDestallesPaquetePre.Size = new System.Drawing.Size(60, 15);
            this.LblDestallesPaquetePre.TabIndex = 24;
            this.LblDestallesPaquetePre.Text = "Detalles";
            // 
            // PnlDetallesPaquetePre
            // 
            this.PnlDetallesPaquetePre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDetallesPaquetePre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PnlDetallesPaquetePre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDetallesPaquetePre.Controls.Add(this.RtxDetallesPaquetePre);
            this.PnlDetallesPaquetePre.Location = new System.Drawing.Point(3, 79);
            this.PnlDetallesPaquetePre.Name = "PnlDetallesPaquetePre";
            this.PnlDetallesPaquetePre.Size = new System.Drawing.Size(760, 72);
            this.PnlDetallesPaquetePre.TabIndex = 25;
            // 
            // RtxDetallesPaquetePre
            // 
            this.RtxDetallesPaquetePre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxDetallesPaquetePre.Location = new System.Drawing.Point(3, 11);
            this.RtxDetallesPaquetePre.Name = "RtxDetallesPaquetePre";
            this.RtxDetallesPaquetePre.Size = new System.Drawing.Size(750, 51);
            this.RtxDetallesPaquetePre.TabIndex = 26;
            this.RtxDetallesPaquetePre.Text = "";
            // 
            // CmbPaquetesPredefinidos
            // 
            this.CmbPaquetesPredefinidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbPaquetesPredefinidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPaquetesPredefinidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbPaquetesPredefinidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbPaquetesPredefinidos.FormattingEnabled = true;
            this.CmbPaquetesPredefinidos.Location = new System.Drawing.Point(106, 29);
            this.CmbPaquetesPredefinidos.Name = "CmbPaquetesPredefinidos";
            this.CmbPaquetesPredefinidos.Size = new System.Drawing.Size(625, 24);
            this.CmbPaquetesPredefinidos.TabIndex = 4;
            this.CmbPaquetesPredefinidos.SelectedValueChanged += new System.EventHandler(this.CmbPaquetesPredefinidos_SelectedValueChanged);
            this.CmbPaquetesPredefinidos.TextChanged += new System.EventHandler(this.CmbPaquetesPredefinidos_TextChanged);
            // 
            // LblNombrePaquetePredefinido
            // 
            this.LblNombrePaquetePredefinido.AutoSize = true;
            this.LblNombrePaquetePredefinido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePaquetePredefinido.Location = new System.Drawing.Point(29, 32);
            this.LblNombrePaquetePredefinido.Name = "LblNombrePaquetePredefinido";
            this.LblNombrePaquetePredefinido.Size = new System.Drawing.Size(71, 16);
            this.LblNombrePaquetePredefinido.TabIndex = 23;
            this.LblNombrePaquetePredefinido.Text = "Nombres";
            // 
            // LblDatosDelUsuario
            // 
            this.LblDatosDelUsuario.AutoSize = true;
            this.LblDatosDelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosDelUsuario.Location = new System.Drawing.Point(62, 61);
            this.LblDatosDelUsuario.Name = "LblDatosDelUsuario";
            this.LblDatosDelUsuario.Size = new System.Drawing.Size(137, 15);
            this.LblDatosDelUsuario.TabIndex = 23;
            this.LblDatosDelUsuario.Text = "Paquete predefinido";
            // 
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(875, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCotizacion";
            this.Text = "FrmCotizacion";
            this.Load += new System.EventHandler(this.FrmCotizacion_Load);
            this.Enter += new System.EventHandler(this.FrmCotizacion_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvServiciosDelPaquete)).EndInit();
            this.PnlPaquetePersonalizado.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PnlPaquetePredefinido.ResumeLayout(false);
            this.PnlDatosPaquetePre.ResumeLayout(false);
            this.PnlDatosPaquetePre.PerformLayout();
            this.PnlDetallesPaquetePre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblDatosDelUsuario;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnCotizar;
        private System.Windows.Forms.Button BtnPersonalizar;
        private System.Windows.Forms.Panel PnlPaquetePersonalizado;
        private System.Windows.Forms.Panel PnlPaquetePredefinido;
        private System.Windows.Forms.Panel PnlDatosPaquetePre;
        private System.Windows.Forms.Label LblDestallesPaquetePre;
        private System.Windows.Forms.Panel PnlDetallesPaquetePre;
        private System.Windows.Forms.RichTextBox RtxDetallesPaquetePre;
        private System.Windows.Forms.ComboBox CmbPaquetesPredefinidos;
        private System.Windows.Forms.Label LblNombrePaquetePredefinido;
        private System.Windows.Forms.DataGridView DgvServiciosDelPaquete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCotizacion;
    }
}