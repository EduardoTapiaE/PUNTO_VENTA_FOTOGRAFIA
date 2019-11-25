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
    class PaquetePredefinido
    {
        public string idpaquete { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public List<Servicio> servicios { get; set; }
    }

    class PaqueteModel
    {
        SqlConnection sqlcon;

        public PaqueteModel()
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

        public List<PaquetePredefinido> DatosTablaPaquetesPredefinidos()
        {
            try
            {
                List<PaquetePredefinido> _datosreturn = new List<PaquetePredefinido>();
                sqlcon.Open();
                string query = "SELECT idpaquete,nombre,detalles FROM paquetespredefinidos;";
                _datosreturn = sqlcon.Query<PaquetePredefinido>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos del paquete\n" + ex.Message);
            }
        }
        public List<PaquetePredefinido> DatosTablaPaquetesPredefinidosPorId(string id)
        {
            try
            {
                List<PaquetePredefinido> _datosreturn = new List<PaquetePredefinido>();
                sqlcon.Open();
                string query = "SELECT idpaquete,nombre,detalles FROM paquetespredefinidos WHERE idpaquete = @idpaquete;";
                _datosreturn = sqlcon.Query<PaquetePredefinido>(query,new { idpaquete = id}, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos del paquete\n" + ex.Message);
            }
        }

    }
}
