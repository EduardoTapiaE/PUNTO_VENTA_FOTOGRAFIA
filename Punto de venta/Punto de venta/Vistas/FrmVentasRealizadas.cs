using Punto_de_venta.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Vistas
{
    public partial class FrmVentasRealizadas : Form
    {
        int correosEnviados =0;
        DataTable tablaVentasSinOpinion = new DataTable();
        VentaController ctlerVenta = new VentaController();
        MailMessage objMailMessage = new MailMessage();
        SmtpClient objSmtpClient = new SmtpClient();
        public FrmVentasRealizadas()
        {
            InitializeComponent();
        }

        private void FrmVentasRealizadas_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgvs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActualizarDgvs()
        {
            DgvVentasRealizadas.DataSource = ctlerVenta.GetTablaVenta();
            tablaVentasSinOpinion = ctlerVenta.ConvertirListaDeVentasAFormatoDataTable(ctlerVenta.GetTablaVentaPorCorreoOpinionClienteEnviado("0"));
            DgvVentasSinOpinion.DataSource = tablaVentasSinOpinion;
        }

        private void BtnMandarEncuesta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!BgwMandarEncuestas.IsBusy)
                {
                    ActivarGifProcesoEnEjecucion();
                    BgwMandarEncuestas.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Proceso en ejecucion");
                }

            }
            catch (Exception ex)
            {
                DesactivarGifProcesoEnEjecucion();
                MessageBox.Show(ex.Message);
            }
        }
        private void DesactivarGifProcesoEnEjecucion()
        {
            PicProcesando.Enabled = false;
            PicProcesando.Visible = false;
        }
        private void ActivarGifProcesoEnEjecucion()
        {
            PicProcesando.Enabled = true;
            PicProcesando.Visible = true;
        }

        private void BgwMandarEncuestas_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                correosEnviados = 0;
                foreach (DataRow dr in tablaVentasSinOpinion.Rows)
                {
                    if (dr["Id venta"].ToString() != "" && dr["Correo"].ToString() != "")
                    {
                        string _correoemisor = "ejemplomandarcorreocsharp@gmail.com",
                                   _correoreceptor = dr["Correo"].ToString(),
                                   _contraseña = "",
                                   _host = "smtp.gmail.com",
                                   _asunto = "FOTOGRAFIA Y VIDEO : Queremos saber su opinion sobre nuestros servicios",
                                   _mensaje = "Entre al siguiente link para contestar la encuesta sobre nuestro servicio";
                        int _puerto = 587;
                        bool _ssl = true;
                        EnviarCorreo(_correoemisor, _contraseña, _host, _puerto, _ssl, _correoreceptor, _asunto, _mensaje);
                        correosEnviados++;
                        ctlerVenta.ModificarCorreoOpinionClienteEnviado(dr["Id venta"].ToString(), "1");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BgwMandarEncuestas_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DesactivarGifProcesoEnEjecucion();
            MessageBox.Show("Encuestas enviadas: "+correosEnviados.ToString());
            ActualizarDgvs();

        }

        private void EnviarCorreo(string _emisor, string _contraseña, string _host, int _puerto, bool _ssl, string _destinatario, string _asunto, string _mensaje)
        {
            try
            {
                objMailMessage = new MailMessage(_emisor, _destinatario, _asunto, _mensaje);
                objMailMessage.IsBodyHtml = true;

                objSmtpClient = new SmtpClient(_host);
                objSmtpClient.EnableSsl = _ssl;
                objSmtpClient.UseDefaultCredentials = false;
                objSmtpClient.Host = _host;
                objSmtpClient.Port = _puerto;
                objSmtpClient.Credentials = new NetworkCredential(_emisor, _contraseña);
                objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                objSmtpClient.Timeout = 20000;
                objSmtpClient.Send(objMailMessage);
                objSmtpClient.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar correo\n" + ex.Message);
            }
        }
    }
}
