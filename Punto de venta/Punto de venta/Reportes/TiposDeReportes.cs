using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Reportes
{
    public class ComprobanteCotizacion
    {
        public string idCotizacion { get; set;}
        public string cliente { get; set; }
        public string fecha { get; set; }
        public string montoInicial { get; set; }
        public string iva { get; set; }
        public string montoFinal { get; set; }
        public List<Servicio> listaServicios = new List<Servicio>();
    }

    class TiposDeReportes
    {
    }
}
