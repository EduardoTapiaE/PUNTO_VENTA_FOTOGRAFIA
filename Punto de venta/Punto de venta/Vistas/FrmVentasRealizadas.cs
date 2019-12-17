using Punto_de_venta.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Vistas
{
    public partial class FrmVentasRealizadas : Form
    {
        VentaController ctlerVenta = new VentaController();
        public FrmVentasRealizadas()
        {
            InitializeComponent();
        }

        private void FrmVentasRealizadas_Load(object sender, EventArgs e)
        {
            try
            {
                DgvVentasRealizadas.DataSource = ctlerVenta.GetTablaVenta();
                DgvVentasSinOpinion.DataSource = ctlerVenta.GetTablaVentaPorCorreoOpinionClienteEnviado("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnMandarEncuesta_Click(object sender, EventArgs e)
        {
           
        }
    }
}
