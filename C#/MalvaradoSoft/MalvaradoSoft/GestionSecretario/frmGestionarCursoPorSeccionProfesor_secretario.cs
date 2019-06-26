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
    public partial class frmGestionarCursoPorSeccionProfesor_secretario : Form
    {
        MAlvaradoWS.courseSchedule curso = new MAlvaradoWS.courseSchedule();
        MAlvaradoWS.classSection classSection = new MAlvaradoWS.classSection();
        MAlvaradoWS.DBControllerWSClient controller;
        MAlvaradoWS.teacherXYear txy = new MAlvaradoWS.teacherXYear();
        BindingList<MAlvaradoWS.courseSchedule> courseSchedules;
        BindingList<MAlvaradoWS.course> courses;
        public frmGestionarCursoPorSeccionProfesor_secretario(MAlvaradoWS.classSection cs)
        {
            InitializeComponent();
            classSection = cs;
            controller = new MAlvaradoWS.DBControllerWSClient();
            txtGrado.Text = cs.level.ToString();
            txtSeccion.Text = cs.name;
            txtSeccion.Enabled = false;
            txtGrado.Enabled = false;
            dgvCursosPorGrado.AutoGenerateColumns = false;
            //dgvCursosPorGrado.DataSource = controller.queryAllCourseByLevel(cs.level);
            courses = new BindingList<MAlvaradoWS.course>(controller.queryAllCourseByLevel(cs.level));
            courseSchedules = new BindingList<MAlvaradoWS.courseSchedule>();

            foreach(MAlvaradoWS.course c in courses)
            {
                MAlvaradoWS.courseSchedule aux = new MAlvaradoWS.courseSchedule();
                aux.course = c;
                courseSchedules.Add(aux);

            }
            dgvCursosPorGrado.DataSource = courseSchedules;
            
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



        private void dgvCursosPorGrado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                curso = (MAlvaradoWS.courseSchedule)dgvCursosPorGrado.CurrentRow.DataBoundItem;
                frmAsignarProfesor_secretario frmAsignarProfesor = new frmAsignarProfesor_secretario(classSection, curso);
                if (frmAsignarProfesor.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
