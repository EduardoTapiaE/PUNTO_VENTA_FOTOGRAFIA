using Newtonsoft.Json;
using Punto_de_venta.Modelos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    #region CLASES_API_BANCO
    class DatosTransaccion
    {
        public Int64 Tarjeta_Origen { get; set; }
        public int Numeros_Verificadores { get; set; }
        public Int64 Tarjeta_Destino { get; set; }
        public decimal Monto { get; set; }
    }

    class Comprobante
    {
        public int Id_Transaccion { get; set; }
        public DateTime Fecha { get; set; }
        public string Mensaje { get; set; }
    }

    class Tarjeta
    {
        public Int64 MiTarjeta { get; set; }
        public int Numeros_Verificadores { get; set; }
    }
    #endregion

    class PagoController
    {
        VentaController ctlerVenta = new VentaController();
        PagoModel modelPago = new PagoModel();
        public string AgregarPago(string idusuario,string idventa,string importe,string cambio,string concepto,string fecha,string hora,string tipopago,string saldorestantedeventa)
        {
            string _datosreturn = "";
            Pago _pago = new Pago() 
            {
                idusuario = idusuario,
                idventa = idventa,
                importe = importe,
                cambio= cambio,
                concepto = concepto,
                fecha = fecha,
                hora = hora,
                tipopago = tipopago
            };
            
            _datosreturn = modelPago.NuevoPago(_pago);
            if (_datosreturn != "")
            {
                ctlerVenta.ModificarSaldoVenta(idventa,saldorestantedeventa);
            }
            return _datosreturn;
        }

        #region METODOS_API_BANCO
        public static Tarjeta tarjeta = new Tarjeta();

        public async Task<Comprobante> Transferencia(Int64 tarjetaDestino, decimal monto, Int64 tarjetaOrigen, int noverificadores)
        {
            DatosTransaccion datosTransaccion = new DatosTransaccion
            {
                Tarjeta_Origen = tarjetaOrigen,
                Numeros_Verificadores = noverificadores,
                Tarjeta_Destino = tarjetaDestino,
                Monto = monto
            };

            var baseUrl = "https://bancossoftwarecomplejo.azurewebsites.net";
            var resource = "/api/Transaccions/Transferencia";
            var api = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(datosTransaccion);

            IRestResponse response = await api.ExecuteTaskAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Comprobante comprobante = JsonConvert.DeserializeObject<Comprobante>(response.Content);
                return comprobante;
            }
            return null;
        }

        public async Task<Comprobante> Deposito(decimal monto)
        {
            DatosTransaccion datosTransaccion = new DatosTransaccion
            {
                Tarjeta_Destino = tarjeta.MiTarjeta,
                Monto = monto
            };

            var baseUrl = "https://bancossoftwarecomplejo.azurewebsites.net";
            var resource = "/api/Transaccions/Deposito";
            var api = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(datosTransaccion);

            IRestResponse response = await api.ExecuteTaskAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Comprobante comprobante = JsonConvert.DeserializeObject<Comprobante>(response.Content);
                return comprobante;
            }
            return null;
        }
        #endregion
    }
}
