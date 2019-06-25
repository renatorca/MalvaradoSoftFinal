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
    public partial class frmGestionarCursoPorSeccionProfesor_secretario : Form
    {
        RenatoCWS.courseSchedule curso = new RenatoCWS.courseSchedule();
        RenatoCWS.DBControllerWSClient controller;
        public frmGestionarCursoPorSeccionProfesor_secretario(RenatoCWS.classSection cs)
        {
            InitializeComponent();
            controller = new RenatoCWS.DBControllerWSClient();
            txtGrado.Text = cs.level.ToString();
            txtSeccion.Text = cs.name;
            txtSeccion.Enabled = false;
            txtGrado.Enabled = false;
            dgvCursosPorGrado.AutoGenerateColumns = false;
            dgvCursosPorGrado.DataSource = controller.queryAllCourseByLevel(cs.level);
            
        }


    }
}
