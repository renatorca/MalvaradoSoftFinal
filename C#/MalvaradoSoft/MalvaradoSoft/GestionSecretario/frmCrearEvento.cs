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
    public partial class frmCrearEvento : Form
    {
        RenatoCWS.courseSchedule courseSchedule = new RenatoCWS.courseSchedule();
        RenatoCWS.DBControllerWSClient controller;
        public frmCrearEvento(RenatoCWS.courseSchedule cs)
        {
            InitializeComponent();
            courseSchedule = cs;
            controller = new RenatoCWS.DBControllerWSClient();
            BindingList<string> dias = new BindingList<string>();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miercoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            cmbDia.DataSource = dias;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RenatoCWS.@event evento = new RenatoCWS.@event();
            string startTime = txtHoraInicio.Text;
            string endTime = txtHoraFin.Text;
            if (!(Validacion(startTime) && Validacion(endTime)))
            {
                MessageBox.Show("Las fechas ingresadas no son correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int idDia = 0;
                string dia = cmbDia.Text;
                if (dia.Contains("Lunes")) idDia = 1;
                else if (dia.Contains("Martes")) idDia = 2;
                else if (dia.Contains("Miercoles")) idDia = 3;
                else if (dia.Contains("Jueves")) idDia = 4;
                else if (dia.Contains("Viernes")) idDia = 5;
                evento.day = idDia;
                evento.courseSchedule = courseSchedule;
                evento.endTime = endTime;
                evento.startTime = startTime;
                controller.insertEvent(evento);
                MessageBox.Show("El evento se registró correctamente", "Aviso", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            

        }
        private bool Validacion(string fecha)
        {
            if (fecha.Length != 8) return false;
            string h = fecha.Substring(0, 2);
            string m = fecha.Substring(3, 2);
            string s = fecha.Substring(6, 2);
            int hh, mm, ss;
            hh = Int32.Parse(h);
            mm = Int32.Parse(m);
            ss = Int32.Parse(s);
            return (hh >= 0 && hh <= 24) && (mm >= 0 && mm <= 60) && (ss >= 0 && ss <= 60);
        }
    }
}
