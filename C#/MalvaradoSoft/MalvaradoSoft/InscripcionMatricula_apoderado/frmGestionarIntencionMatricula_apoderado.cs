using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.InscripcionMatricula_apoderado
{
    private JohanaWS.student student2;
    public partial class frmGestionarIntencionMatricula_apoderado : Form
    {
        
        public frmGestionarIntencionMatricula_apoderado()
        {
            InitializeComponent();
        }

        public frmGestionarIntencionMatricula_apoderado(JohanaWS.student student)
        {
            InitializeComponent();
            student2 = student;
        }

        private void btnGuardarM_Click(object sender, EventArgs e)
        {
            student2.classSection.level = comboBox1.SelectedItem;

        }
    }
}
