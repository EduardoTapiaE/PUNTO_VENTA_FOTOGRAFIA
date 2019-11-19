using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class TipoUsuarioController
    {
        TipoUsuarioModel modelTipoUsuario = new TipoUsuarioModel();

        public List<TipoUsuario> GetTablaTiposDeUsuarios()
        {
            List<TipoUsuario> _datosreturn = modelTipoUsuario.DatosTablaTiposDeUsuarios();

            return _datosreturn;
        }

        public DataTable GetTablaTiposDeUsuariosEnFormatoDataTable()
        {
            List<TipoUsuario> _listaDatosTablaTiposDeUsuarios = modelTipoUsuario.DatosTablaTiposDeUsuarios();

            DataTable _datosreturn = new DataTable();
            _datosreturn.Columns.Add("Id");
            _datosreturn.Columns.Add("Tipo usuario");

            if (_listaDatosTablaTiposDeUsuarios.Count > 0)
            {
                for (int i = 0; i < _listaDatosTablaTiposDeUsuarios.Count; i++)
                {
                    DataRow fila = _datosreturn.NewRow();
                    fila["Id"] = _listaDatosTablaTiposDeUsuarios[i].idtipousuario;
                    fila["Tipo usuario"] = _listaDatosTablaTiposDeUsuarios[i].tipo;
                    _datosreturn.Rows.Add(fila);
                }
            }

            return _datosreturn;
        }
    }
}
