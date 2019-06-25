//using MalvaradoSoft.InscripcionMatricula_apoderado;
using MalvaradoSoft.GestionSecretario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MalvaradoSoft.RegistrarNotas_profesor;
using MalvaradoSoft.Login;
using MalvaradoSoft.Menu_Principal;
using MalvaradoSoft.Configuracion;


namespace MalvaradoSoft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());


            //Prueba Gestionar Tipo Nota
            RenatoCWS.courseSchedule curso = new RenatoCWS.courseSchedule();
            RenatoCWS.course c = new RenatoCWS.course();
            curso.id = 1;
            c.id = 1;
            c.name = "Test";
            curso.course = c;
            //Application.Run(new frmGestionarTipoNota_secretario(curso));


            //Application.Run(new frmAsignarEventoCursosXSeccion_secretario());




            JohanaWS.user u = new JohanaWS.user();
            u.idUser = 3;
            //Application.Run(new frmMenuInscribirAlumno_apoderado(u));


            //Application.Run(new frmMenuInscribirAlumno_apoderado());

            //Prueba ListarCursos_Profesor
            //Application.Run(new frmListarCursos_profesor(3));

            Application.Run(new frmCambiarContraseña());
        }
    }
}
