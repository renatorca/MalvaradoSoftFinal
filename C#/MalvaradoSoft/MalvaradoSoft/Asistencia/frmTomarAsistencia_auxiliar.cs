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

namespace MalvaradoSoft.Asistencia
{
    public partial class frmTomarAsistencia_auxiliar : Form
    {
        private MAlvaradoWS.DBControllerWSClient controller;
        private frmGestionarAsistencia_auxiliar frmGestionarAsistencia;
        public frmTomarAsistencia_auxiliar(MAlvaradoWS.classSection classSection, DateTime date)
        {
            InitializeComponent();
            txtGrado.Text = classSection.level.ToString();
            txtSeccion.Text = classSection.name;
            dtpFecha.Value = date;
            txtGrado.Enabled = false;
            txtSeccion.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            DialogResult msg = MessageBox.Show("¿Está seguro de registrar la asistencia?", "Mensaje de validación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
