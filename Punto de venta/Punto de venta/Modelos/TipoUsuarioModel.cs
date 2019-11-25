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
    public class TipoUsuario
    {
        public string idtipousuario { get; set; }
        public string tipo { get; set; }
    }

    class TipoUsuarioModel
    {
        SqlConnection sqlcon;

        public TipoUsuarioModel()
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

        public List<TipoUsuario> DatosTablaTiposDeUsuarios()
        {
            try
            {
                List<TipoUsuario> _datosreturn = new List<TipoUsuario>();

                sqlcon.Open();
                string query = "SELECT idtipousuario ,tipo FROM tiposdeusuarios;";
                _datosreturn = sqlcon.Query<TipoUsuario>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos de tipo de usurios\n" + ex.Message);
            }

        }
    }
}
