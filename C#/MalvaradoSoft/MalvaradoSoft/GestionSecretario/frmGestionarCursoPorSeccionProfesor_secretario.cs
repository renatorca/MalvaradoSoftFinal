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

namespace MalvaradoSoft.GestionSecretario
{
    public partial class frmGestionarCursoPorSeccionProfesor_secretario : Form
    {
        MAlvaradoWS.courseSchedule curso = new MAlvaradoWS.courseSchedule();
        MAlvaradoWS.DBControllerWSClient controller;
        public frmGestionarCursoPorSeccionProfesor_secretario(MAlvaradoWS.classSection cs)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            txtGrado.Text = cs.level.ToString();
            txtSeccion.Text = cs.name;
            txtSeccion.Enabled = false;
            txtGrado.Enabled = false;
            dgvCursosPorGrado.AutoGenerateColumns = false;
            dgvCursosPorGrado.DataSource = controller.queryAllCourseByLevel(cs.level);
            
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
