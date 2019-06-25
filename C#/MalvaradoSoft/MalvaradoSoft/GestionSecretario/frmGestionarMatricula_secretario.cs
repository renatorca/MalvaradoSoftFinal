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
    public partial class frmGestionarMatricula_secretario : Form
    {
        private JohanaWS.studentXYear studentxy;
        private JohanaWS.DBControllerWSClient controller;
        public frmGestionarMatricula_secretario()
        {
            InitializeComponent();
            controller = new JohanaWS.DBControllerWSClient();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            
            for (int i=0; i<dataGridView1.Rows.Count; i++)
            {
                bool isChecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                if (isChecked)
                {
                    studentxy = new JohanaWS.studentXYear();
                    studentxy.condition.idCondition = 1;//matricular alumno
                    //int result = controller.updateStudentXYear();
                }
            }
            MessageBox.Show("Los alumnos han sido matriculados satisfactoriamente","Mensaje informativo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
