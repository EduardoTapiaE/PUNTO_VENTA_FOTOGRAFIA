using Punto_de_venta.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Vistas
{
    public partial class FrmVenta : Form
    {
        CotizacionController ctlerCotizacion = new CotizacionController();
        string idCotizacion = "";
        public FrmVenta(string idcotizacion)
        {
            idCotizacion = idcotizacion;
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarCmbIdCotizacion();
                CmbIdCotizacion.Select();
                if (idCotizacion != "")
                {
                    CmbIdCotizacion.SelectedValue = idCotizacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmVenta_Enter(object sender, EventArgs e)
        {
           
           
        }

        private void LlenarCmbIdCotizacion()
        {
         
            DataTable _tablaCotizaciones = ctlerCotizacion.ConvertirListaDeCotizacionesAFormatoDataTable(ctlerCotizacion.GetTablaCotizaciones());
            CmbIdCotizacion.ValueMember = "Id";
            CmbIdCotizacion.DisplayMember = "Id";
            CmbIdCotizacion.DataSource = _tablaCotizaciones;
            CmbIdCotizacion.Text = "";
            CmbIdCotizacion.SelectedValue = "-1";
        }
    }
}
