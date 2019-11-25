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
    class Cotizacion
    {
        public string idcotizacion { get; set; }
        public string idusuario { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string importe { get; set; }
        public string activo { get; set; }
    }

    class CotizacionModel
    {
        SqlConnection sqlcon;

        public CotizacionModel()
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

        public string NuevaCotizacion(Cotizacion cotizacionnueva)
        {
            try
            {
                string __idcotizacionreturn = "", query = "";
                sqlcon.Open();
                query = "INSERT INTO cotizaciones(idusuario,fecha,hora,importe,activo)VALUES(@idusuario,@fecha,@hora, @importe,@activo) SELECT SCOPE_IDENTITY() AS 'idcotizacion';";
                __idcotizacionreturn = sqlcon.Query<Cotizacion>(query,new { idusuario = cotizacionnueva.idusuario, fecha = cotizacionnueva.fecha, hora = cotizacionnueva.hora, importe = cotizacionnueva.importe, activo = cotizacionnueva.activo }, commandType: CommandType.Text).ToList()[0].idcotizacion;
                sqlcon.Close();
                return __idcotizacionreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nueva cotizacion\n" + ex.Message);
            }
        }
    }
}
