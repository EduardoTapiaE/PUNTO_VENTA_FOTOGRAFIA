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

namespace Punto_de_venta
{
    public partial class FrmLogin : Form
    {
        UsuarioController ctlerUsuario = new UsuarioController();
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region BUTTON
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string _usuario = TxtUsuario.Text,
                  _contraseña = TxtContraseña.Text;
                ctlerUsuario.ValidarAccesoDeUsuario(_usuario, _contraseña);
                MessageBox.Show("Bienvenidos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TEXTBOX
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAceptar_Click(null, null);
            }
        }
        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnAceptar_Click(null, null);
            }
        }
        #endregion

    }
}
