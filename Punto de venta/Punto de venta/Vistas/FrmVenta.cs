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
        PagoController ctlerPago = new PagoController();
        List<Modelos.Servicio> serviciosDelPaquete = new List<Modelos.Servicio>();
        string idCotizacion = "";
        double saldoinicial = 0;
        public bool transferenciaExitosa = false;

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
            saldoinicial = Convert.ToDouble(TxtImporte.Text);
            DgvServiciosVenta.DataSource = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                //ASIGNA NUMERO DE CUENTA DE LA EMPRESA
                PagoController.tarjeta.MiTarjeta = 7751610255668537;
                PagoController.tarjeta.Numeros_Verificadores = 451;

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
                transferenciaExitosa = false;
                if (CmbTipoVenta.SelectedIndex == 0)
                {
                    FrmTransferencia _form = new FrmTransferencia(TxtImporte.Text);
                    _form.ShowDialog();
                    if (transferenciaExitosa)
                    {
                        string _idventa = RealizarVenta();
                        string _idpago = GuardarPago(_idventa);
                        MessageBox.Show(string.Format("ID VENTA: {0}\nCLIENTE {1} {2}\nPAGO: {3}\nCAMBIO: {4}", _idventa,TxtNombres.Text,TxtApellidos.Text,TxtPago.Text,TxtCambio.Text));
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO CONCLUIR CON LA VENTA");
                    }
                }
                else if (CmbTipoVenta.SelectedIndex == 1)
                {
                    string _idventa = RealizarVenta();
                    string _idpago = GuardarPago(_idventa);
                }
                else 
                {
                    MessageBox.Show("NO SELECCIONO EL TIPO DE VENTA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GuardarPago(string idventa)
        {
            string _idusuario = UsuarioController.idUsuarioActual,
                   _idventa = idventa, 
                   _importe = TxtPago.Text,
                   _cambio = TxtCambio.Text, 
                   _concepto = "PAGO REALIZADO EN VENTA", 
                   _fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                   _hora = DateTime.Now.ToString("hh:mm:ss"), 
                   _tipopago =CmbTipoVenta.Text,
                   _salodeventa = TxtSaldo.Text,
                   _idpago = "";

            _idpago = ctlerPago.AgregarPago(_idusuario, _idventa, _importe, _cambio, _concepto, _fecha, _hora, _tipopago,_salodeventa);
            return _idpago;
        }

        private string RealizarVenta()
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
            return _idventa;
        }

        private async void HacerTranferencia()
        {
            try
            {
                Comprobante comprobante = await ctlerPago.Transferencia(7751610255668537, Convert.ToDecimal(TxtImporte.Text), 7751610255668537, 451,"");
                if (comprobante.Id_Transaccion.ToString() != "0")
                {
                    MessageBox.Show("Id: " + comprobante.Id_Transaccion.ToString() +
                    " Fecha: " + comprobante.Fecha.ToString() +
                    " Mensaje: " + comprobante.Mensaje.ToString()+
                    "");
                }
                else
                {
                    throw new Exception("Erorr: No se pudo completar la transferencia\n"+ comprobante.Mensaje.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtPago_TextChanged(object sender, EventArgs e)
        {
            double importe = 0;
            if (TxtPago.Text == "" || TxtPago.Text == ".")
            {
                importe = 0;
            }
            else
            {
                importe = Convert.ToDouble(TxtPago.Text);
            }

            double saldo = 0;
            double cambio = 0;
            if (importe < saldoinicial)
            {
                saldo = saldoinicial - importe;
            }
            else
            {
                cambio = importe - saldoinicial;
                saldo = saldoinicial - (importe - cambio);
            }

            TxtSaldo.Text = Convert.ToString(saldo);
            TxtCambio.Text = Convert.ToString(cambio);
        }

        private void CmbTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipoVenta.SelectedIndex == 0)
            {
                TxtPago.Enabled = false;
                TxtPago.Text = TxtImporte.Text;
            }
            else if (CmbTipoVenta.SelectedIndex == 1)
            {
                TxtPago.Text = "0.0";
                TxtPago.Enabled = true;
            }
        }

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && TxtPago.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
            }
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
            }
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }
    }
}
