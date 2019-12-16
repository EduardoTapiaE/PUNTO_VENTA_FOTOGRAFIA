using Dapper;
using Punto_de_venta.Controladores;
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
        public string nombrescliente { get; set; }
        public string apellidoscliente { get; set; }
        public List<Servicio> servicios { get; set; }

    }

    class CotizacionModel
    {
        SqlConnection sqlcon;

        public CotizacionModel()
        {
            try
            {
                sqlcon = new SqlConnection(ConfiguracionController.Conexion);
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
                query = "INSERT INTO cotizaciones(idusuario,fecha,hora,importe,activo,nombrescliente,apellidoscliente)VALUES(@idusuario,@fecha,@hora, @importe,@activo,@nombrescliente,@apellidoscliente) SELECT SCOPE_IDENTITY() AS 'idcotizacion';";
                __idcotizacionreturn = sqlcon.Query<Cotizacion>(query,new { idusuario = cotizacionnueva.idusuario, 
                                                                                fecha = cotizacionnueva.fecha, 
                                                                                 hora = cotizacionnueva.hora, 
                                                                              importe = cotizacionnueva.importe, 
                                                                               activo = cotizacionnueva.activo, 
                                                                       nombrescliente = cotizacionnueva.nombrescliente, 
                                                                     apellidoscliente = cotizacionnueva.apellidoscliente}, commandType: CommandType.Text).ToList()[0].idcotizacion;
                sqlcon.Close();
                return __idcotizacionreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nueva cotizacion\n" + ex.Message);
            }
        }
        public List<Cotizacion> DatosTablaCotizaciones()
        {
            try
            {
                List<Cotizacion> _datosreturn = new List<Cotizacion>();

                sqlcon.Open();
                string query = "SELECT idcotizacion,idusuario,fecha, convert(varchar, hora, 8) AS hora,importe,activo,nombrescliente,apellidoscliente FROM cotizaciones;";
                _datosreturn = sqlcon.Query<Cotizacion>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos de cotizacion\n" + ex.Message);
            }

        }

        public List<Cotizacion> DatosTablaCotizacionesPorId(string id)
        {
            try
            {
                List<Cotizacion> _datosreturn = new List<Cotizacion>();

                sqlcon.Open();
                string query = "SELECT idcotizacion,idusuario,fecha, convert(varchar, hora, 8) AS hora,importe,activo,nombrescliente,apellidoscliente FROM cotizaciones WHERE idcotizacion = @idcotizacion;";
                _datosreturn = sqlcon.Query<Cotizacion>(query,new { idcotizacion = id }, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos de cotizacion\n" + ex.Message);
            }

        }

    }
}
