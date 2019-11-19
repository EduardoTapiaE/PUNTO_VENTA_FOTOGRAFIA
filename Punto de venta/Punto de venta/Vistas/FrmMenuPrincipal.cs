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
    public partial class FrmMenuPrincipal : Form
    {
        UsuarioController ctlerUsuario = new UsuarioController();
        private Form formularioActual = null;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form form)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlAbrirFormularios.Controls.Add(form);
            pnlAbrirFormularios.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void MostrarSubMenu(Panel submenu)
        {
            if (!submenu.Visible)
            {
                OcultarSubMenus();
                submenu.Visible = true;
            }
        }
        private void OcultarSubMenus()
        {
            PnlSubMenuAdministrar.Visible = false;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = "Usuario: " + UsuarioController.usuarioActual;
            OcultarSubMenus();
        }
        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region BUTTON
        private void BtnCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarSubMenus();
                AbrirFormulario(new FrmCotizacion());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PnlSubMenuAdministrar);
        }
        private void BtnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarSubMenus();
                AbrirFormulario(new FrmVenta());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarSubMenus();
                AbrirFormulario(new FrmUsuarios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnPaquetes_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarSubMenus();
                AbrirFormulario(new FrmPaquetes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
