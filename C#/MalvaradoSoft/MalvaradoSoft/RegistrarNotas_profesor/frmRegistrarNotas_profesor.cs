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

        private Object[,] data;
        private bool editado;
        private bool lleno;




        private frmRegistrarFeedback_profesor feed;

        public frmRegistrarNotas_profesor(MAlvaradoWS.courseSchedule courseSchedule)
        {
            InitializeComponent();
            lleno = false;
            this.txtCourse.Text = courseSchedule.course.name;
            this.txtLevel.Text = courseSchedule.course.level.ToString();
            this.txtSection.Text = courseSchedule.classSection.name.ToString();
            controller = new MAlvaradoWS.DBControllerWSClient();
            this.courseScheduleSelected = courseSchedule;

            editado = false;
            grades = new BindingList<MAlvaradoWS.grade> (controller.queryAllGradesByIDCourse(courseScheduleSelected.course.id));


            
            cboAno.DataSource = controller.queryAllY();
            cboAno.DisplayMember = "yearJoel";
            MAlvaradoWS.year y;      
            cboBimestre.DataSource = controller.queryAllB();
            cboBimestre.DisplayMember = "valorBimester";


            dgvRegistroNotas.ColumnCount = grades.Count + 1;
            dgvRegistroNotas.Columns[0].Name = "name";
            dgvRegistroNotas.Columns[0].HeaderText = "Nombre";
            dgvRegistroNotas.Columns[0].ReadOnly = true;
            int i = 1;

            foreach (MAlvaradoWS.grade g in grades)
            {
                dgvRegistroNotas.Columns[i].Name = g.idGrade.ToString();
                dgvRegistroNotas.Columns[i].HeaderText = g.description;
                dgvRegistroNotas.Columns[i].DataPropertyName = "value_";                
                i++;
            }


        }

        private void ingresarFeedback(object sender, DataGridViewCellEventArgs e)
        {
            MAlvaradoWS.gradeXStudent gxs = (MAlvaradoWS.gradeXStudent)(data[e.RowIndex,e.ColumnIndex] );
            feed = new frmRegistrarFeedback_profesor(gxs);
            feed.ShowDialog();
        }

        private void btnBuscarAlumnos_Click(object sender, EventArgs e)
        {
            lleno = false;
            dgvRegistroNotas.Rows.Clear();
            dgvRegistroNotas.Refresh();

            this.idYear = ((MAlvaradoWS.year)cboAno.SelectedItem).idYear;
            this.idBimester = ((MAlvaradoWS.bimester)cboBimestre.SelectedItem).idBimester;

            students = new BindingList<MAlvaradoWS.bimesterXStudentXYear>(controller.queryAllBimesterXStudentXYear(
                courseScheduleSelected.id, this.idYear, this.idBimester)); //, courseScheduleSelected.classSection.id));

            data = new Object[students.Count, dgvRegistroNotas.ColumnCount];


            int i = 0;
            int j = 1;

            foreach (MAlvaradoWS.bimesterXStudentXYear s in students)
            {
                //List<Object> row = new List<Object>(dgvRegistroNotas.ColumnCount);
                Object[] row = new Object[dgvRegistroNotas.ColumnCount];
                

                row[0] = (s.student.names + " " + s.student.firstLastName + " " + s.student.secondLastName);

                
                foreach (MAlvaradoWS.gradeXStudent gxs in s.gradeXStudents)
                {
                    int ind = dgvRegistroNotas.Columns[gxs.grade.idGrade.ToString()].Index;
                    row[ind] = gxs.value_;
                    data[i, j] = gxs;
                    j++;
                }
                dgvRegistroNotas.Rows.Add(row);
                i++;
            }
            lleno = true;
        }

        private void editarNota(object sender, DataGridViewCellEventArgs e)
        {
            if (lleno)
            {
                int i;
                int j;
                editado = true;
                Point celda = this.dgvRegistroNotas.CurrentCellAddress;
                double anteriorNota = (((MAlvaradoWS.gradeXStudent)data[e.RowIndex, e.ColumnIndex]).value_);
                double nuevaNota;
                if (Double.TryParse(dgvRegistroNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out nuevaNota) &&
                    nuevaNota >=0 && nuevaNota<=20)
                {
                    (((MAlvaradoWS.gradeXStudent)data[e.RowIndex, e.ColumnIndex]).value_) = nuevaNota;
                }
                else
                {
                    //(((MAlvaradoWS.gradeXStudent)data[e.RowIndex, e.ColumnIndex]).value_) = anteriorNota;
                    dgvRegistroNotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = anteriorNota;
                    MessageBox.Show("Por favor ingrese un valor valido para la nota, entre 0 y 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            //((MAlvaradoWS.gradeXStudent)data[celda.X, celda.Y]).value_ = 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.guardarTodo();      

        }

        private void guardarTodo()
        {
            if (editado)
            {

                for (int i = 0; i < dgvRegistroNotas.RowCount; ++i)
                {
                    for (int j = 1; j < dgvRegistroNotas.ColumnCount; ++j)
                    {
                        MAlvaradoWS.gradeXStudent aux = new MAlvaradoWS.gradeXStudent();
                        aux = (MAlvaradoWS.gradeXStudent)data[i, j];

                        controller.updateGradeXStudent(aux);

                    }
                }

                editado = false;
            }
            MessageBox.Show("Cambios guardados con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
            
        

        private void confirmarSalida(object sender, FormClosingEventArgs e)
        {
            
            if(editado  )
            {
                DialogResult r = MessageBox.Show("¿Desea guardar los cambios antes de salir?", "¿Guardar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                editado = false;
                if(r == DialogResult.Yes)
                    this.guardarTodo();
            }
            
    
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
