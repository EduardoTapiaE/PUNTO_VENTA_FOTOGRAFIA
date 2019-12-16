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
    public class Usuario
    {
        public string idusuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nombreusuario { get; set; }
        public string contraseña { get; set; }
        public string tipousuario { get; set; }
        
    }

    class UsuarioModel
    {
        SqlConnection sqlcon;

        public UsuarioModel()
        {
            try
            {
                sqlcon = new SqlConnection(ConfiguracionController.Conexion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Ocurrio un error al conectarse a la base de datos\n"+ex.Message);
            }
        }

        public int NuevoUsuario(Usuario usuarionuevo)
        {
            try
            {
                sqlcon.Open();
                //int _filasafectadas = sqlcon.Execute("Insert into Student (Name, Marks) values (@Name, @Marks)", new { Name = student.Name, Marks = student.Marks });
                int _filasafectadas = sqlcon.Execute("INSERT INTO usuarios (nombres, apellidos, nombreusuario,contraseña,tipousuario)VALUES(@nombres,@apellidos,@nombreusuario,@contraseña,@tipousuario);", new { nombres = usuarionuevo.nombres, apellidos = usuarionuevo.apellidos, nombreusuario = usuarionuevo.nombreusuario, contraseña = usuarionuevo.contraseña, tipousuario = usuarionuevo.tipousuario });
                sqlcon.Close();
                return _filasafectadas;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nuevo usuario\n" + ex.Message);
            }
        }
        public List<Usuario> DatosTablaUsuarioPorUsuarioYContrseña(string usuario, string contraseña)
        {
            try
            {
                List<Usuario> _datosreturn = new List<Usuario>();
                
                sqlcon.Open();
                string query = string.Format("SELECT idusuario,nombres,apellidos,nombreusuario,contraseña,tipousuario FROM usuarios WHERE nombreusuario = '{0}' AND contraseña = '{1}';",usuario,contraseña);
                _datosreturn = sqlcon.Query<Usuario>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos del usurio\n" + ex.Message);
            }
           
        }
        public List<Usuario> DatosTablaUsuario()
        {
            try
            {
                List<Usuario> _datosreturn = new List<Usuario>();

                sqlcon.Open();
                string query = "SELECT idusuario,nombres,apellidos,nombreusuario,contraseña,tipousuario FROM usuarios;";
                _datosreturn = sqlcon.Query<Usuario>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();

                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos del usurio\n" + ex.Message);
            }

        }
    }
}
