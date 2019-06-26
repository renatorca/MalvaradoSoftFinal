using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MalvaradoSoft.GestionSecretario
{
    public enum estado
    {
        inicial, guardar, editar, nuevo
    }

    public partial class frmGestionarUsuario_secretario : Form
    {
        private JohanaWS.DBControllerWSClient controller;
        private JohanaWS.user usuario;

        bool esAlumno;
        bool yaTieneUsuario;
        public frmGestionarUsuario_secretario()
        {
            InitializeComponent();
            estadoComponentes(estado.inicial);
        }

        public void estadoComponentes(estado est)
        {
            switch (est)
            {
                case estado.inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnBuscarUsuario.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApPat.Enabled = false;
                    txtApMat.Enabled = false;
                    txtApDir.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTel.Enabled = false;
                    break;
                case estado.nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnBuscarUsuario.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtDNI.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApPat.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApDir.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTel.Enabled = true;
                    yaTieneUsuario = false;
                    break;
                case estado.guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnBuscarUsuario.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtDNI.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApPat.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApDir.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTel.Enabled = true;
                    break;
                case estado.editar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnBuscarUsuario.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    yaTieneUsuario = true;
                    txtDNI.Enabled = true;
                    txtNombre.Enabled = true;
                    txtApPat.Enabled = true;
                    txtApMat.Enabled = true;
                    txtApDir.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTel.Enabled = true;
                    yaTieneUsuario = true;
                    break;
            }
        }

        public int verificarDniYTelefono()
        {
            double DoubleR;
            int result = 1;
            int h = txtTel.Text.Length;
            int h2 = txtDNI.Text.Length;
            if ((txtDNI.Text.Length != 8 && Double.TryParse(txtDNI.Text, out DoubleR)) || (txtTel.Text.Length != 9 && Double.TryParse(txtDNI.Text, out DoubleR)))
            {
                if (txtDNI.Text.Length != 8 && Double.TryParse(txtDNI.Text, out DoubleR))
                {
                    lblx1.Text = "*";
                    result = 0;
                }
                if (txtTel.Text.Length != 9 && Double.TryParse(txtDNI.Text, out DoubleR))
                {
                    lblx2.Text = "*";
                    result = 0;
                }
                MessageBox.Show("(*) Uno de los campos ingresados no son válidos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public bool verificarRango(TextBox t, int val)
        {
            if (t.Text.Length <= val)
            {
                return true;
            }
            return false;
        }

        public bool verificarCheckBoxsNoVacios()
        {
            bool esVacio = false;
            if (ckApoderado.Checked || ckAuxiliar.Checked || ckProfesor.Checked || ckSecretaria.Checked || ckAlumno.Checked)
            {
                esVacio = true;
            }
            return esVacio;
        }

        public void guardarDatosAlumno()
        {

            if (verificarRango(txtNombre, 45) && (txtNombre.Text.Length!=0)) { usuario.names = txtNombre.Text; }
            else
            {
                MessageBox.Show("El valor asignado a la casilla es demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbly2.Text = "*";
            }
            if (verificarRango(txtApPat, 45) && (txtApPat.Text.Length != 0)) { usuario.firstLastName = txtApPat.Text; }
            else
            {
                MessageBox.Show("El valor asignado a la casilla es demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbly3.Text = "*";
            }
            if (verificarRango(txtApMat, 45) && (txtApMat.Text.Length != 0)) { usuario.secondLastName = txtApMat.Text; }
            else
            {
                MessageBox.Show("El valor asignado a la casilla es demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbly4.Text = "*";
            }
            if (verificarRango(txtApDir, 45)) { usuario.address = txtApDir.Text; }
            else
            {
                MessageBox.Show("El valor asignado a la casilla es demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbly5.Text = "*";
            }
            if (verificarRango(txtEmail, 45) && (txtApMat.Text.Length != 0) && txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".") && !(txtEmail.Text.Substring(txtEmail.Text.IndexOf("@") + 1, txtEmail.Text.Length).Contains("@")) && !(txtEmail.Text.Substring(txtEmail.Text.IndexOf(".") + 1, txtEmail.Text.Length).Contains(".")))
            {
                usuario.email = txtEmail.Text;
            }
            else 
            {
                MessageBox.Show("El valor asignado a la casilla es demasiado largo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbly6.Text = "*";
            }
            if (verificarCheckBoxsNoVacios())
            {
                if (ckAlumno.Checked)
                {
                    JohanaWS.userType ut = new JohanaWS.userType();
                    ut.idUserType = 4;
                    JohanaWS.insertUserTypeXUser(usuario.idUser,ut.idUserType);
                }
                if (ckApoderado.Checked)
                {
                    JohanaWS.userType ut = new JohanaWS.userType();
                    ut.idUserType = 2;
                    JohanaWS.insertUserTypeXUser(usuario.idUser, ut.idUserType);
                }
                if (ckProfesor.Checked)
                {
                    JohanaWS.userType ut = new JohanaWS.userType();
                    ut.idUserType = 3;
                    JohanaWS.insertUserTypeXUser(usuario.idUser, ut.idUserType);
                }
                if (ckSecretaria.Checked)
                {
                    JohanaWS.userType ut = new JohanaWS.userType();
                    ut.idUserType = 1;
                    JohanaWS.insertUserTypeXUser(usuario.idUser, ut.idUserType);
                }
                if (ckAuxiliar.Checked)
                {
                    JohanaWS.userType ut = new JohanaWS.userType();
                    ut.idUserType = 5;
                    JohanaWS.insertUserTypeXUser(usuario.idUser, ut.idUserType);
                }
            }
            else
            {
                MessageBox.Show("Escoga por lo menos un tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cambiarCheckBoxs()
        {
            if (esAlumno)
            {
                ckApoderado.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckProfesor.Enabled = false;
                ckSecretaria.Enabled = false;
            }
            else
            {
                ckApoderado.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckProfesor.Enabled = true;
                ckSecretaria.Enabled = true;
            }
        }

        private void ckApoderado_CheckedChanged(object sender, EventArgs e)
        {
            esAlumno = false;
            cambiarCheckBoxs();
            
        }

        private void ckAlumno_CheckedChanged(object sender, EventArgs e)
        {
            esAlumno = true;
            cambiarCheckBoxs();
        }

        private void ckProfesor_CheckedChanged(object sender, EventArgs e)
        {
            esAlumno = false;
            cambiarCheckBoxs();
        }
               
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.editar);
            frmBuscarUsuario_secretario fBuscar = new frmBuscarUsuario_secretario();
            if(fBuscar.ShowDialog() == DialogResult.OK)
            {
                fBuscar.usuario = usuario;
                txtDNI.Text = usuario.dni;
                txtNombre.Text = usuario.names; 
                txtApPat.Text = usuario.firstLastName;
                txtApMat.Text = usuario.secondLastName;
                txtEmail.Text = usuario.email;
                txtTel.Text = usuario.cellPhone.toString();
            }
        }

        private void ckSecretaria_CheckedChanged(object sender, EventArgs e)
        {
            esAlumno = false;
            cambiarCheckBoxs();
        }

        private void ckAuxiliar_CheckedChanged(object sender, EventArgs e)
        {
            esAlumno = false;
            cambiarCheckBoxs();
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.guardar);
            if (verificarDniYTelefono() > 0 )
            {
                int r = 0;
                guardarDatosAlumno();
                usuario.userName = generarUsername();
                usuario.password = generarPassword();
                //-r = controller2.insertUser(usuario);
                if (r > 0)
                {
                    EnviarCorreoContraseña(usuario.email, usuario.username, usuario.password);
                }
                else
                {
                    MessageBox.Show("Se ha realizado con exito el registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MessageBox.Show("Se ha realizado con exito el registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //enviarle correo con su usuario y contraseña
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.nuevo);
            txtDNI.Text = "";
            txtNombre.Text="";
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtApDir.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.editar);
            if (verificarDniYTelefono() > 0 )
            {
                guardarDatosAlumno();
                //-r = controller2.updateUser(usuario);
            }
            MessageBox.Show("Se ha realizado con exito la actualización del registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.editar);
            int r = controller.deleteUser(usuario);
            if (r > 0){
                MessageBox.Show("Se ha realizado con exito la eliminación del registro", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha realizado la eliminación del registro correctamente inténtelo nuevamente", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result== DialogResult.Yes)
            {
                int r = 0;
                estadoComponentes(estado.guardar);
                if (verificarDniYTelefono() > 0)
                {
                    guardarDatosAlumno();
                    usuario.userName = generarUsername();
                    usuario.password = generarPassword();
                    //-r = controller2.insertUser(usuario);
                    if (r > 0)
                    {
                        EnviarCorreoContraseña(usuario.email,usuario.username,usuario.password);
                    }
                    else
                    {
                        MessageBox.Show("Se ha realizado con exito el registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                estadoComponentes(estado.nuevo);
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApPat.Text = "";
                txtApMat.Text = "";
                txtApDir.Text = "";
                txtEmail.Text = "";
                txtTel.Text = "";
            }
        }
        /////////////Gestion username y password//////////////////////

        private string generarUsername()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            String digitoAux = (rd.Next(10, 99)).ToString();
            string username = txtNombre.Text + txtApPat.Text.First() + digitoAux;
            return username;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }


        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private string generarPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        
        private void EnviarCorreoContraseña(String email,String username ,String newPassword)
        {
            string password = "mariaalvarado123";
            string message = string.Empty;

            //Creacion del correo electroncio
            string destinatario = email;
            string remitente = "malvarado.colegio@gmail.com";
            string asunto = "Nueva Contraseña Sistema Maria Alvarado";
            string cuerpoDelMensaje = "Su nuevo usuario es "+ username
                                +" y su nueva contraseña es" + " " + newPassword;
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
    }
}
