using Punto_de_venta.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
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
                Fecha_Transaccion = Fecha_Transaccion,
                correoopinionclienteenviado = "0"
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
        public void ModificarCorreoOpinionClienteEnviado(string idventa, string correoopinionclienteenviado)
        {
            Venta _venta = new Venta()
            {
                idventa = idventa,
                correoopinionclienteenviado = correoopinionclienteenviado
            };

            modelVenta.EditarCorreoOpinionClienteEnviado(_venta);
        }

        public List<Venta> GetTablaVenta()
        {
            List<Venta> _datosreturn = new List<Venta>();
            _datosreturn = modelVenta.DatosTablaVenta();
            return _datosreturn;
        }
        public List<Venta> GetTablaVentaPorCorreoOpinionClienteEnviado(string enviado)
        {
            List<Venta> _datosreturn = new List<Venta>();
            _datosreturn = modelVenta.DatosTablaVentaPorCorreoOpinionClienteEnviado(enviado);
            return _datosreturn;
        }
        public DataTable ConvertirListaDeVentasAFormatoDataTable(List<Venta> listadeventas)
        {
            DataTable _datosreturn = new DataTable();
            _datosreturn.Columns.Add("Id venta");
            _datosreturn.Columns.Add("Id cotizacion");
            _datosreturn.Columns.Add("Id transaccion");
            _datosreturn.Columns.Add("Tipo pago");
            _datosreturn.Columns.Add("Cliente");
            _datosreturn.Columns.Add("Correo");


            foreach (Venta _venta in listadeventas)
            {
                DataRow fila = _datosreturn.NewRow();
                fila["Id venta"] = _venta.idventa;
                fila["Id cotizacion"] = _venta.idcotizacion;
                fila["Id transaccion"] = _venta.Id_Transaccion;
                fila["Tipo pago"] = _venta.tipoventa;
                fila["Cliente"] = _venta.nombrescliente+" "+_venta.apellidoscliente;
                fila["Correo"] = _venta.correo;

                _datosreturn.Rows.Add(fila);
            }
            return _datosreturn;
        }
    }
}

//public string idventa { get; set; }
//public string idcotizacion { get; set; }
//public string nombrescliente { get; set; }
//public string apellidoscliente { get; set; }
//public string domiciliocliente { get; set; }
//public string telefonocliente { get; set; }
//public string correo { get; set; }
//public string fechaevento { get; set; }
//public string horaevento { get; set; }
//public string fechaentrega { get; set; }
//public string horaentrega { get; set; }
//public string saldo { get; set; }
//public string subiraredes { get; set; }
//public string tipoventa { get; set; }
//public string Id_Transaccion { get; set; }
//public string Tarjeta_Origen { get; set; }
//public string Fecha_Transaccion { get; set; }
//public string correoopinionclienteenviado { get; set; }
