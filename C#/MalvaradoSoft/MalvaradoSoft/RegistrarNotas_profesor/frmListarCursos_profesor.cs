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

        public frmListarCursos_profesor(int idTeacher)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = controller.queryAllCourseSchedulesPorIDTeacher(idTeacher);


        }

        private void registrarNotas(object sender, DataGridViewCellEventArgs e)
        {

            frmRegistrarNotas = new frmRegistrarNotas_profesor((MAlvaradoWS.courseSchedule)dgvCursos.CurrentRow.DataBoundItem);

            frmRegistrarNotas.ShowDialog();
        }
    }
}
