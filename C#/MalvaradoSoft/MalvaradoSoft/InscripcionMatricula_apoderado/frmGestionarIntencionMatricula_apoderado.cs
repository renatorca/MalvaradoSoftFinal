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
    
    public partial class frmGestionarIntencionMatricula_apoderado : Form
    {
        private JohanaWS.studentXYear studentxy;
        private JohanaWS.DBControllerWSClient controller;
        public frmGestionarIntencionMatricula_apoderado()
        {
            InitializeComponent();
        }

        public frmGestionarIntencionMatricula_apoderado(JohanaWS.student student)
        {
            InitializeComponent();
            controller = new JohanaWS.DBControllerWSClient();
            studentxy.student = student;
            //comboBox1.DataSource = controller.queryAllClassSections();
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            studentxy.classSection.level = ((JohanaWS.classSection)comboBox1.SelectedValue).level ;
            studentxy.ticketEnrollment = textBox1.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Desea guardar los cambios","Mensaje de advertencia",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                studentxy.classSection.level = ((JohanaWS.classSection)comboBox1.SelectedValue).level;
                studentxy.ticketEnrollment = textBox1.Text;
                MessageBox.Show("La matricula será procesada dentro de los siguientes días", "Mensaje informativo", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
