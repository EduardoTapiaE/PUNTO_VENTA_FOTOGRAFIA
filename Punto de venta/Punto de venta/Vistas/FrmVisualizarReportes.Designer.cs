namespace Punto_de_venta.Vistas
{
    partial class FrmVisualizarReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizarReportes));
            this.crvVisualizarReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVisualizarReporte
            // 
            this.crvVisualizarReporte.ActiveViewIndex = -1;
            this.crvVisualizarReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVisualizarReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVisualizarReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVisualizarReporte.Location = new System.Drawing.Point(0, 0);
            this.crvVisualizarReporte.Name = "crvVisualizarReporte";
            this.crvVisualizarReporte.ShowCloseButton = false;
            this.crvVisualizarReporte.ShowGroupTreeButton = false;
            this.crvVisualizarReporte.ShowLogo = false;
            this.crvVisualizarReporte.ShowParameterPanelButton = false;
            this.crvVisualizarReporte.ShowRefreshButton = false;
            this.crvVisualizarReporte.Size = new System.Drawing.Size(800, 508);
            this.crvVisualizarReporte.TabIndex = 1;
            this.crvVisualizarReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmVisualizarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.crvVisualizarReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisualizarReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comprobante";
            this.Load += new System.EventHandler(this.FrmVisualizarReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVisualizarReporte;
    }
}