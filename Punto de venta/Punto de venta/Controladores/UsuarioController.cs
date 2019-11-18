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
        UsuarioModel modelUsuario = new UsuarioModel();

        public void ValidarAccesoDeUsuario(string usuario, string contraseña)
        {
            List<Usuario> _datosdeusuario = modelUsuario.DatosTablaUsuarioPorUsuarioYContrseña(usuario, contraseña);
            if (_datosdeusuario.Count < 1)
            {
                throw new Exception("Usuario y/o contraseña incorrectos");
            }
        }

    }
}
