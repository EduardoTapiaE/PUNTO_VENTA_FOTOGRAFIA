using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class VentaController
    {
        VentaModel modelVenta = new VentaModel();

        public string AgregarVenta(string idcotizacion, string nombres, string apellidos, string domicilio, string telefono, string correo, string fevento, string hevento, string fentrega,string hentrega,string saldo,string sredes,string tventa)
        {
            string _datosreturn = "";
            Venta _venta = new Venta() 
            {
                idcotizacion = idcotizacion,
                nombrescliente = nombres,
                apellidoscliente = apellidos,
                domiciliocliente = domicilio,
                telefonocliente = telefono,
                correo = correo,
                fechaevento = fevento,
                horaevento = hevento,
                fechaentrega = fentrega,
                horaentrega = hentrega,
                saldo = saldo,
                subiraredes = sredes,
                tipoventa = tventa
            };
            _datosreturn = modelVenta.NuevaVenta(_venta);
            return _datosreturn;
        }
    }
}
