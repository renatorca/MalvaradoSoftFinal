using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MalvaradoSoft.Menu_Principal;

namespace MalvaradoSoft.Login
{
    public partial class frmLogin : Form
    {
        frmRecuperarContrasena recuperarContraseña;
        MAlvaradoWS.DBControllerWSClient controller;
        MAlvaradoWS.user user;

        public frmLogin()
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            user = new MAlvaradoWS.user();
        }

        //Para movilizar el form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtUser.Text, "USUARIO") || String.Equals(txtPassword.Text, "CONTRASEÑA"))
            {
                msgError("Ingrese un usuario y/o contraseña valida.");
                return;
            }

            int idUser = controller.validarUserLogin(txtUser.Text);

            if (idUser != 0)
            {
                user = controller.queryUserByID(idUser);
                if (String.Equals(txtPassword.Text, user.password)) //Usuario y contraseña correcta
                {
                    BindingList<MAlvaradoWS.userType> tipo = new BindingList<MAlvaradoWS.userType>(controller.queryAllTypesXUser(user));
                    if (tipo.Count > 1)  //Muestro form con los posibles tipos de usuario validos
                    {
                        frmIniciarTipoUsuario frmTipo = new frmIniciarTipoUsuario();
                        frmTipo.Permisos = tipo;
                        frmTipo.user = user;
                        frmTipo.FormClosed += Logout;
                        frmTipo.Show();
                    }
                    else //Inicio el unico tipo de usuario unico que posee
                    {
                        int flag = tipo.ElementAt(0).idUserType;
                        if (flag == 1)
                        {
                            frmMenuPrincipal_Secretario menu = new frmMenuPrincipal_Secretario();
                            menu.FormClosed += Logout;
                            menu.Show();
                        }
                        else if (flag == 2)
                        {
                            frmMenuPrincipal_apoderado menu = new frmMenuPrincipal_apoderado();
                            menu.FormClosed += Logout;
                            menu.Show();
                        }
                        else if (flag == 3)
                        {
                            frmMenuPrincipal_profesor menu = new frmMenuPrincipal_profesor();
                            menu.FormClosed += Logout;
                            menu.Show();
                        }
                        else if (flag == 4)
                        {
                            frmMenuPrincipal_alumno menu = new frmMenuPrincipal_alumno();
                            menu.FormClosed += Logout;
                            menu.Show();
                        }
                        else if (flag == 5)
                        {
                            frmMenuPrincipal_auxiliar menu = new frmMenuPrincipal_auxiliar();
                            menu.FormClosed += Logout;
                            menu.Show();
                        }
                    }
                    this.Hide();
                }
                else //Usuario incorrecto
                {
                    msgError("Ingrese un usuario y/o contraseña valida.");
                }
            }
            else //Usuario incorrecto
            {
                msgError("Ingrese un usuario y/o contraseña valida.");
            }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtUser.Clear();
            this.Show();
            txtUser.Focus();
        }

        private void msgError(string msgError)
        {
            lblErrorMessage.Text = "       " + msgError;
            lblErrorMessage.Visible = true;
        }

        private void LinklblContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperarContraseña = new frmRecuperarContrasena();
            recuperarContraseña.Show();
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOcultarContraseña_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnMostrarContraseña.Visible = true;
            btnOcultarContraseña.Visible = false;
        }

        private void BtnMostrarContraseña_Click(object sender, EventArgs e)
        {
            btnMostrarContraseña.Visible = false;
            btnOcultarContraseña.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
