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
    public partial class FrmTransferencia : Form
    {
        PagoController ctlerPago = new PagoController();
        public string montoPago = "";
        public FrmTransferencia(string monto)
        {
            montoPago = monto;
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                HacerTranferencia();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void HacerTranferencia()
        {
            try
            {
                Comprobante comprobante = await ctlerPago.Transferencia(7751610255668537, Convert.ToDecimal(montoPago), Convert.ToInt64(TxtTarjeta.Text), Convert.ToInt32(TxtNoVerificadores.Text), TxtFechaVencimiento.Text);
                if (comprobante.Id_Transaccion.ToString() != "0")
                {
                    MessageBox.Show("Id: " + comprobante.Id_Transaccion.ToString() +
                    " Fecha: " + comprobante.Fecha.ToString() +
                    " Mensaje: " + comprobante.Mensaje.ToString());
                    Close();
                    RegresarEstadoDeTransferenciaAFormVenta(true);
                }
                else
                {
                    RegresarEstadoDeTransferenciaAFormVenta(false);
                    throw new Exception("Erorr: No se pudo completar la transferencia\n" + comprobante.Mensaje.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void RegresarEstadoDeTransferenciaAFormVenta(bool resultado)
        {
            FrmVenta _formularioabierto = Application.OpenForms.OfType<FrmVenta>().Where(pre => pre.Name == "FrmVenta").SingleOrDefault();
            if (_formularioabierto != null)
            {
                _formularioabierto.transferenciaExitosa = resultado;
            }
        }

        private void FrmTransferencia_Load(object sender, EventArgs e)
        {
            TxtMonto.Text = montoPago;
        }

        private void TxtFechaVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
