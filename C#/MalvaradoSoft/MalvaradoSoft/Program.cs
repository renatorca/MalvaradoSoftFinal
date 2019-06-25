using MalvaradoSoft.InscripcionMatricula_apoderado;
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
            MAlvaradoWS.course curso = new MAlvaradoWS.course();
            curso.id = 1;
            curso.name = "Test";
            //Application.Run(new frmGestionarTipoNota_secretario(curso));

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
