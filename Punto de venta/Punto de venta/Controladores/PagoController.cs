using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controladores
{
    class PagoController
    {
        PagoModel modelPago = new PagoModel();
        public string AgregarPago(string idusuario,string idventa,string importe,string cambio,string concepto,string fecha,string hora,string tipopago)
        {
            string _datosreturn = "";
            Pago _pago = new Pago() 
            {
                idusuario = idusuario,
                idventa = idventa,
                importe = importe,
                cambio= cambio,
                concepto = concepto,
                fecha = fecha,
                hora = hora,
                tipopago = tipopago
            };
            
            _datosreturn = modelPago.NuevoPago(_pago);
            if (_datosreturn != "")
            {
                //MODIFICAR TABLA VENTA EN EL CAMPO SALDO PARA RESTAR EL PAGO REALIZADO
            }
            return _datosreturn;
        }
    }
}
