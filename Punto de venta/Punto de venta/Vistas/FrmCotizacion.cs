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

        private void FrmCotizacion_Load(object sender, EventArgs e)
        {
           
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                PnlDatosPaquetePre.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

        private void FrmCotizacion_Enter(object sender, EventArgs e)
        {
            try
            {
                LLenarCmbPaquetesPredefinidos();
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
                if (PnlPaquetePredefinido.Visible)
                {
                    if (CmbPaquetesPredefinidos.SelectedValue != null)
                    {
                        DataTable _serviciosdelpaquete = ctlerServicio.ConvertirListaDeServiciosAFormatoDataTable(serviciosDelPaquete);
                        if (_serviciosdelpaquete.Rows.Count > 0)
                        {
                            double _cotizacion = 0;
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

                            TxtCotizacion.Text = _cotizacion.ToString();
                        }
                    }
                }
                else
                { 
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
                if (PnlPaquetePredefinido.Visible)
                {
                    if (TxtCotizacion.Text != "")
                    {
                        string _id = ctlerCotizacion.AgregarCotizacion(TxtCotizacion.Text, serviciosDelPaquete);
                        MessageBox.Show("Datos agregados");
                        LimpiarCampos();
                        DialogResult _respuesta = MessageBox.Show("¿Desea realizar venta de la cotizacion?","Venta",MessageBoxButtons.YesNo);
                        if (_respuesta == DialogResult.Yes)
                        {
                            FrmMenuPrincipal _formularioabierto = Application.OpenForms.OfType<FrmMenuPrincipal>().Where(pre => pre.Name == "FrmMenuPrincipal").SingleOrDefault();
                            if (_formularioabierto != null)
                            {
                                _formularioabierto.AbrirFormulario(new FrmVenta(_id));
                                _formularioabierto.CambiarNombreTitulo("VENTA");
                            }
                        }
                    }
                   
                }
                else if (PnlPaquetePersonalizado.Visible)
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            CmbPaquetesPredefinidos.SelectedIndex = -1;
        }
    }
}
