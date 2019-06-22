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
    public partial class frmGestionarSeccion_secretario : Form
    {
        public frmGestionarSeccion_secretario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAsignarAlumnos_secretario frmAsignarAlumnos = new frmAsignarAlumnos_secretario();
            if (frmAsignarAlumnos.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
