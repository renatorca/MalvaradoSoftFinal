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
    public partial class frmGestionarEvento : Form
    {
        private MAlvaradoWS.courseSchedule curso = new MAlvaradoWS.courseSchedule();
        private MAlvaradoWS.DBControllerWSClient controller;
        public frmGestionarEvento(MAlvaradoWS.courseSchedule c)
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.DataSource = controller.queryAllEventsByCourse(1);
            curso = c;
            txtCurso.Text = c.course.name;
            txtCurso.Enabled = false;
            BindingList<string> dias = new BindingList<string>();
            dias.Add("(Todos)");
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miercoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            cmbDia.DataSource = dias;
        }

        private void CmbDia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            controller = new MAlvaradoWS.DBControllerWSClient();
            int idDay = 0;
            if (cmbDia.Text == "Lunes")
            {
                idDay = 1;
                dgvEventos.DataSource = controller.queryAllEventsByCourseByDay(curso.id, idDay);
            }
            else if (cmbDia.Text == "Martes")
            {
                idDay = 2;
                dgvEventos.DataSource = controller.queryAllEventsByCourseByDay(curso.id, idDay);
            }
            else if (cmbDia.Text == "Miercoles")
            {
                idDay = 3;
                dgvEventos.DataSource = controller.queryAllEventsByCourseByDay(curso.id, idDay);
            }
            else if (cmbDia.Text == "Jueves")
            {
                idDay = 4;
                dgvEventos.DataSource = controller.queryAllEventsByCourseByDay(curso.id, idDay);
            }
            else if (cmbDia.Text == "Viernes")
            {
                idDay = 5;
                dgvEventos.DataSource = controller.queryAllEventsByCourseByDay(curso.id, idDay);
            }
            else if (cmbDia.Text == "(Todos)")
            {
                idDay = 5;
                dgvEventos.DataSource = controller.queryAllEventsByCourse(curso.id);
            }

            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            frmCrearEvento frmcrearEvento = new frmCrearEvento(curso);
            if(frmcrearEvento.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de eliminar el evento del curso?", "Mensaje de validación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                MAlvaradoWS.@event eve;
                eve = (MAlvaradoWS.@event)dgvEventos.CurrentRow.DataBoundItem;
                controller.deleteEvent(eve);
            }
        }

        private void FrmGestionarEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Desea guardar los cambios antes de cerrar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                for (int fila = 0; fila < dgvEventos.Rows.Count - 1; fila++)
                {
                    MAlvaradoWS.@event evento = new MAlvaradoWS.@event();
                    evento = (MAlvaradoWS.@event)dgvEventos.Rows[fila].DataBoundItem;
                    controller.updateEvent(evento);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void FrmGestionarEvento_Load(object sender, EventArgs e)
        {

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
    }
}
