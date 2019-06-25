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

        private void BtnEditNombre_Click(object sender, EventArgs e)
        {
            //Muevo todo los demas labels
            linea1.Location = new Point(263, 75);
            linea2.Location = new Point(263, 126);
            linea3.Location = new Point(263, 167);
            linea4.Location = new Point(263, 209);
            linea5.Location = new Point(263, 238);
            linea6.Location = new Point(263, 311);

            btnEditNombre.Location = new Point(695,20);

        }
    }
}
