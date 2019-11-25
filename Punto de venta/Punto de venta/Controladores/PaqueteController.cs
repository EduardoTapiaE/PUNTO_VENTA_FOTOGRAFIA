using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class PaqueteController
    {
        PaqueteModel modelPaquete = new PaqueteModel();
        ServicioModel modelServicio = new ServicioModel();
        public List<PaquetePredefinido> GetTablaPaquetesPredefinidos()
        {
            List<PaquetePredefinido> _datosreturn = modelPaquete.DatosTablaPaquetesPredefinidos();

            return _datosreturn;
        }

        public DataTable GetTablaPaquetesPredefinidosEnFormatoDataTable()
        {
            List<PaquetePredefinido> _listadatospaquetespredefinidos = modelPaquete.DatosTablaPaquetesPredefinidos();

            DataTable _datosreturn = new DataTable();
            _datosreturn.Columns.Add("Id");
            _datosreturn.Columns.Add("Nombre");
            _datosreturn.Columns.Add("Detalles");

            if (_listadatospaquetespredefinidos.Count > 0)
            {
                for (int i = 0; i < _listadatospaquetespredefinidos.Count; i++)
                {
                    DataRow fila = _datosreturn.NewRow();
                    fila["Id"] = _listadatospaquetespredefinidos[i].idpaquete;
                    fila["Nombre"] = _listadatospaquetespredefinidos[i].nombre;
                    fila["Detalles"] = _listadatospaquetespredefinidos[i].nombre;
                    _datosreturn.Rows.Add(fila);
                }
            }

            return _datosreturn;
        }

        public List<PaquetePredefinido> GetPaquetesPredefinidos()
        {
            List<PaquetePredefinido> _datosreturn = modelPaquete.DatosTablaPaquetesPredefinidos();
            foreach (PaquetePredefinido paquete in _datosreturn)
            {
                List<Servicio> _servidiosdelpaquete = modelServicio.DatosTablaServiciosParaPaquetesPredefinidos(paquete.idpaquete);
                paquete.servicios = _servidiosdelpaquete;
            }

            return _datosreturn;
        }

        public PaquetePredefinido GetPaquetePredefinidoPorId(string id)
        {
            PaquetePredefinido _datosreturn = new PaquetePredefinido();
            List<PaquetePredefinido> _paquete = modelPaquete.DatosTablaPaquetesPredefinidosPorId(id);

            if (_paquete.Count > 0)
            {
                _datosreturn = _paquete[0];
                List<Servicio> _servidiosdelpaquete = modelServicio.DatosTablaServiciosParaPaquetesPredefinidos(id);
                _datosreturn.servicios = _servidiosdelpaquete;
            }
            else
            {
                throw new Exception("Erro: Ocurrio un problema al buscar el paquete");
            }

            return _datosreturn;
        }


    }
}
