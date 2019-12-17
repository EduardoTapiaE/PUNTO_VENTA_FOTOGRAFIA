using Punto_de_venta.Reportes;
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
    public partial class FrmVisualizarReportes : Form
    {
        public ComprobanteCotizacion datosComprobanteCotizacion = new ComprobanteCotizacion();
        string tipoComprobante = "";
        public FrmVisualizarReportes(string tipocomprobante)
        {
            tipoComprobante = tipocomprobante;
            InitializeComponent();
        }

        private void FrmVisualizarReportes_Load(object sender, EventArgs e)
        {
            try
            {
                AbrirComprobanteSegunTipo(tipoComprobante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AbrirComprobanteSegunTipo(string tipo)
        {
            switch (tipo)
            {
                case "COTIZACION":
                    RpdCotizacion _cotizacion = new RpdCotizacion();
                    _cotizacion.SetDataSource(datosComprobanteCotizacion.listaServicios);
                    crvVisualizarReporte.ReportSource = _cotizacion;
                    _cotizacion.SetParameterValue("paramIdCotizacion", datosComprobanteCotizacion.idCotizacion);
                    _cotizacion.SetParameterValue("paramCliente", datosComprobanteCotizacion.cliente);
                    _cotizacion.SetParameterValue("paramFecha", datosComprobanteCotizacion.fecha);
                    _cotizacion.SetParameterValue("paramMontoInicial", datosComprobanteCotizacion.montoInicial);
                    _cotizacion.SetParameterValue("paramIva", datosComprobanteCotizacion.iva);
                    _cotizacion.SetParameterValue("paramMontoFinal", datosComprobanteCotizacion.montoFinal);
                    crvVisualizarReporte.Refresh();
                   
                    break;
            }
        }
    }
}
