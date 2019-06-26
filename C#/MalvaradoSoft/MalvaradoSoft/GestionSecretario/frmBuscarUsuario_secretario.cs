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
    public partial class frmBuscarUsuario_secretario : Form
    {
        public JohanaWS.DBControleWSClient controller;
        public JohanaWS.user usuario;

        public frmBuscarUsuario_secretario()
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.queryAllUsers();
        }

        public frmBuscarUsuario_secretario(Johana.user usuario)
        {
            InitializeComponent();
            dataGridView1.DataSource = controller.queryAllUsers();
            if (usuario != null) { this.usuario = usuario; }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

         public void verificarCheckBoxs()
        {
            if (ckAlumno.Checked)
            {
                JohanaWS.userType ut = new JohanaWS.userType();
                ut.idUserType = 4;
                JohanaWS.queryAllUserByUserType(usuario.idUser, ut.idUserType);
                ckApoderado.Enabled = false;
                ckProfesor.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckSecretaria.Enabled = false;
            }
            else
            {
                ckApoderado.Enabled = true;
                ckProfesor.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckSecretaria.Enabled = true;
            }
            if (ckApoderado.Checked)
            {
                JohanaWS.userType ut = new JohanaWS.userType();
                ut.idUserType = 2;
                JohanaWS.queryAllUserByUserType(usuario.idUser, ut.idUserType);
                ckAlumno.Enabled = false;
                ckProfesor.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckSecretaria.Enabled = false;
            }
            else
            {
                ckAlumno.Enabled = true;
                ckProfesor.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckSecretaria.Enabled = true;
            }
            if (ckProfesor.Checked)
            {
                JohanaWS.userType ut = new JohanaWS.userType();
                ut.idUserType = 3;
                JohanaWS.queryAllUserByUserType(usuario.idUser, ut.idUserType);
                ckAlumno.Enabled = false;
                ckApoderado.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckSecretaria.Enabled = false;
            }
            else
            {
                ckAlumno.Enabled = true;
                ckApoderado.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckSecretaria.Enabled = true;
            }
            if (ckSecretaria.Checked)
            {
                JohanaWS.userType ut = new JohanaWS.userType();
                ut.idUserType = 1;
                JohanaWS.queryAllUserByUserType(usuario.idUser, ut.idUserType);
                ckAlumno.Enabled = false;
                ckApoderado.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckProfesor.Enabled = false;
            }
            else
            {
                ckAlumno.Enabled = true;
                ckProfesor.Enabled = true;
                ckAuxiliar.Enabled = true;
                ckApoderado.Enabled = true;
            }
            if (ckAuxiliar.Checked)
            {
                JohanaWS.userType ut = new JohanaWS.userType();
                ut.idUserType = 5;
                JohanaWS.queryAllUserByUserType(usuario.idUser, ut.idUserType);
                ckAlumno.Enabled = false;
                ckApoderado.Enabled = false;
                ckAuxiliar.Enabled = false;
                ckProfesor.Enabled = false;
            }
            else
            {
                ckAlumno.Enabled = true;
                ckProfesor.Enabled = true;
                ckApoderado.Enabled = true;
                ckSecretaria.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            verificarCheckBoxs();
            if(textBox1.Text.Length != 0)
            {
                dataGridView1.DataSource = controller.queryAllUsersBySecondLastName(textBox1.Text);
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            if(textBox2.Text.Length != 0)
            {
                dataGridView1.DataSource = controller.queryAllUsersByFirstLastName(textBox2.Text);
                textBox1.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
            if(textBox3.Text.Length != 0)
            {
                dataGridView1.DataSource = controller.queryAllUsersBySecondLastName(textBox3.Text);
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox4.Enabled = false;
            }
            if(textBox4.Text.Length != 0)
            {
                dataGridView1.DataSource = controller.queryAllUsersBySecondLastName(textBox4.Text);
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox1.Enabled = false;
            }

        }
    }
}
