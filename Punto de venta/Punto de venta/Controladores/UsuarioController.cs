using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class UsuarioController
    {
        public static string usuarioActual = "", idUsuarioActual = "", tipoUsuario = "";
        UsuarioModel modelUsuario = new UsuarioModel();

        public void AgregarUsuario(string nombres, string apellidos, string usuario, string contraseña, string tipodeusuario)
        {
            Usuario _nuevousuario = new Usuario()
            {
                nombres = nombres,
                apellidos = apellidos,
                nombreusuario = usuario,
                contraseña = contraseña,
                tipousuario = tipodeusuario
            };

            if (modelUsuario.NuevoUsuario(_nuevousuario) < 1)
            {
                throw new Exception("Error: No se pudo agregar al usuario");
            }
        }

        public void ValidarAccesoDeUsuario(string usuario, string contraseña)
        {
            List<Usuario> _datosdeusuario = modelUsuario.DatosTablaUsuarioPorUsuarioYContrseña(usuario, contraseña);
            if (_datosdeusuario.Count > 0)
            {
                usuarioActual = _datosdeusuario[0].nombreusuario;
                idUsuarioActual = _datosdeusuario[0].idusuario;
                tipoUsuario = _datosdeusuario[0].tipo;
            }
            else
            {
                throw new Exception("Usuario y/o contraseña incorrectos");
            }
        }

        public List<Usuario> GetTablaUsuarios()
        {
            List<Usuario> _datosreturn = modelUsuario.DatosTablaUsuario();

            return _datosreturn;
        }

    }
}
