using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Configuracion
{
    public partial class frmMenuConfiguracion_todos : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        private MAlvaradoWS.user user;

        public frmMenuConfiguracion_todos(MAlvaradoWS.user user_)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            user = user_;
        }

        public frmMenuConfiguracion_todos()
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            user = new MAlvaradoWS.user();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditarContraseña_Click(object sender, EventArgs e)
        {
            btnEditUserName.Enabled = false;
            btnEditCorreo.Enabled = false;
            btnEditCelular.Enabled = false;
            btnEditDni.Enabled = false;
            btnEditNombre.Enabled = false;
            linea6.Location = new Point(263, 355);

            txtContraseña.Location = new Point(456, 280); txtContraseña.Visible = true;
            txtConfirmarContraseña.Location = new Point(456, 306); txtConfirmarContraseña.Visible = true;
            btnGuardarContraseña.Location = new Point(456, 332); btnGuardarContraseña.Visible = true;
            btnCancelarContraseña.Location = new Point(590, 332); btnCancelarContraseña.Visible = true;
        }

        private void BtnEditNombre_Click(object sender, EventArgs e)
        {
            btnEditUserName.Enabled = false;
            btnEditCorreo.Enabled = false;
            btnEditCelular.Enabled = false;
            btnEditDni.Enabled = false;
            btnEditContraseña.Enabled = false;                        

            //Muevo todo los demas labels
            linea1.Location = new Point(263, 100);
            linea2.Location = new Point(263, 147);
            linea3.Location = new Point(263, 194);
            linea4.Location = new Point(263, 239);
            linea5.Location = new Point(263, 288);
            linea6.Location = new Point(263, 335);

            //btnEditNombre.Location = new Point(695,70);
            btnEditUserName.Location = new Point(695, 124);
            btnEditCorreo.Location = new Point(695, 171);
            btnEditCelular.Location = new Point(695, 216);
            btnEditDni.Location = new Point(695, 265);
            btnEditContraseña.Location = new Point(695, 312);

            //lblNombre.Location = new Point(453,67);
            lblNombreUsuario.Location = new Point(453, 124);
            lblCorreo.Location = new Point(453, 171);
            lblTelefono.Location = new Point(453, 216);
            lblDni.Location = new Point(453, 265);
            lblContraseña.Location = new Point(453, 312);

            label2.Location = new Point(260, 124);
            label3.Location = new Point(260, 171);
            label5.Location = new Point(260, 216);
            label8.Location = new Point(260, 265);
            label9.Location = new Point(260, 312);

            txtNombre.Location = new Point(263, 41); txtNombre.Visible = true;
            txtApPaterno.Location = new Point(420, 41); txtApPaterno.Visible = true;
            txtApMaterno.Location = new Point(577, 41); txtApMaterno.Visible = true;
            btnGuardarNombre.Location = new Point(466, 64); btnGuardarNombre.Visible = true;
            btnCancelarNombre.Location = new Point(600, 64); btnCancelarNombre.Visible = true;

        }

        private void BtnEditUserName_Click(object sender, EventArgs e)
        {            
            btnEditNombre.Enabled = false;
            btnEditCorreo.Enabled = false;
            btnEditCelular.Enabled = false;
            btnEditDni.Enabled = false;
            btnEditContraseña.Enabled = false;

            linea2.Location = new Point(263, 147);
            linea3.Location = new Point(263, 194);
            linea4.Location = new Point(263, 239);
            linea5.Location = new Point(263, 288);
            linea6.Location = new Point(263, 335);

            btnEditCorreo.Location = new Point(695, 171);
            btnEditCelular.Location = new Point(695, 216);
            btnEditDni.Location = new Point(695, 265);
            btnEditContraseña.Location = new Point(695, 312);

            lblCorreo.Location = new Point(453, 171);
            lblTelefono.Location = new Point(453, 216);
            lblDni.Location = new Point(453, 265);
            lblContraseña.Location = new Point(453, 312);

            label3.Location = new Point(260, 171);
            label5.Location = new Point(260, 216);
            label8.Location = new Point(260, 265);
            label9.Location = new Point(260, 312);

            txtNombreUsuario.Location = new Point(456, 92); txtNombreUsuario.Visible = true;
            btnGuardarNombreUsuario.Location = new Point(459, 118); btnGuardarNombreUsuario.Visible = true;
            btnCancelarNombreUsuario.Location = new Point(593, 118); btnCancelarNombreUsuario.Visible = true;
        }

        private void BtnEditCorreo_Click(object sender, EventArgs e)
        {
            btnEditUserName.Enabled = false;
            btnEditNombre.Enabled = false;
            btnEditCelular.Enabled = false;
            btnEditDni.Enabled = false;
            btnEditContraseña.Enabled = false;

            linea3.Location = new Point(263, 194);
            linea4.Location = new Point(263, 239);
            linea5.Location = new Point(263, 288);
            linea6.Location = new Point(263, 335);

            btnEditCelular.Location = new Point(695, 216);
            btnEditDni.Location = new Point(695, 265);
            btnEditContraseña.Location = new Point(695, 312);

            lblTelefono.Location = new Point(453, 216);
            lblDni.Location = new Point(453, 265);
            lblContraseña.Location = new Point(453, 312);

            label5.Location = new Point(260, 216);
            label8.Location = new Point(260, 265);
            label9.Location = new Point(260, 312);

            txtCorreo.Location = new Point(456, 135); txtCorreo.Visible = true;
            btnGuardarCorreo.Location = new Point(459, 166); btnGuardarCorreo.Visible = true;
            btnCancelarCorreo.Location = new Point(593, 166); btnCancelarCorreo.Visible = true;
        }

        private void BtnEditCelular_Click(object sender, EventArgs e)
        {
            btnEditUserName.Enabled = false;
            btnEditCorreo.Enabled = false;
            btnEditNombre.Enabled = false;
            btnEditDni.Enabled = false;
            btnEditContraseña.Enabled = false;

            linea4.Location = new Point(263, 239);
            linea5.Location = new Point(263, 288);
            linea6.Location = new Point(263, 335);

            btnEditDni.Location = new Point(695, 265);
            btnEditContraseña.Location = new Point(695, 312);

            lblDni.Location = new Point(453, 265);
            lblContraseña.Location = new Point(453, 312);

            label8.Location = new Point(260, 265);
            label9.Location = new Point(260, 312);

            txtCelular.Location = new Point(456, 182); txtCelular.Visible = true;
            btnGuardarCelular.Location = new Point(459, 208); btnGuardarCelular.Visible = true;
            btnCancelarCelular.Location = new Point(593, 208); btnCancelarCelular.Visible = true;
        }

        private void BtnEditDni_Click(object sender, EventArgs e)
        {
            btnEditUserName.Enabled = false;
            btnEditCorreo.Enabled = false;
            btnEditCelular.Enabled = false;
            btnEditNombre.Enabled = false;
            btnEditContraseña.Enabled = false;

            linea5.Location = new Point(263, 288);
            linea6.Location = new Point(263, 335);

            btnEditContraseña.Location = new Point(695, 312);

            lblContraseña.Location = new Point(453, 312);

            label9.Location = new Point(260, 312);

            txtDni.Location = new Point(456, 229); txtDni.Visible = true;
            btnGuardarDni.Location = new Point(456, 255); btnGuardarDni.Visible = true;
            btnCancelarDni.Location = new Point(593, 255); btnCancelarDni.Visible = true;
        }

        private void posicionesIniciales()
        {
            linea1.Location = new Point(263, 45);
            linea2.Location = new Point(263, 92);
            linea3.Location = new Point(263, 139);
            linea4.Location = new Point(263, 186);
            linea5.Location = new Point(263, 233);
            linea6.Location = new Point(263, 280);

            btnEditUserName.Location = new Point(695, 64);
            btnEditCorreo.Location = new Point(695, 111);
            btnEditCelular.Location = new Point(695, 156);
            btnEditDni.Location = new Point(695, 205);
            btnEditContraseña.Location = new Point(695, 252);

            lblNombreUsuario.Location = new Point(453, 64);
            lblCorreo.Location = new Point(453, 111);
            lblTelefono.Location = new Point(453, 156);
            lblDni.Location = new Point(453, 205);
            lblContraseña.Location = new Point(453, 252);

            label2.Location = new Point(260, 64);
            label3.Location = new Point(260, 111);
            label5.Location = new Point(260, 156);
            label8.Location = new Point(260, 205);
            label9.Location = new Point(260, 252);

            txtNombre.Visible = false;
            txtApPaterno.Visible = false;
            txtApMaterno.Visible = false;
            btnGuardarNombre.Visible = false;
            btnCancelarNombre.Visible = false;

            txtNombreUsuario.Visible = false;
            btnGuardarNombreUsuario.Visible = false;
            btnCancelarNombreUsuario.Visible = false;

            txtCorreo.Visible = false;
            btnGuardarCorreo.Visible = false;
            btnCancelarCorreo.Visible = false;

            txtCelular.Visible = false;
            btnGuardarCelular.Visible = false;
            btnCancelarCelular.Visible = false;

            txtDni.Visible = false;
            btnGuardarDni.Visible = false;
            btnCancelarDni.Visible = false;

            txtContraseña.Visible = false;
            txtConfirmarContraseña.Visible = false;
            btnGuardarContraseña.Visible = false;
            btnCancelarContraseña.Visible = false;

            btnEditNombre.Enabled = true;
            btnEditUserName.Enabled = true;
            btnEditCorreo.Enabled = true;
            btnEditCelular.Enabled = true;
            btnEditDni.Enabled = true;
            btnEditContraseña.Enabled = true;

            txtNombre.Text = "Nombres";
            txtDni.Text = "Dni";
            txtCorreo.Text = "Correo electrónico";
            txtContraseña.Text = "Nueva contraseña";
            txtConfirmarContraseña.Text = "Nueva contraseña";
            txtApMaterno.Text = "Apellido Materno";
            txtApPaterno.Text = "Apellido Paterno";
        }
        private void BtnCancelarNombre_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
        }

        private void BtnCancelarNombreUsuario_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
        }

        private void BtnCancelarCorreo_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
        }

        private void BtnCancelarCelular_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
        }

        private void BtnCancelarDni_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
        }

        private void BtnCancelarContraseña_Click(object sender, EventArgs e)
        {
            posicionesIniciales();
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

        private void BtnGuardarNombre_Click(object sender, EventArgs e)
        {
            user.names = txtNombre.Text;
            user.firstLastName = txtApPaterno.Text;
            user.secondLastName = txtApMaterno.Text;
            controller.updateUser(user);
            lblNombre.Text = txtNombre.Text +" " + txtApPaterno.Text + " " + txtApMaterno.Text;


        }

        private void BtnGuardarNombreUsuario_Click(object sender, EventArgs e)
        {
            user.username = txtNombreUsuario.Text;
            controller.updateUser(user);
            lblNombreUsuario.Text = txtNombreUsuario.Text;
        }

        private void BtnGuardarCorreo_Click(object sender, EventArgs e)
        {
            user.email = txtCorreo.Text;
            controller.updateUser(user);
            lblCorreo.Text = txtCorreo.Text; 
        }

        private void BtnGuardarCelular_Click(object sender, EventArgs e)
        {
            user.cellPhone = Int32.Parse(txtCelular.Text);
            controller.updateUser(user);
            lblTelefono.Text = txtCelular.Text;
        }

        private void BtnGuardarDni_Click(object sender, EventArgs e)
        {
            user.dni = txtDni.Text;
            controller.updateUser(user);
        }
        private void estadoInicial()
        {
            txtConfirmarContraseña.Text = "Nueva contraseña";
            txtContraseña.Text = "Nueva contraseña";
            txtConfirmarContraseña.ForeColor = System.Drawing.Color.DimGray;
            txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            txtConfirmarContraseña.UseSystemPasswordChar = false;
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void BtnGuardarContraseña_Click(object sender, EventArgs e)
        {
            if (String.Equals(txtConfirmarContraseña.Text, txtContraseña.Text))
            {
                if (!esContraseñaSegura(txtConfirmarContraseña.Text))
                {
                    MessageBox.Show("Contraseña muy debil.");
                    estadoInicial();
                }
                else
                {
                    controller.updatePasswordUser(user.email, txtConfirmarContraseña.Text);
                    MessageBox.Show("Se ha actualizado su contraseña satisfactoriamente.");
                }
            }
            else
            {
                MessageBox.Show("Las constraseñas no coinciden.");
            }
            controller.updateUser(user);
        }

        private void TxtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarContraseña.UseSystemPasswordChar = true;
        }

        private void TxtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "")
            {
                txtConfirmarContraseña.Text = "Nueva contraseña";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;

            }
        }

        private void TxtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Text == "Nueva contraseña")
            {
                txtConfirmarContraseña.Text = "";
                txtConfirmarContraseña.ForeColor = Color.DimGray;
                txtConfirmarContraseña.UseSystemPasswordChar = false;
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

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Nueva contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void TxtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.DimGray;
            }
        }

        private void TxtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.DimGray;
            }
        }

        private void TxtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Celular";                
            }
        }

        private void TxtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Text == "Celular")
            {
                txtCelular.Text = "";
                txtCelular.ForeColor = Color.DimGray;
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Correo electronico";
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

        private void TxtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Nombre de usuario";
            }
        }

        private void TxtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "Nombre de Usuario")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Nombre";
            }
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void TxtApPaterno_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Apellido paterno";
            }
        }

        private void TxtApPaterno_Enter(object sender, EventArgs e)
        {
            if (txtApPaterno.Text == "Apellido Paterno")
            {
                txtApPaterno.Text = "";
                txtApPaterno.ForeColor = Color.DimGray;
            }
        }

        private void TxtApMaterno_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "Apellido materno";
            }
        }

        private void TxtApMaterno_Enter(object sender, EventArgs e)
        {
            if (txtApMaterno.Text == "Apellido Materno")
            {
                txtApMaterno.Text = "";
                txtApMaterno.ForeColor = Color.DimGray;
            }
        }

        private void FrmMenuConfiguracion_todos_Load(object sender, EventArgs e)
        {
            lblNombre.Text = user.names + " " + user.firstLastName + " " + user.secondLastName;
            lblCorreo.Text = user.email;
            lblDni.Text = user.dni;
            lblNombreUsuario.Text = user.username;
            lblTelefono.Text = user.cellPhone.ToString();
            lblContraseña.Text = "************";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
