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
    public partial class frmGestionarCursos_secretario : Form
    {
        public frmGestionarCursos_secretario()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBuscarCurso_secretario frmbuscar = new frmBuscarCurso_secretario();
            if (frmbuscar.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //para invocar a gestionarTipoNota se le pasa un Curso
            MAlvaradoWS.course c = new MAlvaradoWS.course();
            c.name = "Test";
            c.id = 1;
            frmGestionarTipoNota_secretario frmGestionarTipoNota = new frmGestionarTipoNota_secretario(c);
            if (frmGestionarTipoNota.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
