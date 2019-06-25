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
    public partial class frmAsignarEventos_secretario : Form
    {
        private RenatoCWS.DBControllerWSClient controller;
        private RenatoCWS.courseSchedule courseschedule;
        public frmAsignarEventos_secretario(RenatoCWS.classSection cs)
        {
            InitializeComponent();
            controller = new RenatoCWS.DBControllerWSClient();
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
            courseschedule = (RenatoCWS.courseSchedule)dgvCursosPorSeccion.CurrentRow.DataBoundItem;
            if (e.ColumnIndex == 1)
            {
                RenatoCWS.courseSchedule curso = new RenatoCWS.courseSchedule();
                RenatoCWS.course c = new RenatoCWS.course();
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
    }
}
