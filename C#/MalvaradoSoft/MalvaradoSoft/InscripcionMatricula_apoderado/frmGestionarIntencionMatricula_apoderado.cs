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

namespace MalvaradoSoft.InscripcionMatricula_apoderado
{
<<<<<<< HEAD
    
    public partial class frmGestionarIntencionMatricula_apoderado : Form
    {
        private MAlvaradoWS.studentXYear student2;
=======
    public partial class frmGestionarIntencionMatricula_apoderado : Form
    {
        private JohanaWS.studentXYear studentxy;
        private JohanaWS.DBControllerWSClient controller;
>>>>>>> cbdef1954b37e372080f58b5d178366059b483d3

        public frmGestionarIntencionMatricula_apoderado()
        {
            InitializeComponent();
        }

        public frmGestionarIntencionMatricula_apoderado(MAlvaradoWS.student student)
        {
            InitializeComponent();
<<<<<<< HEAD
            //student2 = student;
=======
            controller = new JohanaWS.DBControllerWSClient();
            studentxy.student = student;
            //comboBox1.DataSource = controller.queryAllClassSections();
>>>>>>> cbdef1954b37e372080f58b5d178366059b483d3
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //student2.classSection.level = comboBox1.SelectedItem;
=======
            studentxy.classSection.level = ((JohanaWS.classSection)comboBox1.SelectedValue).level ;
            studentxy.ticketEnrollment = textBox1.Text;
        }
>>>>>>> cbdef1954b37e372080f58b5d178366059b483d3

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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
