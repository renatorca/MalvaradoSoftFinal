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
        private MAlvaradoWS.DBControllerWSClient controller;
       // private MAlvaradoWS.student student;
        public frmMenuInscribirAlumno_apoderado()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            //BindingList<Student> studentList = controller.queryAllStudentsByIDGuardian(user.getIdUser);
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
            //student.DNI= dgvAlumnosInscritos.Rows[posActual].Cells[0].Value;

            //if(posActual)

            if(e.ColumnIndex == 4 )//&& e.RowIndex < studentList.Lenght)
            {
                frmGestionarIntencionMatricula_apoderado frmInt = new frmGestionarIntencionMatricula_apoderado();
                if (frmInt.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                /*if (dgvAlumnosInscritos.CurrentCell.ColumnIndex)//student != null)
                {
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                }*/
            }

            
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
