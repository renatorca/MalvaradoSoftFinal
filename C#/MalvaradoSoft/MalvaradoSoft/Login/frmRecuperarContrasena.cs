﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Login
{
    public partial class frmRecuperarContrasena : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        public frmRecuperarContrasena()
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo electrónico";
                txtCorreo.ForeColor = Color.DimGray;
                txtCorreo.UseSystemPasswordChar = false;
            }
        }

        private void TxtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electrónico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            String newPassword = (rd.Next(10000, 99999)).ToString();
            //Actualizo la nueva contraseña del usuario
            int validar = controller.updatePasswordUser(txtCorreo.Text, newPassword);
            if (validar > 0)
            {
                EnviarCorreoContraseña(txtCorreo.Text, newPassword);
            }
            else
            {
                MessageBox.Show("Error: El correo electronico " + txtCorreo.Text + " no se encuentra registrado en el Sistema.");
            }
        }

        private void EnviarCorreoContraseña(String email, String newPassword)
        {
            string password = "mariaalvarado123";
            string message = string.Empty;

            //Creacion del correo electroncio
            string destinatario = email;
            string remitente = "malvarado.colegio@gmail.com";
            string asunto = "Nueva Contraseña Sistema Maria Alvarado";
            string cuerpoDelMensaje = "Su nueva contraseña es" + " " + newPassword;
            MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMensaje);

            SmtpClient smtp = new SmtpClient("	smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(remitente, password);

            try
            {
                Task.Run(() => {
                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada");
                }
                );
                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico:" + ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.ForeColor = System.Drawing.Color.Black;
        }
    }
}
