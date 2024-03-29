﻿using Dapper;
using Punto_de_venta.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Modelos
{
    class Venta
    {
        public string idventa { get; set; }
        public string idcotizacion { get; set; }
        public string nombrescliente { get; set; }
        public string apellidoscliente { get; set; }
        public string domiciliocliente { get; set; }
        public string telefonocliente { get; set; }
        public string correo { get; set; }
        public string fechaevento { get; set; }
        public string horaevento { get; set; }
        public string fechaentrega { get; set; }
        public string horaentrega { get; set; }
        public string saldo { get; set; }
        public string subiraredes { get; set; }
        public string tipoventa { get; set; }
        public string Id_Transaccion { get; set; }
        public string Tarjeta_Origen { get; set; }
        public string Fecha_Transaccion { get; set; }
        public string correoopinionclienteenviado { get; set; }

    }

    class VentaModel
    {
        SqlConnection sqlcon;

        public VentaModel()
        {
            try
            {
                sqlcon = new SqlConnection(ConfiguracionController.Conexion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Ocurrio un error al conectarse a la base de datos\n" + ex.Message);
            }
        }

        public string NuevaVenta(Venta ventanueva)
        {
            try
            {
                string _datosreturn = "", _query = "";
                sqlcon.Open();
                _query = "INSERT INTO venta(idcotizacion,nombrescliente,apellidoscliente,domiciliocliente,telefonocliente,correo,fechaevento,horaevento,fechaentrega,horaentrega,saldo,subiraredes,tipoventa,Id_Transaccion,Tarjeta_Origen,Fecha_Transaccion,correoopinionclienteenviado) VALUES (@idcotizacion,@nombrescliente,@apellidoscliente,@domiciliocliente,@telefonocliente,@correo,@fechaevento,@horaevento,@fechaentrega,@horaentrega,@saldo,@subiraredes,@tipoventa,@Id_Transaccion,@Tarjeta_Origen,@Fecha_Transaccion,@correoopinionclienteenviado) SELECT SCOPE_IDENTITY() AS 'idventa';";
                _datosreturn = sqlcon.Query<Venta>(_query, new
                {
                    idcotizacion = ventanueva.idcotizacion,
                    nombrescliente = ventanueva.nombrescliente,
                    apellidoscliente = ventanueva.apellidoscliente,
                    domiciliocliente = ventanueva.domiciliocliente,
                    telefonocliente = ventanueva.telefonocliente,
                    correo = ventanueva.correo,
                    fechaevento = ventanueva.fechaevento,
                    horaevento = ventanueva.horaevento,
                    fechaentrega = ventanueva.fechaentrega,
                    horaentrega = ventanueva.horaentrega,
                    saldo = ventanueva.saldo,
                    subiraredes = ventanueva.subiraredes,
                    tipoventa = ventanueva.tipoventa,
                    Id_Transaccion = ventanueva.Id_Transaccion,
                    Tarjeta_Origen = ventanueva.Tarjeta_Origen,
                    Fecha_Transaccion = ventanueva.Fecha_Transaccion,
                    correoopinionclienteenviado = ventanueva.correoopinionclienteenviado
                }, commandType: CommandType.Text).ToList()[0].idventa;
                sqlcon.Close();
                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para agregar nueva venta\n" + ex.Message);
            }
        }

        public string EditarSaldoVenta(Venta ventaeditada)
        {
            try
            {
                string _datosreturn = "", _query = "";
                sqlcon.Open();
                _query = "UPDATE venta SET saldo = @saldo  WHERE idventa = @idventa;";
                _datosreturn = sqlcon.Execute(_query,new { saldo = ventaeditada.saldo, idventa = ventaeditada.idventa}).ToString();
                sqlcon.Close();
                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para editar venta\n" + ex.Message);
            }
        }
        public string EditarCorreoOpinionClienteEnviado(Venta ventaeditada)
        {
            try
            {
                string _datosreturn = "", _query = "";
                sqlcon.Open();
                _query = "UPDATE venta SET correoopinionclienteenviado = @correoopinionclienteenviado  WHERE idventa = @idventa;";
                _datosreturn = sqlcon.Execute(_query, new { correoopinionclienteenviado = ventaeditada.correoopinionclienteenviado, idventa = ventaeditada.idventa }).ToString();
                sqlcon.Close();
                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para editar venta\n" + ex.Message);
            }
        }

        public List<Venta> DatosTablaVenta()
        {
            try
            {
                List<Venta> _datosreturn = new List<Venta>();
                sqlcon.Open();
                string query = "SELECT idventa,idcotizacion,nombrescliente,apellidoscliente,domiciliocliente,telefonocliente,correo,fechaevento,convert(varchar, horaevento, 8) AS horaevento,fechaentrega,convert(varchar, horaentrega, 8) AS horaentrega,saldo,subiraredes,tipoventa,Id_Transaccion,Tarjeta_Origen,Fecha_Transaccion,correoopinionclienteenviado  FROM venta;";
                _datosreturn = sqlcon.Query<Venta>(query, commandType: CommandType.Text).ToList();
                sqlcon.Close();
                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos de venta\n" + ex.Message);
            }     
        }
        public List<Venta> DatosTablaVentaPorCorreoOpinionClienteEnviado(string enviado)
        {
            try
            {
                List<Venta> _datosreturn = new List<Venta>();
                sqlcon.Open();
                string query = "SELECT idventa,idcotizacion,nombrescliente,apellidoscliente,domiciliocliente,telefonocliente,correo,fechaevento,convert(varchar, horaevento, 8) AS horaevento,fechaentrega,convert(varchar, horaentrega, 8) AS horaentrega,saldo,subiraredes,tipoventa,Id_Transaccion,Tarjeta_Origen,Fecha_Transaccion,correoopinionclienteenviado  FROM venta WHERE correoopinionclienteenviado = @_enviado;";
                _datosreturn = sqlcon.Query<Venta>(query,new { _enviado = enviado}, commandType: CommandType.Text).ToList();
                sqlcon.Close();
                return _datosreturn;
            }
            catch (Exception ex)
            {
                sqlcon.Close();
                throw new Exception("Erro: Ocurrio un problema al ejecutar la sentencia sql para solicitar los datos de venta\n" + ex.Message);
            }
        }
    }
}
