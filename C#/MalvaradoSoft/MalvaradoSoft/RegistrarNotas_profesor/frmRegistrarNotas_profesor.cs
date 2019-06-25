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
    public partial class frmRegistrarNotas_profesor : Form
    {
        private MAlvaradoWS.user professor;
        private MAlvaradoWS.courseSchedule courseScheduleSelected;
        private BindingList<MAlvaradoWS.courseSchedule> courseSchedules;
        private MAlvaradoWS.DBControllerWSClient controller;
        private BindingList<MAlvaradoWS.grade> grades;
        private BindingList<MAlvaradoWS.bimesterXStudentXYear> students;
        private int idYear;
        private int idBimester;


        private frmRegistrarFeedback_profesor feed;

        public frmRegistrarNotas_profesor(MAlvaradoWS.courseSchedule courseSchedule)
        {
            InitializeComponent();
            this.txtCourse.Text = courseSchedule.course.name;
            this.txtLevel.Text = courseSchedule.course.level.ToString();
            this.txtSection.Text = courseSchedule.classSection.name.ToString();
            MAlvaradoWS.DBControllerWSClient controller = new MAlvaradoWS.DBControllerWSClient();
            this.courseScheduleSelected = courseSchedule;

            grades = new BindingList<MAlvaradoWS.grade>(controller.queryAllGradesByIDCourse(courseScheduleSelected.course.id));

            //cboAno.DataSource = controller.queryAllYears_();
            cboAno.DisplayMember = "year";
            //cboBimestre.DataSource = controller.queryAllBimesters_();

            dgvRegistroNotas.ColumnCount = grades.Count + 1;
            dgvRegistroNotas.Columns[0].Name = "name";
            dgvRegistroNotas.Columns[0].HeaderText = "Nombre";
            int i = 1;

            foreach (MAlvaradoWS.grade g in grades)
            {
                dgvRegistroNotas.Columns[i].Name = g.idGrade.ToString();
                dgvRegistroNotas.Columns[i].HeaderText = g.description;
                dgvRegistroNotas.Columns[i].DataPropertyName = "value";
                i++;
            }


        }

        private void ingresarFeedback(object sender, DataGridViewCellEventArgs e)
        {
            feed = new frmRegistrarFeedback_profesor();
            feed.ShowDialog();
        }

        private void btnBuscarAlumnos_Click(object sender, EventArgs e)
        {
            this.idYear = ((MAlvaradoWS.year)cboAno.SelectedItem).idYear;
            this.idBimester = ((MAlvaradoWS.bimester)cboBimestre.SelectedItem).idBimester;

            students = new BindingList<MAlvaradoWS.bimesterXStudentXYear>(controller.queryAllBimesterXStudentXYear(
                courseScheduleSelected.id, this.idYear, this.idBimester, courseScheduleSelected.classSection.id));

            foreach (MAlvaradoWS.bimesterXStudentXYear s in students)
            {
                List<Object> row = new List<Object>(dgvRegistroNotas.ColumnCount);
                row[0] = (s.student.names + " " + s.student.firstLastName + " " + s.student.secondLastName);
                foreach (MAlvaradoWS.gradeXStudent gxs in s.gradeXStudents)
                {
                    int ind = dgvRegistroNotas.Columns[gxs.grade.idGrade.ToString()].Index;
                    row[ind] = gxs;
                }
                dgvRegistroNotas.Rows.Add(row);

            }

        }
    }
}
