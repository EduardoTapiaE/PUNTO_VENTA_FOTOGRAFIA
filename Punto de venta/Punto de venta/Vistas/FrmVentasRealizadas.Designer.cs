namespace Punto_de_venta.Vistas
{
    partial class FrmVentasRealizadas
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
            this.BtnMandarEncuesta = new System.Windows.Forms.Button();
            this.DgvVentasRealizadas = new System.Windows.Forms.DataGridView();
            this.LblVentasRealizadas = new System.Windows.Forms.Label();
            this.PnlVentasRealizadas = new System.Windows.Forms.Panel();
            this.LblVentasSinOpinion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvVentasSinOpinion = new System.Windows.Forms.DataGridView();
            this.BgwMandarEncuestas = new System.ComponentModel.BackgroundWorker();
            this.PicProcesando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentasRealizadas)).BeginInit();
            this.PnlVentasRealizadas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentasSinOpinion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMandarEncuesta
            // 
            this.BtnMandarEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
            this.BtnMandarEncuesta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMandarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMandarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMandarEncuesta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMandarEncuesta.Location = new System.Drawing.Point(624, 235);
            this.BtnMandarEncuesta.Name = "BtnMandarEncuesta";
            this.BtnMandarEncuesta.Size = new System.Drawing.Size(139, 36);
            this.BtnMandarEncuesta.TabIndex = 47;
            this.BtnMandarEncuesta.Text = "Mandar encuesta";
            this.BtnMandarEncuesta.UseVisualStyleBackColor = false;
            this.BtnMandarEncuesta.Click += new System.EventHandler(this.BtnMandarEncuesta_Click);
            // 
            // DgvVentasRealizadas
            // 
            this.DgvVentasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentasRealizadas.Location = new System.Drawing.Point(3, 8);
            this.DgvVentasRealizadas.Name = "DgvVentasRealizadas";
            this.DgvVentasRealizadas.Size = new System.Drawing.Size(760, 220);
            this.DgvVentasRealizadas.TabIndex = 49;
            // 
            // LblVentasRealizadas
            // 
            this.LblVentasRealizadas.AutoSize = true;
            this.LblVentasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVentasRealizadas.Location = new System.Drawing.Point(57, 19);
            this.LblVentasRealizadas.Name = "LblVentasRealizadas";
            this.LblVentasRealizadas.Size = new System.Drawing.Size(121, 15);
            this.LblVentasRealizadas.TabIndex = 51;
            this.LblVentasRealizadas.Text = "Ventas realizadas";
            // 
            // PnlVentasRealizadas
            // 
            this.PnlVentasRealizadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.PnlVentasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlVentasRealizadas.Controls.Add(this.DgvVentasRealizadas);
            this.PnlVentasRealizadas.Location = new System.Drawing.Point(40, 28);
            this.PnlVentasRealizadas.Name = "PnlVentasRealizadas";
            this.PnlVentasRealizadas.Size = new System.Drawing.Size(768, 233);
            this.PnlVentasRealizadas.TabIndex = 50;
            // 
            // LblVentasSinOpinion
            // 
            this.LblVentasSinOpinion.AutoSize = true;
            this.LblVentasSinOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVentasSinOpinion.Location = new System.Drawing.Point(57, 271);
            this.LblVentasSinOpinion.Name = "LblVentasSinOpinion";
            this.LblVentasSinOpinion.Size = new System.Drawing.Size(196, 15);
            this.LblVentasSinOpinion.TabIndex = 53;
            this.LblVentasSinOpinion.Text = "Ventas sin opinion del cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DgvVentasSinOpinion);
            this.panel1.Controls.Add(this.BtnMandarEncuesta);
            this.panel1.Controls.Add(this.PicProcesando);
            this.panel1.Location = new System.Drawing.Point(40, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 276);
            this.panel1.TabIndex = 52;
            // 
            // DgvVentasSinOpinion
            // 
            this.DgvVentasSinOpinion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentasSinOpinion.Location = new System.Drawing.Point(3, 8);
            this.DgvVentasSinOpinion.Name = "DgvVentasSinOpinion";
            this.DgvVentasSinOpinion.Size = new System.Drawing.Size(760, 220);
            this.DgvVentasSinOpinion.TabIndex = 49;
            // 
            // BgwMandarEncuestas
            // 
            this.BgwMandarEncuestas.WorkerReportsProgress = true;
            this.BgwMandarEncuestas.WorkerSupportsCancellation = true;
            this.BgwMandarEncuestas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwMandarEncuestas_DoWork);
            this.BgwMandarEncuestas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwMandarEncuestas_RunWorkerCompleted);
            // 
            // PicProcesando
            // 
            this.PicProcesando.Enabled = false;
            this.PicProcesando.Image = global::Punto_de_venta.Properties.Resources.procesando;
            this.PicProcesando.Location = new System.Drawing.Point(548, 221);
            this.PicProcesando.Name = "PicProcesando";
            this.PicProcesando.Size = new System.Drawing.Size(90, 61);
            this.PicProcesando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProcesando.TabIndex = 50;
            this.PicProcesando.TabStop = false;
            this.PicProcesando.Visible = false;
            // 
            // FrmVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(875, 607);
            this.Controls.Add(this.LblVentasSinOpinion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblVentasRealizadas);
            this.Controls.Add(this.PnlVentasRealizadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmVentasRealizadas";
            this.Load += new System.EventHandler(this.FrmVentasRealizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentasRealizadas)).EndInit();
            this.PnlVentasRealizadas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentasSinOpinion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicProcesando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMandarEncuesta;
        private System.Windows.Forms.DataGridView DgvVentasRealizadas;
        private System.Windows.Forms.Label LblVentasRealizadas;
        private System.Windows.Forms.Panel PnlVentasRealizadas;
        private System.Windows.Forms.Label LblVentasSinOpinion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvVentasSinOpinion;
        private System.ComponentModel.BackgroundWorker BgwMandarEncuestas;
        private System.Windows.Forms.PictureBox PicProcesando;
    }
}