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
    class Servicio
    {
        public string idservicio { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public string costo { get; set; }
        public string unitario { get; set; }
        public string cantidad { get; set; }
    }

    class ServicioModel
    {
        SqlConnection sqlcon;
        public ServicioModel()
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

        public int NuevoServicioACotizacion(string idservicio,string idcotizacion, string cantidad)
        {
            try
            {
                sqlcon.Open();
                int _filasafectadas = sqlcon.Execute("INSERT INTO paquetedecotizacion(idservicio,idcotizacion,cantidad)VALUES(@idservicio,@idcotizacion,@cantidad);", new { idservicio = idservicio , idcotizacion = idcotizacion, cantidad = cantidad });
                sqlcon.Close();
                return _filasafectadas;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nuevo servicio a cotizacion\n" + ex.Message);
            }
        }

        public List<Servicio> DatosTablaServiciosParaPaquetesPredefinidos(string idpaquete)
        {
            try
            {
                List<Servicio> _datosreturn = new List<Servicio>();
                sqlcon.Open();
                string query = "SELECT s.idservicio, s.idservicio,s.nombre,s.detalles,s.costo,s.unitario,sdp.cantidad FROM servicios s, paquetespredefinidos ppd, serviciosdepaquete sdp WHERE ppd.idpaquete = sdp.idpaquete AND sdp.idservicio = s.idservicio AND ppd.idpaquete = @idpaquete;";
                _datosreturn = sqlcon.Query<Servicio>(query, new {idpaquete = idpaquete }, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos servicios del paquete\n" + ex.Message);
            }
        }
    }
}
