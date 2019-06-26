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
    public partial class frmGestionarCursos_secretario : Form
    {
        private MAlvaradoWS.DBControllerWSClient controller;
        private MAlvaradoWS.course c = new MAlvaradoWS.course();
        public frmGestionarCursos_secretario()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            controller = new MAlvaradoWS.DBControllerWSClient();
            
            BindingList<int> grados = new BindingList<int>();
            grados.Add(1);
            grados.Add(2);
            grados.Add(3);
            grados.Add(4);
            grados.Add(5);
            grados.Add(6);
            cmbLevel.DataSource = grados;
            dgvCursos.DataSource = controller.queryAllCourses();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            int level = Int32.Parse(cmbLevel.Text);
            dgvCursos.DataSource = controller.queryAllCourseByLevel(level);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //para invocar a gestionarTipoNota se le pasa un Curso
            frmGestionarTipoNota_secretario frmGestionarTipoNota = new frmGestionarTipoNota_secretario(c);
            if (frmGestionarTipoNota.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarCurso_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de que desea eliminar el curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msg == DialogResult.Yes)
            {
                MAlvaradoWS.course curso;
                curso = (MAlvaradoWS.course)dgvCursos.CurrentRow.DataBoundItem;
                controller.deleteCourse(curso.id);
                dgvCursos.DataSource = controller.queryAllCourses();
                MessageBox.Show("Se eliminó el curso correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de que desea agregar un curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (msg == DialogResult.Yes)
            {
                MAlvaradoWS.course curso = new MAlvaradoWS.course();
                curso.name = txtName.Text;
                curso.level = Int32.Parse(cmbLevel.Text);
                controller.insertCourse(curso);
                dgvCursos.DataSource = controller.queryAllCourses();
                MessageBox.Show("Se registró el curso correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MAlvaradoWS.course curso;
            curso = (MAlvaradoWS.course)dgvCursos.CurrentRow.DataBoundItem;
            txtName.Text = curso.name;
            cmbLevel.Text = curso.level.ToString();
            c = curso;
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            c.name = txtName.Text;
            c.level = Int32.Parse(cmbLevel.Text);
            controller.updateCourse(c);
            dgvCursos.DataSource = controller.queryAllCourses();
        }
    }
}
