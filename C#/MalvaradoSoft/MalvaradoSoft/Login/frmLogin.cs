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
        private frmRecuperarContrasena recuperarContraseña;
        private MAlvaradoWS.DBControllerWSClient controller;
        private MAlvaradoWS.user user = null;
        private int contador = 0;
        private int tiempoBloqueo = 900; // 15 min = 15*60
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
                estadoComponentes(estado.LogIncorrecto);
                return;
            }

            int idUser = controller.validarUserLogin(txtUser.Text);

            if (idUser != 0)
            {
                user = controller.queryUserByID(idUser);
                if (validarBloqueoCuenta(user)) //Si la cuenta esta bloqueada
                {
                    return;
                }

                //Cuenta no bloqueada
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
                    estadoComponentes(estado.LogIncorrecto);
                    user.nAttempts = user.nAttempts + 1;
                    if (user.nAttempts < 6)
                    {
                        controller.updateUser(user);
                    }
                    else
                    {
                        user.blocked = true;
                        controller.updateUser(user);
                        string hora_actual = DateTime.Now.ToString("hhmmss");
                        string time = hora_actual.Substring(0,2) + ":" + hora_actual.Substring(2, 2)  + ":" + hora_actual.Substring(4, 2);
                        controller.updateBlockTime(time, user);
                    }
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
            //Validacion si desea cerrar el form
            if (user != null)
            {
                string time = convertTimeString(contador);
                controller.updateBlockTime(time, user);
            }
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
        private int getTimeSeconds(string cad) //"hh:mm:ss"
        {
            int min = 0, seg = 0;
            min = Int32.Parse(cad.Substring(3,2));
            seg = Int32.Parse(cad.Substring(6,2));
            return min*60 + seg;
        }
        private string convertTimeString(int sec)
        {
            string time = "";
            int min = sec / 60;
            sec = sec - min * 60;
            time = "00:" + min.ToString() + ":" + sec.ToString();
            return time;
        }

        private bool continuaBloqueado(string blockTime, string now)
        {
            int segBlockTime = Int32.Parse(blockTime.Substring(6,2)) + Int32.Parse(blockTime.Substring(3,2))*60 + Int32.Parse(blockTime.Substring(0,2))* 3600;
            int segNow = Int32.Parse(now.Substring(4, 2)) + Int32.Parse(now.Substring(2, 2)) * 60 + Int32.Parse(now.Substring(0, 2)) * 3600;            
            if (segNow - segBlockTime < tiempoBloqueo)
                contador = segNow - segBlockTime;
            else
                contador = 0;

            return (segNow - segBlockTime < tiempoBloqueo);
        }

        private bool validarBloqueoCuenta(MAlvaradoWS.user user)
        {            
            if (user.blocked)
            {                
                string now = DateTime.Now.ToString("hhmmss");
                string blockTime = controller.queryBlockTimebyID(user.idUser);
                //Verifico si ya transcurrio el tiempo de bloqueo
                if (continuaBloqueado(blockTime, now))
                {
                    estadoComponentes(estado.Bloqueado);
                    return true;
                }
                else
                {
                    user.blocked = false;
                    user.nAttempts = 0;
                    controller.updateUser(user);
                    estadoComponentes(estado.Desbloqueado);
                    return false;
                }
            }
            else //Usuario no bloquado
            {
                estadoComponentes(estado.Desbloqueado);
                return false;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblBlock.Visible = true;
            lblBlockTime.Visible = true;
            if (contador > 0)
            {
                contador--;
                int min = contador / 60;
                int seg = contador - min * 60;
                lblBlockTime.Text = min.ToString()  + ":" + seg.ToString() + " seg.";
            }
            else
            {
                btnAcceder.Enabled = true;
            }
        }

        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.Inicial:
                    break;
                case estado.Bloqueado:
                    timer1.Enabled = true;
                    btnAcceder.Enabled = false;
                    break;
                case estado.Desbloqueado:
                    timer1.Enabled = false;
                    lblBlock.Visible = false;
                    lblBlockTime.Visible = false;
                    btnAcceder.Enabled = true ;
                    break;
                case estado.LogIncorrecto:
                    msgError("Ingrese un usuario y/o contraseña valida.");
                    timer1.Enabled = false;
                    lblBlock.Visible = false;
                    lblBlockTime.Visible = false;
                    break;                    
            }
        }

        public enum estado
        {
            Inicial, Bloqueado, Desbloqueado, LogIncorrecto
        }
    }
}
