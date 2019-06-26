using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.GestionSecretario
{
    public partial class frmGestionarUsuario_secretario : Form
    {
        public frmGestionarUsuario_secretario()
        {
            InitializeComponent();
            this.Height = 410;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Instancia del usuario
            //User u = new User();
            //if (u is Profesor)
            //u.Department = (Department)cboEspecialidades.SelectedItem;
            //u.student.Dni = txtDNI.Text;
            MessageBox.Show("Se ha realizado con exito el registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ckApoderado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckApoderado.Checked == true)
            {
                //this.tabApoderado.Parent = this.tabUsers;
                ckAlumno.Enabled = false;
                this.Height = 764;
            }
            else
            {
                ckAlumno.Enabled = true;
                
            }
        }

        private void ckAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAlumno.Checked == true)
            {
                ckApoderado.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckProfesor.Enabled = false;
                ckSecretaria.Enabled = false;
                this.Height = 764;
            }
            else
            {
                ckApoderado.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckProfesor.Enabled = true;
                ckSecretaria.Enabled = true;
                this.Height = 410;
            }
        }

        private void ckProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckProfesor.Checked == true)
            {
                //this.tabProfesor.Parent = this.tabUsers;
                ckAlumno.Enabled = false;
                if (ckApoderado.Checked == true)
                {
                    this.Height = 764;
                }
                else
                {
                    this.Height = 410;
                }
            }
            else
            {
                ckAlumno.Enabled = true;
                //this.tabProfesor.Parent = null;
            }
        }

        private void BuscarAlumno_Click(object sender, EventArgs e)
        {
            //frmBuscarUsuario_secretario fbuscarA = new frmBuscarUsuario_secretario();
            //if (fbuscarA.ShowDialog() == DialogResult.OK)
            //{
            //    //Editar los parametros de los textBox según el alumno elegido

            //}
        }

        private void buscarApoderado_Click(object sender, EventArgs e)
        {
            //frmBuscarUsuario_secretario fbuscarAp = new frmBuscarUsuario_secretario();
            //if (fbuscarAp.ShowDialog() == DialogResult.OK)
            //{
            //    //Editar los parametros de los textBox según el alumno elegido

            //}
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarUs_Click(object sender, EventArgs e)
        {
            //frmBuscarUsuario_secretario fbuscar = new frmBuscarUsuario_secretario();
            //if (fbuscar.ShowDialog() == DialogResult.OK)
            {
                //Editar los parametros de los textBox según el usuario elegido

            }
        }
    }
}
