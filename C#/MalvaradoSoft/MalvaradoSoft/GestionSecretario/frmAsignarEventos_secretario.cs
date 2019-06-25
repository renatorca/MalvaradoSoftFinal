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
    public partial class frmAsignarEventos_secretario : Form
    {
        private MAlvaradoWS.DBControllerWSClient controller;
        private MAlvaradoWS.courseSchedule courseschedule;
        public frmAsignarEventos_secretario(MAlvaradoWS.classSection cs)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            dgvCursosPorSeccion.AutoGenerateColumns = false;
            dgvCursosPorSeccion.DataSource = controller.queryAllCourseScheduleByClassSection(cs.id);
            txtGrado.Text = cs.level.ToString();
            txtSeccion.Text = cs.name;
            txtGrado.Enabled = false;
            txtSeccion.Enabled = false;            
        }

    

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            //curso.course = c;
            //llamar formulario de asignar eventos

            
        }

        private void DgvCursosPorSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            courseschedule = (MAlvaradoWS.courseSchedule)dgvCursosPorSeccion.CurrentRow.DataBoundItem;
            if (e.ColumnIndex == 1)
            {
                MAlvaradoWS.courseSchedule curso = new MAlvaradoWS.courseSchedule();
                MAlvaradoWS.course c = new MAlvaradoWS.course();
                curso.id = 1;
                c.id = 1;
                c.name = "Test";
                curso.course = c;
                frmGestionarEvento frmEvento = new frmGestionarEvento(curso);
                if (frmEvento.ShowDialog() == DialogResult.OK)
                {

                }
            }
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
