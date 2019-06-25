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
    public partial class frmAsignarEventoCursosXSeccion_secretario : Form
    {
        MAlvaradoWS.DBControllerWSClient controller;
        public frmAsignarEventoCursosXSeccion_secretario()
        {
            InitializeComponent();
            controller = new MAlvaradoWS.DBControllerWSClient();
            BindingList<int> grados = new BindingList<int>();
            grados.Add(1);
            grados.Add(2);
            grados.Add(3);
            grados.Add(4);
            grados.Add(5);
            grados.Add(6);
            cmbGrado.DataSource = grados;
        }

        private void BtnEditarHorario_Click(object sender, EventArgs e)
        {
            MAlvaradoWS.classSection cs;
            cs = (MAlvaradoWS.classSection)cmbSeccion.SelectedItem;
            frmAsignarEventos_secretario frmCursoporSeccion = new frmAsignarEventos_secretario(cs);
            if (frmCursoporSeccion.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void CmbGrado_SelectedValueChanged(object sender, EventArgs e)
        {
            int grado = Int32.Parse(cmbGrado.Text);
            cmbSeccion.DataSource = controller.queryAllClassSectionByLevel(grado);
            cmbSeccion.DisplayMember = "name";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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
