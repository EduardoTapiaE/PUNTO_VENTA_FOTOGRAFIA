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
    public partial class FrmVenta : Form
    {
        CotizacionController ctlerCotizacion = new CotizacionController();
        ServicioController ctlerServicio = new ServicioController();
        VentaController ctlerVenta = new VentaController();
        List<Modelos.Servicio> serviciosDelPaquete = new List<Modelos.Servicio>();
        string idCotizacion = "";
        public FrmVenta(string idcotizacion)
        {
            idCotizacion = idcotizacion;
            InitializeComponent();
        }

        private void ObtenerDatosDeCotizacion(string id)
        {
            var _datoscotizacion = ctlerCotizacion.GetCotizacion(id);
            TxtNombres.Text = _datoscotizacion.nombrescliente;
            TxtApellidos.Text = _datoscotizacion.apellidoscliente;
            TxtImporte.Text = _datoscotizacion.importe;
            TxtSaldo.Text = _datoscotizacion.importe;
            serviciosDelPaquete = _datoscotizacion.servicios;
            DgvServiciosVenta.DataSource = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCmbIdCotizacion();
                CmbIdCotizacion.Select();
                if (idCotizacion != "")
                {
                    CmbIdCotizacion.SelectedValue = idCotizacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmVenta_Enter(object sender, EventArgs e)
        {
           
           
        }

        private void LlenarCmbIdCotizacion()
        {
         
            DataTable _tablaCotizaciones = ctlerCotizacion.ConvertirListaDeCotizacionesAFormatoDataTable(ctlerCotizacion.GetTablaCotizaciones());
            CmbIdCotizacion.ValueMember = "Id";
            CmbIdCotizacion.DisplayMember = "Id";
            CmbIdCotizacion.DataSource = _tablaCotizaciones;
            CmbIdCotizacion.Text = "";
            CmbIdCotizacion.SelectedValue = "-1";
        }

        private void CmbIdCotizacion_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbIdCotizacion.SelectedValue != null)
                {
                    ObtenerDatosDeCotizacion(CmbIdCotizacion.SelectedValue.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbTipoVenta.SelectedIndex == 0)
                {
                    MessageBox.Show("NO HAY TERMINAL COMPA JIJUESU");
                }
                else if (CmbTipoVenta.SelectedIndex == 1)
                {
                    string _fevento = DtpFEvento.Value.ToString("yyyy-MM-dd"),
                           _hevento = DtpHEvento.Value.ToString("hh:mm:ss"),
                           _fentrega = DtpFEntrega.Value.ToString("yyyy-MM-dd"),
                           _hentrega = DtpHEntrega.Value.ToString("hh:mm:ss");
                    #region REALIZAR VENTA
                    string _idventa = ctlerVenta.AgregarVenta(CmbIdCotizacion.Text,
                                                            TxtNombres.Text,
                                                            TxtApellidos.Text,
                                                            TxtDomicilio.Text,
                                                            TxtTelefono.Text,
                                                            TxtCorreo.Text,
                                                            _fevento,
                                                            _hevento,
                                                            _fentrega,
                                                            _hentrega,
                                                            TxtImporte.Text,
                                                            "1",
                                                            CmbTipoVenta.Text);
                    #endregion
                    //GUARDAR PAGO

                    MessageBox.Show("Y LOS BILLETES? COMO DICE EL COMPA JOSH\nIdventa: "+_idventa);
                }
                else 
                {
                    MessageBox.Show("Y ESE FALLO VIEJON? NO SELECCIONO EL TIPO DE VENTA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
