using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Modelos
{
    class Pago
    {
        public string idpago { get; set; }
        public string idusuario{ get; set; }
        public string idventa{ get; set; }
        public string importe{ get; set; }
        public string cambio{ get; set; }
        public string concepto{ get; set; }
        public string fecha{ get; set; }
        public string hora{ get; set; }
        public string tipopago{ get; set; }
    }

    class PagoModel
    {
        SqlConnection sqlcon;

        public PagoModel()
        {
            try
            {
                sqlcon = new SqlConnection("Data Source=localhost;Initial Catalog=bdFotografia;User ID=sa;Password=kawama2310#");
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Ocurrio un error al conectarse a la base de datos\n" + ex.Message);
            }
        }

        public string NuevoPago(Pago pagonuevo)
        {
            try
            {
                string _datosreturn = "", _query = "";
                sqlcon.Open();
                _query = "INSERT INTO pagos (idusuario,idventa,importe,cambio,concepto,fecha,hora,tipopago) VALUES (@idusuario,@idventa,@importe,@cambio,@concepto,@fecha,@hora,@tipopago) SELECT SCOPE_IDENTITY() AS 'idpago';";
                _datosreturn = sqlcon.Query<Pago>(_query, new
                {
                    idusuario = pagonuevo.idusuario,
                    idventa = pagonuevo.idventa,
                    importe = pagonuevo.importe,
                    cambio = pagonuevo.cambio,
                    concepto = pagonuevo.concepto,
                    fecha = pagonuevo.fecha,
                    hora = pagonuevo.hora,
                    tipopago = pagonuevo.tipopago
                }, commandType: CommandType.Text).ToList()[0].idpago;
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nuevo pago\n"+ ex.Message);
            }
        }
    }
}
