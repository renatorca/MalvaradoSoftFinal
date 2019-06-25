using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Asistencia
{
    public partial class frmTomarAsistencia_auxiliar : Form
    {
        private RenatoCWS.DBControllerWSClient controller;
        private frmGestionarAsistencia_auxiliar frmGestionarAsistencia;
        public frmTomarAsistencia_auxiliar(RenatoCWS.classSection classSection, DateTime date)
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
    }
}
