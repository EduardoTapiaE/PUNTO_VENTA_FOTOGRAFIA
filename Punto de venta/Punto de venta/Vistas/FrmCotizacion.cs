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
    public partial class FrmCotizacion : Form
    {
        CotizacionController ctlerCotizacion = new CotizacionController();
        PaqueteController ctlerPaquete = new PaqueteController();
        ServicioController ctlerServicio = new ServicioController();
        List<Modelos.Servicio> serviciosDelPaquete = new List<Modelos.Servicio>();
        
        public FrmCotizacion()
        {
            InitializeComponent();
        }


        private void ObtenerDatosDeCotizacion(string id)
        {
            var _datoscotizacion = ctlerCotizacion.GetCotizacion(id);
            TxtNombres.Text = _datoscotizacion.nombrescliente;
            TxtApellidos.Text = _datoscotizacion.apellidoscliente;
            serviciosDelPaquete = _datoscotizacion.servicios;
            DgvServiciosDelPaquete.DataSource = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);
        }
        private void GenerarCotizacion()
        {
            if (PnlPaquetePredefinido.Visible)
            {
                DataTable _serviciosdelpaquete = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);
                if (_serviciosdelpaquete.Rows.Count > 0)
                {
                    double _cotizacion = 0, _impuesto = 0;
                    foreach (DataRow dr in _serviciosdelpaquete.Rows)
                    {
                        if (dr["Unitario"].ToString() == "0")
                        {
                            if (dr["Costo"].ToString() != "0" && dr["Cantidad"].ToString() != "0")
                            {
                                double _costo = Convert.ToDouble(dr["Costo"].ToString());
                                int _cantidad = Convert.ToInt32(dr["Cantidad"].ToString());

                                _cotizacion += _costo * _cantidad;
                            }
                        }
                        else
                        {
                            if (dr["Costo"].ToString() != "0")
                            {
                                double _costo = Convert.ToDouble(dr["Costo"].ToString());
                                _cotizacion += _costo;
                            }
                        }

                    }
                    _impuesto = _cotizacion * 0.16;
                    TxtMontoInicial.Text = _cotizacion.ToString();
                    TxtIVA.Text = _impuesto.ToString();
                    TxtCotizacion.Text =Convert.ToString(_cotizacion + _impuesto);
                }
            }
            else
            {
            }
        }
        private void GuardarCotizacion()
        {
            if (PnlPaquetePredefinido.Visible)
            {
                if (TxtCotizacion.Text != "")
                {
                    string _id = ctlerCotizacion.AgregarCotizacion(TxtCotizacion.Text,TxtNombres.Text,TxtApellidos.Text, serviciosDelPaquete);
                   // MessageBox.Show(string.Format("Id de cotizacion: {0}\nCotizacion realizada para el cleinte {1} {2}\nImporte: {3}",_id, TxtNombres.Text,TxtApellidos.Text,TxtCotizacion.Text));
                    FrmVisualizarReportes _form = new FrmVisualizarReportes("COTIZACION");
                    _form.datosComprobanteCotizacion.idCotizacion = _id;
                    _form.datosComprobanteCotizacion.cliente = string.Format("{0} {1}",TxtNombres.Text,TxtApellidos.Text);
                    _form.datosComprobanteCotizacion.fecha = string.Format("HERMOSILLO,SONORA {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    _form.datosComprobanteCotizacion.montoInicial = TxtMontoInicial.Text;
                    _form.datosComprobanteCotizacion.iva = TxtIVA.Text;
                    _form.datosComprobanteCotizacion.montoFinal = TxtCotizacion.Text;
                    _form.datosComprobanteCotizacion.listaServicios = serviciosDelPaquete;
                    _form.ShowDialog();
                    LimpiarCampos();
                    ValidarSiSeHaraLaVentaDeLaCotizacion(_id);
                }

            }
            else if (PnlPaquetePersonalizado.Visible)
            {

            }
        }
        private void ValidarSiSeHaraLaVentaDeLaCotizacion(string id)
        {
            DialogResult _respuesta = MessageBox.Show("¿Desea realizar venta de la cotizacion?", "Venta", MessageBoxButtons.YesNo);
            if (_respuesta == DialogResult.Yes)
            {
                FrmMenuPrincipal _formularioabierto = Application.OpenForms.OfType<FrmMenuPrincipal>().Where(pre => pre.Name == "FrmMenuPrincipal").SingleOrDefault();
                if (_formularioabierto != null)
                {
                    _formularioabierto.AbrirFormulario(new FrmVenta(id));
                    _formularioabierto.CambiarNombreTitulo("VENTA");
                }
            }
        }
        private void LimpiarCampos()
        {
            CmbPaquetesPredefinidos.SelectedIndex = -1;
            TxtApellidos.Text = "";
            TxtNombres.Text = "";
            TxtCotizacion.Text = "";
            TxtIVA.Text = "";
            TxtMontoInicial.Text = "";
            PnlDatosPaquetePre.Enabled = false;
            CmbCotizacionesGuardadas.Enabled = true;
        }
        private void FrmCotizacion_Shown(object sender, EventArgs e)
        {
            try
            {
                LLenarCmbPaquetesPredefinidos();
                LlenarCmbCotizacionesGuardadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region LLENARCOMBOBOX
        private void LlenarCmbCotizacionesGuardadas()
        {
            DataTable _tablacotizaciones = ctlerCotizacion.ConvertirListaDeCotizacionesAFormatoDataTable(ctlerCotizacion.GetTablaCotizaciones());
            CmbCotizacionesGuardadas.ValueMember = "Id";
            CmbCotizacionesGuardadas.DisplayMember = "Id";
            CmbCotizacionesGuardadas.DataSource = _tablacotizaciones;
            CmbCotizacionesGuardadas.Text = "";
            CmbCotizacionesGuardadas.SelectedValue = "-1";
        }
        private void LLenarCmbPaquetesPredefinidos()
        {
            DataTable _tablapaquetespredefinidos = ctlerPaquete.GetTablaPaquetesPredefinidosEnFormatoDataTable();
            CmbPaquetesPredefinidos.ValueMember = "Id";
            CmbPaquetesPredefinidos.DisplayMember = "Nombre";
            CmbPaquetesPredefinidos.DataSource = _tablapaquetespredefinidos;
            CmbPaquetesPredefinidos.Text = "";
            CmbPaquetesPredefinidos.SelectedValue = "-1";
        }
        #endregion

        #region BUTTON
        private void BtnPersonalizar_Click(object sender, EventArgs e)
        {
            if (PnlPaquetePredefinido.Visible)
            {
                PnlPaquetePredefinido.Visible = false;
                PnlPaquetePersonalizado.Visible = true;
                BtnPersonalizar.Text = "Predefinido";
            }
            else if (PnlPaquetePersonalizado.Visible)
            {
                PnlPaquetePersonalizado.Visible = false;
                PnlPaquetePredefinido.Visible = true;
                BtnPersonalizar.Text = "Personalizar";
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                CmbCotizacionesGuardadas.Enabled = false;
                PnlDatosPaquetePre.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCotizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (PnlDatosPaquetePre.Enabled)
                {
                    GenerarCotizacion();
                    GuardarCotizacion();
                    LlenarCmbCotizacionesGuardadas();
                }
                else
                {

                    ObtenerDatosDeCotizacion(CmbCotizacionesGuardadas.SelectedValue.ToString());
                    GenerarCotizacion();
                    ValidarSiSeHaraLaVentaDeLaCotizacion(CmbCotizacionesGuardadas.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarCotizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region COMBOBOX
        private void CmbPaquetesPredefinidos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbPaquetesPredefinidos.SelectedValue != null)
                {
                    TxtCotizacion.Text = "";
                    string _idpaquete = CmbPaquetesPredefinidos.SelectedValue.ToString();
                    var _paquete = ctlerPaquete.GetPaquetePredefinidoPorId(_idpaquete);
                    RtxDetallesPaquetePre.Text = _paquete.detalles;
                    serviciosDelPaquete = _paquete.servicios;
                    DgvServiciosDelPaquete.DataSource = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CmbPaquetesPredefinidos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbPaquetesPredefinidos.SelectedValue == null)
                {
                    RtxDetallesPaquetePre.Text = "";
                    DgvServiciosDelPaquete.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TEXTBOX
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
        #endregion

        private void CmbCotizacionesGuardadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
