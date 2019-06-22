using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Apoderado
{
    public partial class frmMenuInscribirAlumno_apoderado : Form
    {
        public frmMenuInscribirAlumno_apoderado()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscribirAlumno_apoderado formulario = new frmInscribirAlumno_apoderado();
            if (formulario.ShowDialog() == DialogResult.OK)
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
