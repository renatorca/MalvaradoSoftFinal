using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.RegistrarNotas_profesor
{
    public partial class frmRegistrarNotas_profesor : Form
    {
        private MAlvaradoWS.user professor;
        private MAlvaradoWS.courseSchedule courseScheduleSelected;
        private BindingList<MAlvaradoWS.courseSchedule> courseSchedules;
        private MAlvaradoWS.DBControllerWSClient controller = new MAlvaradoWS.DBControllerWSClient();
        

        private frmRegistrarFeedback_profesor feed;

        public frmRegistrarNotas_profesor(MAlvaradoWS.user p)
        {
            InitializeComponent();
            courseSchedules = new BindingList<MAlvaradoWS.courseSchedule>();
            professor = p;

            

            
            

        }

        private void ingresarFeedback(object sender, DataGridViewCellEventArgs e)
        {
            feed = new frmRegistrarFeedback_profesor();
            feed.ShowDialog();
        }
    }
}
