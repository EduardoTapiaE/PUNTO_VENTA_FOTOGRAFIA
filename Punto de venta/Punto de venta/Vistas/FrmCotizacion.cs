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
    public partial class FrmCotizacion : Form
    {
        public FrmCotizacion()
        {
            InitializeComponent();
        }

        private void BtnPersonalizar_Click(object sender, EventArgs e)
        {
            if (PnlPaquetePredefinido.Visible)
            {
                PnlPaquetePredefinido.Visible = false;
                PnlPaquetePersonalizado.Visible = true;
                BtnPersonalizar.Text = "Predefinido";
            }
            else if (PnlPaquetePersonalizado.Visible)
            {
                PnlPaquetePersonalizado.Visible = false;
                PnlPaquetePredefinido.Visible = true;
                BtnPersonalizar.Text = "Personalizar";
            }
        }
    }
}
