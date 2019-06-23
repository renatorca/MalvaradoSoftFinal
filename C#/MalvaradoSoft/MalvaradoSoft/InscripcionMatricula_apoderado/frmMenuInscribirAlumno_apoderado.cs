using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.InscripcionMatricula_apoderado
{
    public partial class frmMenuInscribirAlumno_apoderado : Form
    {
        public frmMenuInscribirAlumno_apoderado()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            //BindingList<Student> studentList = controller.queryAllStudentsByGuardian(user);
        }

        /*public frmMenuInscribirAlumno_apoderado(User user)
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            //BindingList<Student> studentList = controller.queryAllStudentsByGuardian(user);
        }*/

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirAlumno_apoderado frmIns = new frmInscribirAlumno_apoderado();
            if (frmIns.ShowDialog() == DialogResult.OK)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void dgvAlumnosInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = dgvAlumnosInscritos.CurrentCell.ColumnIndex;
            //_student.DNI= dgvAlumnosInscritos.Rows[posActual].Cells[0].Value;

            //if(posActual)

            if(e.ColumnIndex == 4 )//&& e.RowIndex < studentList.Lenght)
            {
                frmGestionarIntencionMatricula_apoderado frmInt = new frmGestionarIntencionMatricula_apoderado();
                if (frmInt.ShowDialog() == DialogResult.OK)
                {

                }
            }
            //if()
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmInscribirAlumno_apoderado formulario = new frmInscribirAlumno_apoderado();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                //DBController.queryStudentByID(_student.getIdStudent)
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
