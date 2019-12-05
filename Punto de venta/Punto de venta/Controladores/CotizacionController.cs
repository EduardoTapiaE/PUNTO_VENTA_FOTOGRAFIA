using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class CotizacionController
    {
        ServicioController ctlerServicio = new ServicioController();
        CotizacionModel modelCotizacion = new CotizacionModel();
        ServicioModel modelServicio = new ServicioModel();
        public string  AgregarCotizacion(string importe,string nombres,string apellidos,List<Servicio> servicios)
        {
            string _fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                           _hora = DateTime.Now.ToString("hh:mm:ss"),
                           _usuarioactual = UsuarioController.idUsuarioActual;
            Cotizacion _nuevacotizacion = new Cotizacion()
            {
                idusuario = _usuarioactual,
                fecha = _fecha,
                hora = _hora,
                importe = importe,
                activo = "1",
                nombrescliente = nombres,
                apellidoscliente = apellidos
            };
            string _idcotizacion = modelCotizacion.NuevaCotizacion(_nuevacotizacion);

            if (_idcotizacion != "")
            {
                ctlerServicio.AgregarServiciosACotizacion(servicios, _idcotizacion);
            }

            return _idcotizacion;
        }
        public List<Cotizacion> GetTablaCotizaciones()
        {
            List<Cotizacion> _datosreturn = modelCotizacion.DatosTablaCotizaciones();
            return _datosreturn;
        }
        public Cotizacion GetCotizacion(string id)
        {
            Cotizacion _datosreturn = new Cotizacion();
            List<Cotizacion> _cotizaciones = modelCotizacion.DatosTablaCotizacionesPorId(id);
            if(_cotizaciones.Count > 0)
            {
                _datosreturn = _cotizaciones[0];
                List<Servicio> _servidiosdelacotizacion = modelServicio.DatosTablaServiciosParaCotizacionPorId(id);
                _datosreturn.servicios = _servidiosdelacotizacion;
            
            }
            return _datosreturn;
        }
        public DataTable ConvertirListaDeCotizacionesAFormatoDataTable(List<Cotizacion> listadecotizaciones)
        {
            DataTable _datosreturn = new DataTable();
            _datosreturn.Columns.Add("Id");
            _datosreturn.Columns.Add("Id usuario");
            _datosreturn.Columns.Add("Fecha");
            _datosreturn.Columns.Add("Hora");
            _datosreturn.Columns.Add("Importe");
            _datosreturn.Columns.Add("Activo");

            foreach (Cotizacion _cotizacion in listadecotizaciones)
            {
                DataRow fila = _datosreturn.NewRow();
                fila["Id"] = _cotizacion.idcotizacion;
                fila["Id usuario"] = _cotizacion.idusuario;
                fila["Fecha"] = _cotizacion.fecha;
                fila["Importe"] = _cotizacion.importe;
                fila["Activo"] = _cotizacion.activo;

                _datosreturn.Rows.Add(fila);
            }
            return _datosreturn;
        }
    }
}
