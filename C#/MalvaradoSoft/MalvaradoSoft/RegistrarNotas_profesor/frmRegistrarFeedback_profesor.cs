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
    public partial class frmRegistrarFeedback_profesor : Form
    {
        private bool editado;
        private MAlvaradoWS.gradeXStudent gradeXStudent;
        public frmRegistrarFeedback_profesor(MAlvaradoWS.gradeXStudent gxs)
        {
            InitializeComponent();
            gradeXStudent = gxs;
            this.txtFeed.Text = gradeXStudent.feedback;
            editado = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar los cambios
            editado = false;
            int r = this.guardarFeedback();

            
            //Cerrar
            if(r == 1)
            {
                MessageBox.Show("Se agregó el feedback exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
                
        }

        public int guardarFeedback()
        {
            if (this.txtFeed.Text.Count<char>() <= 200)
            {
                gradeXStudent.feedback = this.txtFeed.Text;
                return 1;
                
            }
            else
            {
                MessageBox.Show("Por favor ingrese un feedback de como máximo 200 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            
        }

        private void editarFeedback(object sender, EventArgs e)
        {
            editado = true;

        }

        private void confirmacionCierre(object sender, FormClosingEventArgs e)
        {
            if (editado)
            {
                DialogResult r = MessageBox.Show("¿Desea guardar lo cambios del feedback antes de salir?", "¿Guardar cambios?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(r == DialogResult.Yes)
                {
                    this.guardarFeedback();
                }
            }
           
        }
    }
}
