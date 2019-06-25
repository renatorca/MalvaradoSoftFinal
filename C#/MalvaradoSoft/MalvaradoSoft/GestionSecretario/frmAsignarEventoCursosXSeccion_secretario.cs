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
    }
}
