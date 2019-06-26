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
    public partial class frmGestionarTipoNota_secretario : Form
    {
        EstadosFrmGestionarTipoNota estado = EstadosFrmGestionarTipoNota.Buscar;
        MAlvaradoWS.course curso = new MAlvaradoWS.course();
        MAlvaradoWS.grade grade = new MAlvaradoWS.grade();
        private MAlvaradoWS.DBControllerWSClient controller;

        public frmGestionarTipoNota_secretario(MAlvaradoWS.course c)
        {
            InitializeComponent();
            this.curso = c;
            this.grade.course = new MAlvaradoWS.course();
            this.grade.course = this.curso;
            cambiarEstado(EstadosFrmGestionarTipoNota.Buscar);
            txtNombreCurso.Text = curso.name;

            controller = new MAlvaradoWS.DBControllerWSClient();

            dgvCursos.AutoGenerateColumns = false;
            //dgvCursos.DataSource = controller.queryAllGrades();
            dgvCursos.DataSource = controller.queryGradesByCourseId(this.curso.id);
        }

        private void cambiarEstado(EstadosFrmGestionarTipoNota e)
        {
            if (e == EstadosFrmGestionarTipoNota.Buscar)
            {
                this.estado = EstadosFrmGestionarTipoNota.Buscar;
                txtPeso.Enabled = false;
                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregar.Text = "&Agregar";
                btnEliminar.Enabled = false;

            }
            else if (e == EstadosFrmGestionarTipoNota.Nuevo)
            {
                this.estado = EstadosFrmGestionarTipoNota.Nuevo;
                txtDescripcion.Text = "";
                txtPeso.Enabled = true;
                txtPeso.Text = "";
                btnNuevo.Enabled = false;
                btnAgregar.Enabled = true;
                btnAgregar.Text = "&Agregar";
                btnEliminar.Enabled = false;

            }
            else if (e == EstadosFrmGestionarTipoNota.Editar)
            {
                this.estado = EstadosFrmGestionarTipoNota.Editar;
                txtPeso.Enabled = true;
                btnNuevo.Enabled = false;
                btnAgregar.Enabled = true;
                btnAgregar.Text = "&Actualizar";
                btnEliminar.Enabled = true;

            }
        }

        private void editarGrade(object sender, DataGridViewCellEventArgs e)
        {
            cambiarEstado(EstadosFrmGestionarTipoNota.Editar);
            this.grade = (MAlvaradoWS.grade)dgvCursos.CurrentRow.DataBoundItem;
            txtDescripcion.Text = grade.description;
            txtPeso.Text = grade.weight.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cambiarEstado(EstadosFrmGestionarTipoNota.Nuevo);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.estado == EstadosFrmGestionarTipoNota.Nuevo)
            {
                this.grade.description = txtDescripcion.Text;
                this.grade.weight = Double.Parse(txtPeso.Text);
                var result = MessageBox.Show("¿Está seguro que desea agregar el nuevo tipo de nota?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    controller.insertGRade(this.grade);

            }
            else if (this.estado == EstadosFrmGestionarTipoNota.Editar)
            {
                this.grade.description = txtDescripcion.Text;
                this.grade.weight = Double.Parse(txtPeso.Text);
                var result = MessageBox.Show("¿Está seguro que desea actualizar el tipo de nota?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    controller.updateGRade(this.grade);
            }
            //dgvCursos.DataSource = controller.queryAllGrades();
            dgvCursos.DataSource = controller.queryGradesByCourseId(this.curso.id);
            cambiarEstado(EstadosFrmGestionarTipoNota.Buscar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.grade = (MAlvaradoWS.grade)dgvCursos.CurrentRow.DataBoundItem;
            var result = MessageBox.Show("¿Está seguro que desea eliminar el tipo de nota?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                controller.deleteGRade(grade);
            //dgvCursos.DataSource = controller.queryAllGrades();
            dgvCursos.DataSource = controller.queryGradesByCourseId(this.curso.id);
            cambiarEstado(EstadosFrmGestionarTipoNota.Buscar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = controller.queryGradesSearchByName(txtDescripcion.Text, this.curso.id);
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
