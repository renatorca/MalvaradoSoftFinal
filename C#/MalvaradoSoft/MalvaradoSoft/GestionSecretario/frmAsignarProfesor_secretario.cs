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

namespace MalvaradoSoft.GestionSecretario
{
    public partial class frmAsignarProfesor_secretario : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        MAlvaradoWS.courseSchedule course = new MAlvaradoWS.courseSchedule();
        MAlvaradoWS.teacherXYear teacher = new MAlvaradoWS.teacherXYear();
        public frmAsignarProfesor_secretario(MAlvaradoWS.classSection cs, MAlvaradoWS.courseSchedule c)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            //teacher = t;
            course = c;
            txtNombre.Text = c.course.name;
            txtNombre.Enabled = false;
            txtGrado.Text = cs.level.ToString();
            txtGrado.Enabled = false;
            txtSeccion.Text = cs.name;
            txtSeccion.Enabled = false;
            dgvProfesores.DataSource = controller.queryAllUsersByIdUserType(3);
        }

     

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarProfesor_Click(object sender, EventArgs e)
        {
            MAlvaradoWS.year year = new MAlvaradoWS.year();
            System.DateTime moment = new System.DateTime();
            year = controller.queryAllYearsByYear(moment.Year);
            bool seleccion = false;
            MAlvaradoWS.teacherXYear txy = new MAlvaradoWS.teacherXYear();
            for(int i=0; i<dgvProfesores.Rows.Count-1; i++)
            {
                seleccion = (bool)dgvProfesores.Rows[i].Cells[1].Value;
                if (seleccion == true)
                {
                    MAlvaradoWS.user user;
                    user = (MAlvaradoWS.user)dgvProfesores.CurrentRow.DataBoundItem;
                    txy.idTeacherXYear = user.idUser;
                    txy.year = year;
                    txy.names = user.names;
                    teacher = txy;

                    break;
                }
            }
            if (seleccion)
            {
               
            }
            
        }
    }
}
