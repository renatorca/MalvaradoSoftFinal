using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MalvaradoSoft.MAlvaradoWS;
using MalvaradoSoft.Menu_Principal;

namespace MalvaradoSoft.Login
{
    public partial class frmIniciarTipoUsuario : Form
    {
        private BindingList<MAlvaradoWS.userType> tipo;
        public MAlvaradoWS.user user;
        private int pos_x = 40 , pos_y = 87;

        public BindingList<userType> Permisos { get => tipo; set => tipo = value; }

        public frmIniciarTipoUsuario()
        {
            InitializeComponent();
            estadoInicial();
            tipo = new BindingList<MAlvaradoWS.userType>();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FrmIniciarTipoUsuario_Load(object sender, EventArgs e)
        {
            foreach (userType nTipo in tipo)  
            {
                openPictureBox(nTipo.description);
                pos_x += 176;
            }
            reAllocationButtonsAndForm();
        }
        private void estadoInicial()
        {
            imageSecretario.Visible = false;
            imageProfesor.Visible = false;
            imageApoderado.Visible = false;
            imageAuxiliar.Visible = false;
            lblSecretario.Visible = false;
            lblApoderado.Visible = false;
            lblAuxiliar.Visible = false;
            lblProfesor.Visible = false;
            lblSecretario.Visible = false;
        }

        private void reAllocationButtonsAndForm()
        {
            if (tipo.Count == 2)
            {
                btnCerrarSesion.Location = new Point(220, 240);
                this.Size = new Size(373,342);
            }
            else if (tipo.Count == 3)
            {
                btnCerrarSesion.Location = new Point(370, 240);
                this.Size = new Size(540, 342);
            }
            else if (tipo.Count == 4)
            {
                btnCerrarSesion.Location = new Point(523, 240);
                this.Size = new Size(688, 342);
            }

        }

        private void ImageAuxiliar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal_auxiliar menu = new frmMenuPrincipal_auxiliar();
            menu.User = user;
            menu.FormClosed += Logout;
            menu.Show();
        }

        private void ImageProfesor_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal_profesor menu = new frmMenuPrincipal_profesor();
            menu.User = user;
            menu.FormClosed += Logout;
            menu.Show();
        }

        private void ImageSecretario_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal_Secretario menu = new frmMenuPrincipal_Secretario();
            menu.User = user;
            menu.FormClosed += Logout;
            menu.Show();
        }

        private void ImageApoderado_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal_apoderado menu = new frmMenuPrincipal_apoderado();
            menu.User = user;
            menu.FormClosed += Logout;
            menu.Show();
        }

        private void openPictureBox(string name)
        {
            if (string.Equals(name, "Secretario"))
            {
                imageSecretario.Visible = true;
                imageSecretario.Location = new Point(pos_x,pos_y);
                lblSecretario.Visible = true;
                lblSecretario.Location = new Point(pos_x + 16, pos_y + 103);
            }
            else if (string.Equals(name, "Profesor"))
            {
                imageProfesor.Visible = true;
                imageProfesor.Location = new Point(pos_x, pos_y);
                lblProfesor.Visible = true;
                lblProfesor.Location = new Point(pos_x + 24, pos_y + 103);
            }
            else if (string.Equals(name, "Auxiliar"))
            {
                imageAuxiliar.Visible = true;
                imageAuxiliar.Location = new Point(pos_x, pos_y);
                lblAuxiliar.Visible = true;
                lblAuxiliar.Location = new Point(pos_x + 24, pos_y + 103);
            }
            else if (string.Equals(name, "Apoderado"))
            {
                imageApoderado.Visible = true;
                imageApoderado.Location = new Point(pos_x, pos_y);
                lblApoderado.Visible = true;
                lblApoderado.Location = new Point(pos_x + 13, pos_y + 103);
            }
        }
    }
}
