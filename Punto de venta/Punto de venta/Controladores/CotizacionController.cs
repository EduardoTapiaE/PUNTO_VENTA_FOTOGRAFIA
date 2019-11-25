﻿using Punto_de_venta.Modelos;
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
        public string  AgregarCotizacion(string importe,List<Servicio> servicios)
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
                activo = "1"
            };
            string _idcotizacion = modelCotizacion.NuevaCotizacion(_nuevacotizacion);

            if (_idcotizacion != "")
            {
                ctlerServicio.AgregarServiciosACotizacion(servicios, _idcotizacion);
            }

            return _idcotizacion;
        }
    }
}