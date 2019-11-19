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
    public partial class FrmUsuarios : Form
    {
        UsuarioController ctlerUsuario = new UsuarioController();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgvUsuarios();
                BtnNuevo.Select();
                //LlenarCmbNivelDelUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDgvUsuarios()
        {
           DgvUsuarios.DataSource = ctlerUsuario.GetTablaUsuarios();
        }

        private void LlenarCmbNivelDelUsuario()
        {
            throw new NotImplementedException();
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                PnlDatosDelUsuario.Enabled = true;
                BtnAgregar.Enabled = true;
                TxtNombres.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
