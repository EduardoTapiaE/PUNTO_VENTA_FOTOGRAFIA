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
            this.LblDatosDelUsuario = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.PnlPaquetePredefinido = new System.Windows.Forms.Panel();
            this.PnlPaquetePersonalizado = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnPersonalizar = new System.Windows.Forms.Button();
            this.BtnCotizar = new System.Windows.Forms.Button();
            this.PnlDatosDelUsuario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CmbNivelDeUsuario = new System.Windows.Forms.ComboBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnlPaquetePredefinido.SuspendLayout();
            this.PnlPaquetePersonalizado.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PnlDatosDelUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            // 
            // PnlPaquetePredefinido
            // 
            this.PnlPaquetePredefinido.Controls.Add(this.PnlDatosDelUsuario);
            this.PnlPaquetePredefinido.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPaquetePredefinido.Location = new System.Drawing.Point(0, 0);
            this.PnlPaquetePredefinido.Name = "PnlPaquetePredefinido";
            this.PnlPaquetePredefinido.Size = new System.Drawing.Size(875, 181);
            this.PnlPaquetePredefinido.TabIndex = 25;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.DgvUsuarios);
            this.panel6.Controls.Add(this.BtnCotizar);
            this.panel6.Controls.Add(this.BtnPersonalizar);
            this.panel6.Controls.Add(this.BtnNuevo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 490);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(875, 284);
            this.panel6.TabIndex = 27;
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
            // 
            // PnlDatosDelUsuario
            // 
            this.PnlDatosDelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PnlDatosDelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDatosDelUsuario.Controls.Add(this.label2);
            this.PnlDatosDelUsuario.Controls.Add(this.panel3);
            this.PnlDatosDelUsuario.Controls.Add(this.CmbNivelDeUsuario);
            this.PnlDatosDelUsuario.Controls.Add(this.LblNombres);
            this.PnlDatosDelUsuario.Enabled = false;
            this.PnlDatosDelUsuario.Location = new System.Drawing.Point(53, 12);
            this.PnlDatosDelUsuario.Name = "PnlDatosDelUsuario";
            this.PnlDatosDelUsuario.Size = new System.Drawing.Size(768, 152);
            this.PnlDatosDelUsuario.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Detalles";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(3, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 72);
            this.panel3.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 51);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // CmbNivelDeUsuario
            // 
            this.CmbNivelDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNivelDeUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbNivelDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.CmbNivelDeUsuario.FormattingEnabled = true;
            this.CmbNivelDeUsuario.Location = new System.Drawing.Point(106, 29);
            this.CmbNivelDeUsuario.Name = "CmbNivelDeUsuario";
            this.CmbNivelDeUsuario.Size = new System.Drawing.Size(625, 24);
            this.CmbNivelDeUsuario.TabIndex = 4;
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
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(53, 19);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(768, 171);
            this.DgvUsuarios.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 144);
            this.dataGridView1.TabIndex = 28;
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 11);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(750, 51);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "";
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
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(570, 11);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(142, 22);
            this.TxtUsuario.TabIndex = 26;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(679, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(572, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cotizar";
            this.button2.UseVisualStyleBackColor = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnlPaquetePredefinido.ResumeLayout(false);
            this.PnlPaquetePersonalizado.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PnlDatosDelUsuario.ResumeLayout(false);
            this.PnlDatosDelUsuario.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PnlDatosDelUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox CmbNivelDeUsuario;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.DataGridView DgvUsuarios;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}