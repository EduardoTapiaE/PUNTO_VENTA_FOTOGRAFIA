using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class ServicioController
    {
        public DataTable ConvertirListaDeServiciosAFormatoDataTable(List<Servicio> listadeservicios)
        {
            DataTable _datosreturn = new DataTable();
            _datosreturn.Columns.Add("Id");
            _datosreturn.Columns.Add("Nombre");
            _datosreturn.Columns.Add("Detalles");
            _datosreturn.Columns.Add("Costo");
            _datosreturn.Columns.Add("Unitario");
            _datosreturn.Columns.Add("Cantidad");

            foreach (Servicio _servicio in listadeservicios)
            {
                DataRow fila = _datosreturn.NewRow();
                fila["Id"] = _servicio.idservicio;
                fila["Nombre"] = _servicio.nombre;
                fila["Detalles"] = _servicio.detalles;
                fila["Costo"] = _servicio.costo;
                fila["Unitario"] = _servicio.unitario;
                fila["Cantidad"] = _servicio.cantidad;

                _datosreturn.Rows.Add(fila);
            }
            return _datosreturn;

            /*
             *  public string idservicio { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public string costo { get; set; }
        public string unitario { get; set; }
        public string cantidad { get; set; }
             */
        }
    }
}
