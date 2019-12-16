namespace Punto_de_venta.Vistas
{
    partial class FrmTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferencia));
            this.PnlDatosDelUsuario = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.LblMonto = new System.Windows.Forms.Label();
            this.TxtTarjeta = new System.Windows.Forms.TextBox();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.TxtNoVerificadores = new System.Windows.Forms.TextBox();
            this.LblNoVerificadores = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.LblFechaVencimiento = new System.Windows.Forms.Label();
            this.PnlDatosDelUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDatosDelUsuario
            // 
            this.PnlDatosDelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.PnlDatosDelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlDatosDelUsuario.Controls.Add(this.panel3);
            this.PnlDatosDelUsuario.Location = new System.Drawing.Point(12, 12);
            this.PnlDatosDelUsuario.Name = "PnlDatosDelUsuario";
            this.PnlDatosDelUsuario.Size = new System.Drawing.Size(373, 150);
            this.PnlDatosDelUsuario.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtFechaVencimiento);
            this.panel3.Controls.Add(this.LblFechaVencimiento);
            this.panel3.Controls.Add(this.TxtMonto);
            this.panel3.Controls.Add(this.LblMonto);
            this.panel3.Controls.Add(this.TxtTarjeta);
            this.panel3.Controls.Add(this.LblTarjeta);
            this.panel3.Controls.Add(this.TxtNoVerificadores);
            this.panel3.Controls.Add(this.LblNoVerificadores);
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 131);
            this.panel3.TabIndex = 44;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Enabled = false;
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(175, 96);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(179, 22);
            this.TxtMonto.TabIndex = 33;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(56, 99);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(108, 16);
            this.LblMonto.TabIndex = 34;
            this.LblMonto.Text = "Monto a pagar";
            // 
            // TxtTarjeta
            // 
            this.TxtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTarjeta.Location = new System.Drawing.Point(175, 9);
            this.TxtTarjeta.Name = "TxtTarjeta";
            this.TxtTarjeta.Size = new System.Drawing.Size(179, 22);
            this.TxtTarjeta.TabIndex = 0;
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTarjeta.Location = new System.Drawing.Point(30, 12);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(134, 16);
            this.LblTarjeta.TabIndex = 23;
            this.LblTarjeta.Text = "Tarjeta del cliente";
            // 
            // TxtNoVerificadores
            // 
            this.TxtNoVerificadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoVerificadores.Location = new System.Drawing.Point(175, 39);
            this.TxtNoVerificadores.Name = "TxtNoVerificadores";
            this.TxtNoVerificadores.Size = new System.Drawing.Size(179, 22);
            this.TxtNoVerificadores.TabIndex = 31;
            // 
            // LblNoVerificadores
            // 
            this.LblNoVerificadores.AutoSize = true;
            this.LblNoVerificadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNoVerificadores.Location = new System.Drawing.Point(4, 42);
            this.LblNoVerificadores.Name = "LblNoVerificadores";
            this.LblNoVerificadores.Size = new System.Drawing.Size(165, 16);
            this.LblNoVerificadores.TabIndex = 32;
            this.LblNoVerificadores.Text = "Numeros verificadores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Datos del cliente";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAceptar.Location = new System.Drawing.Point(290, 168);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(95, 36);
            this.BtnAceptar.TabIndex = 49;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtFechaVencimiento
            // 
            this.TxtFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaVencimiento.Location = new System.Drawing.Point(175, 68);
            this.TxtFechaVencimiento.Name = "TxtFechaVencimiento";
            this.TxtFechaVencimiento.Size = new System.Drawing.Size(179, 22);
            this.TxtFechaVencimiento.TabIndex = 37;
            this.TxtFechaVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFechaVencimiento_KeyPress);
            // 
            // LblFechaVencimiento
            // 
            this.LblFechaVencimiento.AutoSize = true;
            this.LblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaVencimiento.Location = new System.Drawing.Point(26, 71);
            this.LblFechaVencimiento.Name = "LblFechaVencimiento";
            this.LblFechaVencimiento.Size = new System.Drawing.Size(138, 16);
            this.LblFechaVencimiento.TabIndex = 38;
            this.LblFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // FrmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 214);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PnlDatosDelUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pago a credito";
            this.Load += new System.EventHandler(this.FrmTransferencia_Load);
            this.PnlDatosDelUsuario.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlDatosDelUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtTarjeta;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.TextBox TxtNoVerificadores;
        private System.Windows.Forms.Label LblNoVerificadores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtFechaVencimiento;
        private System.Windows.Forms.Label LblFechaVencimiento;
    }
}