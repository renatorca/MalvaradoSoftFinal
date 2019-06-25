using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.Configuracion
{
    public partial class frmMenuConfiguracion_todos : Form
    {
        public frmMenuConfiguracion_todos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditarContraseña_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cambiarContraseña = new frmCambiarContraseña();
            cambiarContraseña.Show();
        }
    }
}
