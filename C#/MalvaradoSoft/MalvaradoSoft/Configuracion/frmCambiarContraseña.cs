using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!string.Equals(txtConfirmar.Text, "Nueva contraseña"))
            {
                if (String.Equals(txtConfirmar.Text, txtContraseña.Text))
                {
                    if (txtConfirmar.Text.Length < 6)
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
        }
        private void estadoInicial()
        {
            txtConfirmar.Text = "Nueva contraseña";
            txtContraseña.Text = "Nueva contraseña";
            txtConfirmar.ForeColor = System.Drawing.Color.DimGray;
            txtContraseña.ForeColor = System.Drawing.Color.DimGray;
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
            }
        }

        private void TxtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Nueva contraseña";
                txtConfirmar.ForeColor = Color.DimGray;
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
            //txtContraseña.UseSystemPasswordChar = true;
        }

        private void TxtConfirmar_TextChanged(object sender, EventArgs e)
        {
            //txtConfirmar.UseSystemPasswordChar = true;
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
