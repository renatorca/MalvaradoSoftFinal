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
    public enum Estado
    {
        inicial,nuevo,guardar,editar,vacio
    }

    public partial class frmMenuInscribirAlumno_apoderado : Form
    {
        private JohanaWS.DBControllerWSClient controller2;
        private JohanaWS.user guardian;
        private JohanaWS.student student;

        public void estadoComponentes(Estado est)
        {
            switch (est)
            {
                case Estado.inicial:
                    btnInscribir.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnCancelar.Enabled = false;
                    break;
                case Estado.nuevo:
                    btnInscribir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;
                case Estado.guardar:
                    btnInscribir.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    break;
                case Estado.editar:
                    btnInscribir.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.vacio:
                    btnInscribir.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
            }
        }

        public frmMenuInscribirAlumno_apoderado()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public frmMenuInscribirAlumno_apoderado(JohanaWS.user user)
        {
            InitializeComponent();
            estadoComponentes(Estado.inicial);
            controller2 = new JohanaWS.DBControllerWSClient();
            guardian = user;
            dgvAlumnosInscritos.AutoGenerateColumns = false;
            dgvAlumnosInscritos.DataSource = controller2.queryAllStudentsByGuardianID(user.idUser);
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirAlumno_apoderado frmIns = new frmInscribirAlumno_apoderado();
            if (frmIns.ShowDialog() == DialogResult.OK)
            {
                estadoComponentes(Estado.nuevo);
                if(frmIns.State)
                {
                    MessageBox.Show("Su solicitud de inscripción al alumno ha sido procesada", "Mensaje de validación", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("La solicitud de inscripción del alumno no fue procesada", "Mensaje de error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            dgvAlumnosInscritos.DataSource = controller2.queryAllStudentsByGuardianID(guardian.idUser);
        }

        private void dgvAlumnosInscritos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int posActual = dgvAlumnosInscritos.CurrentCell.ColumnIndex;
            //student= dgvAlumnosInscritos.Rows[posActual].Cells[0].Value;
            estadoComponentes(Estado.editar);
            this.student = (JohanaWS.student)dgvAlumnosInscritos.CurrentRow.DataBoundItem;

            if (e.ColumnIndex == 4 )//&& e.RowIndex < studentList.Lenght)
            {
                frmGestionarIntencionMatricula_apoderado frmInt = new frmGestionarIntencionMatricula_apoderado(student);
                if (frmInt.ShowDialog() == DialogResult.OK)
                {

                }
            }
            /*else
            {
                if (dgvAlumnosInscritos.Rows.Count > 0)
                {

                    estadoComponentes(Estado.nuevo);
                }
                else
                {
                    estadoComponentes(Estado.vacio);
                }
            }
            */
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.editar);
            frmInscribirAlumno_apoderado formulario = new frmInscribirAlumno_apoderado(this.student);
            if (formulario.ShowDialog() == DialogResult.OK)
            {

            }
            dgvAlumnosInscritos.DataSource = controller2.queryAllStudentsByGuardianID(guardian.idUser);

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnosInscritos.Rows.Count > 0)
            {
                //-if(controller2.deleteStudent(student))
                {
                    MessageBox.Show("Se ha eliminado al estudiante correctamente", "Mensaje de validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No se ha elegido ningún estudiante para la eliminacion", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvAlumnosInscritos.DataSource = controller2.queryAllStudentsByGuardianID(guardian.idUser);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(Estado.inicial);
        }
    }
}