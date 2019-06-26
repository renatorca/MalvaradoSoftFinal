using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.RegistrarNotas_profesor
{
    public partial class frmListarCursos_profesor : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        frmRegistrarNotas_profesor frmRegistrarNotas;
        private int idTeacher;

        public frmListarCursos_profesor()
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            dgvCursos.AutoGenerateColumns = false;
            //dgvCursos.DataSource = controller.queryAllCourseSchedulesPorIDTeacher(idTeacher);


        }

        public void inicializa(int id)
        {
            this.idTeacher = id;
            dgvCursos.DataSource = controller.queryAllCourseSchedulesPorIDTeacher(idTeacher);
        }


        private void registrarNotas(object sender, DataGridViewCellEventArgs e)
        {

            frmRegistrarNotas = new frmRegistrarNotas_profesor((MAlvaradoWS.courseSchedule)dgvCursos.CurrentRow.DataBoundItem);

            frmRegistrarNotas.ShowDialog();
        }
    }
}
