using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.InscripcionMatricula_apoderado
{
    public enum estado
    {
        inicial, nuevo, guardar, editar
    }

    public partial class frmInscribirAlumno_apoderado : Form
    {
        private JohanaWS.DBControllerWSClient controller2;
        private JohanaWS.student student2;
        private Boolean state;

        FileStream fs1;
        FileStream fs2;
        String ruta;

        

        public bool State { get => state; set => state = value; }
        public JohanaWS.student Student2 { get => student2; set => student2 = value; }

        public void estadoComponentes(estado est)
        {
            switch (est)
            {
                case estado.nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtDNI.Clear();
                    txtNombre.Clear();
                    txtApPat.Clear();
                    txtApMat.Clear();
                    txtApDir.Clear();
                    txtEmail.Clear();
                    txtTel.Clear();
                    lblx1.Text = "";
                    lblx2.Text = "";
                    break;
                case estado.guardar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    lblx1.Text = "";
                    lblx2.Text = "";
                    break;
                case estado.editar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    lblx1.Text = "";
                    lblx2.Text = "";
                    break;
            }
        }

        public frmInscribirAlumno_apoderado()
        {
            InitializeComponent();
            estadoComponentes(estado.nuevo);
            controller2 = new JohanaWS.DBControllerWSClient();
            fs1 = null;
            fs2 = null;
        }

        public frmInscribirAlumno_apoderado(JohanaWS.student student)
        {
            InitializeComponent();
            estadoComponentes(estado.editar);
            student2 = new JohanaWS.student();
            student2 = student;
            controller2 = new JohanaWS.DBControllerWSClient();
            fs1 = null;
            fs2 = null;
            //se esta editando un alumno existente
            txtDNI.Text = Student2.dni;
            txtNombre.Text = Student2.names;
            txtApPat.Text = Student2.firstLastName;
            txtApMat.Text = Student2.secondLastName;
            txtApDir.Text = Student2.address;
            txtEmail.Text = Student2.email;
            txtTel.Text = Student2.cellPhone.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadStudyCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Files(*.PDF)|*.PDF|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = dialog.FileName;
                }
                fs1 = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs1);
                //falta verificar si ya habia subido antes un archivo
                student2.studyCertificate= br.ReadBytes((int)fs1.Length);
                fs1.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de archivo pdf");
            }

        }

        private void btnBirthCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Files(*.PDF)|*.PDF|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ruta = dialog.FileName;
                }
                fs2 = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs2);
                //falta verificar si ya habia subido antes un archivo
                student2.birthCertificate = br.ReadBytes((int)fs2.Length);
                fs2.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de archivo pdf");
            }

        }

        private void btnHelpCE_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("En esta opción se debe subir el archivo de certificado de estudios, el sistema solo acepta los archivos en formato PDF", "Mensaje de ayuda", MessageBoxButtons.OK);
        }

        private void btnHelpCN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("En esta opción se debe subir el archivo de certificado de nacimiento, el sistema solo acepta los archivos en formato PDF", "Mensaje de ayuda", MessageBoxButtons.OK);
        }

        private int verificarDniYTelefono()
        {
            double DoubleR;
            int result =1;
            int h = txtTel.Text.Length;
            int h2 = txtDNI.Text.Length;
            if ((txtDNI.Text.Length != 8 && Double.TryParse(txtDNI.Text, out DoubleR) )|| (txtTel.Text.Length != 9 && Double.TryParse(txtDNI.Text, out DoubleR)))
            {
                if(txtDNI.Text.Length != 8 && Double.TryParse(txtDNI.Text, out DoubleR))
                {
                    lblx1.Text = "*";//cambiar color
                    result = 0;
                }if(txtTel.Text.Length != 9 && Double.TryParse(txtDNI.Text,out DoubleR))
                {
                    lblx2.Text = "*";//cambiar color
                    result = 0;
                }                  
                MessageBox.Show("(*) Uno de los campos ingresados no son válidos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        private int verificarFiles()
        {
            //int result = 1;
            int result = JohanaWS.verifyStudentFiles(student2.idUser);
            if (result > 0)
            {
                estadoComponentes(estado.editar);
                if (fs1!= null && fs2!= null)
                {
                    result = 1;
                }
            }
            else
            {
                estadoComponentes(estado.nuevo);
                if (fs1 == null && fs2 == null)
                {
                    MessageBox.Show("Faltan añadir los files", "mensaje de advertencia", MessageBoxButtons.OK);
                }
                else
                {
                    result = 1;
                }
            }
            return result;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios efectuados", "Mensaje de Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                int r = 0;
                estadoComponentes(estado.guardar);
                if (verificarFiles() > 0 && verificarDniYTelefono() > 0)
                {
                    guardarDatosAlumno();
                    /r = controller2.insertStudent(student2);
                }
                if (r>0)
                {
                    MessageBox.Show("El estudiante ha sido inscrito correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha habido un error en la inscripción vuelva ha intentarlo nuevamente", "Mensaje de Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (r > 0)
                {
                    this.state = true;
                }
                else
                {
                    this.state = false;
                }
            }
            this.Close();
        }

        private void guardarDatosAlumno()
        {
            student2.dni = txtDNI.Text;
            student2.names = txtNombre.Text;
            student2.firstLastName = txtApPat.Text;
            student2.secondLastName = txtApMat.Text;
            student2.address = txtApDir.Text;
            student2.email = txtEmail.Text;
            student2.cellPhone = Int32.Parse(txtTel.Text);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int r = 0;
            estadoComponentes(estado.guardar);
            if(verificarFiles() == 1 && verificarDniYTelefono() > 0)
            {
                guardarDatosAlumno();
                r = controller2.insertStudent(student2);
            }
            if (r > 0)
            {
                MessageBox.Show("El estudiante ha sido inscrito correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ha habido un error en la inscripción vuelva ha intentarlo nuevamente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (r > 0)
            {
                this.state = true;
            }
            else
            {
                this.state = false;
            }
        }
    }
}
