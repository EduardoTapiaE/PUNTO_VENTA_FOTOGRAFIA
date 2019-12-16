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

        public string AgregarVenta(string idcotizacion, string nombres, string apellidos, string domicilio, string telefono, string correo, string fevento, string hevento, string fentrega,string hentrega,string saldo,string sredes,string tventa,string Id_Transaccion,string Tarjeta_Origen,string Fecha_Transaccion)
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
                tipoventa = tventa,
                Id_Transaccion = Id_Transaccion,
                Tarjeta_Origen = Tarjeta_Origen,
                Fecha_Transaccion = Fecha_Transaccion
            };
            _datosreturn = modelVenta.NuevaVenta(_venta);
            return _datosreturn;
        }

        public void ModificarSaldoVenta(string idventa, string saldo)
        {
            Venta _venta = new Venta() 
            {
                idventa = idventa,
                saldo = saldo
            };

            modelVenta.EditarSaldoVenta(_venta);
        }
    }
}
