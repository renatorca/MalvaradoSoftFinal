using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Configuracion
{
    public partial class frmCambiarContraseña : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        private MAlvaradoWS.user user;
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private bool esContraseñaSegura(string password)
        {
            bool flag = false;
            if (password.Length < 10)
                return false;

            Regex r = new Regex("^[A-Za-z ]+$");
            if (r.IsMatch(password) == true)
                return false;
            return true;
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            if (String.Equals(txtConfirmar.Text, txtContraseña.Text))
            {
                if (!esContraseñaSegura(txtConfirmar.Text))
                {
                    MessageBox.Show("Contraseña muy debil.");
                    estadoInicial();
                }
                else
                {
                    controller.updatePasswordUser(user.email, txtConfirmar.Text);
                    MessageBox.Show("Se ha actualizado su contraseña satisfactoriamente.");
                }
            }
            else
            {
                MessageBox.Show("Las constraseñas no coinciden.");
            }
        }
        private void estadoInicial()
        {
            txtConfirmar.Text = "Nueva contraseña";
            txtContraseña.Text = "Nueva contraseña";
            txtConfirmar.ForeColor = System.Drawing.Color.DimGray;
            txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            txtConfirmar.UseSystemPasswordChar = false;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Nueva contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Nueva contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Nueva contraseña";
                txtConfirmar.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void TxtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Nueva contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.DimGray;
                txtConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void TxtConfirmar_TextChanged(object sender, EventArgs e)
        {
            txtConfirmar.UseSystemPasswordChar = true;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void Panel1_Move(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
