using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Inscripcion_matricula_apoderado
{
    public partial class frmGestionarIntencionMatricula_apoderado : Form
    {
        public frmGestionarIntencionMatricula_apoderado()
        {
            InitializeComponent();
        }

        private void btnHelpBoleta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta opción se debe colocar el número del recibo de la boleta de pago para la próxima Matrícula del alumno", "Mensaje de ayuda", MessageBoxButtons.OK);
        }
    }
}
