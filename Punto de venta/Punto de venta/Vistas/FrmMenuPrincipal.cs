﻿using Punto_de_venta.Controladores;
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

        public void CambiarNombreTitulo(string titulo)
        {
            LblTitulo.Text = titulo;
        }
        public void AbrirFormulario(Form form)
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
                string _tipousuario = UsuarioController.tipoUsuario;
                if (_tipousuario == "CAJERO") 
                {
                    OcultarSubMenus();
                    AbrirFormulario(new FrmCotizacion());
                    LblTitulo.Text = "COTIZACION";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdministrar_Click(object sender, EventArgs e)
        {
            string _tipousuario = UsuarioController.tipoUsuario;
            if (_tipousuario == "ADMINISTRADOR")
            {
                MostrarSubMenu(PnlSubMenuAdministrar);
            }
           
        }
        private void BtnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //OcultarSubMenus();
                //AbrirFormulario(new FrmVenta(""));
                //LblTitulo.Text = "VENTA";
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
                LblTitulo.Text = "USUARIOS";
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
                LblTitulo.Text = "PAQUETES";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarSubMenus();
                AbrirFormulario(new FrmVentasRealizadas());
                LblTitulo.Text = "VENTAS";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
