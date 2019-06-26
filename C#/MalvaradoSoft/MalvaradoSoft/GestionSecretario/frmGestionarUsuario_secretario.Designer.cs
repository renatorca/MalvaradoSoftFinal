namespace MalvaradoSoft.GestionSecretario
{
    partial class frmGestionarUsuario_secretario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.ckProfesor = new System.Windows.Forms.CheckBox();
            this.ckSecretaria = new System.Windows.Forms.CheckBox();
            this.ckAuxiliar = new System.Windows.Forms.CheckBox();
            this.ckAlumno = new System.Windows.Forms.CheckBox();
            this.ckApoderado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.lbly6 = new System.Windows.Forms.Label();
            this.lbly5 = new System.Windows.Forms.Label();
            this.lbly4 = new System.Windows.Forms.Label();
            this.lbly3 = new System.Windows.Forms.Label();
            this.lbly2 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbTipoUsuario.SuspendLayout();
            this.gbDatosGenerales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(394, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 34);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbTipoUsuario
            // 
            this.gbTipoUsuario.Controls.Add(this.ckProfesor);
            this.gbTipoUsuario.Controls.Add(this.ckSecretaria);
            this.gbTipoUsuario.Controls.Add(this.ckAuxiliar);
            this.gbTipoUsuario.Controls.Add(this.ckAlumno);
            this.gbTipoUsuario.Controls.Add(this.ckApoderado);
            this.gbTipoUsuario.Location = new System.Drawing.Point(12, 74);
            this.gbTipoUsuario.Name = "gbTipoUsuario";
            this.gbTipoUsuario.Size = new System.Drawing.Size(604, 51);
            this.gbTipoUsuario.TabIndex = 34;
            this.gbTipoUsuario.TabStop = false;
            this.gbTipoUsuario.Text = "Tipo Usuario";
            // 
            // ckProfesor
            // 
            this.ckProfesor.AutoSize = true;
            this.ckProfesor.Location = new System.Drawing.Point(150, 19);
            this.ckProfesor.Name = "ckProfesor";
            this.ckProfesor.Size = new System.Drawing.Size(65, 17);
            this.ckProfesor.TabIndex = 13;
            this.ckProfesor.Text = "Profesor";
            this.ckProfesor.UseVisualStyleBackColor = true;
            this.ckProfesor.CheckedChanged += new System.EventHandler(this.ckProfesor_CheckedChanged);
            // 
            // ckSecretaria
            // 
            this.ckSecretaria.AutoSize = true;
            this.ckSecretaria.Location = new System.Drawing.Point(269, 19);
            this.ckSecretaria.Name = "ckSecretaria";
            this.ckSecretaria.Size = new System.Drawing.Size(74, 17);
            this.ckSecretaria.TabIndex = 12;
            this.ckSecretaria.Text = "Secretaria";
            this.ckSecretaria.UseVisualStyleBackColor = true;
            this.ckSecretaria.CheckedChanged += new System.EventHandler(this.ckSecretaria_CheckedChanged);
            // 
            // ckAuxiliar
            // 
            this.ckAuxiliar.AutoSize = true;
            this.ckAuxiliar.Location = new System.Drawing.Point(397, 19);
            this.ckAuxiliar.Name = "ckAuxiliar";
            this.ckAuxiliar.Size = new System.Drawing.Size(59, 17);
            this.ckAuxiliar.TabIndex = 11;
            this.ckAuxiliar.Text = "Auxiliar";
            this.ckAuxiliar.UseVisualStyleBackColor = true;
            this.ckAuxiliar.CheckedChanged += new System.EventHandler(this.ckAuxiliar_CheckedChanged);
            // 
            // ckAlumno
            // 
            this.ckAlumno.AutoSize = true;
            this.ckAlumno.Location = new System.Drawing.Point(510, 19);
            this.ckAlumno.Name = "ckAlumno";
            this.ckAlumno.Size = new System.Drawing.Size(61, 17);
            this.ckAlumno.TabIndex = 9;
            this.ckAlumno.Text = "Alumno";
            this.ckAlumno.UseVisualStyleBackColor = true;
            this.ckAlumno.CheckedChanged += new System.EventHandler(this.ckAlumno_CheckedChanged);
            // 
            // ckApoderado
            // 
            this.ckApoderado.AutoSize = true;
            this.ckApoderado.Location = new System.Drawing.Point(18, 19);
            this.ckApoderado.Name = "ckApoderado";
            this.ckApoderado.Size = new System.Drawing.Size(78, 17);
            this.ckApoderado.TabIndex = 8;
            this.ckApoderado.Text = "Apoderado";
            this.ckApoderado.UseVisualStyleBackColor = true;
            this.ckApoderado.CheckedChanged += new System.EventHandler(this.ckApoderado_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(269, 453);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 34);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(519, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 34);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.lbly6);
            this.gbDatosGenerales.Controls.Add(this.lbly5);
            this.gbDatosGenerales.Controls.Add(this.lbly4);
            this.gbDatosGenerales.Controls.Add(this.lbly3);
            this.gbDatosGenerales.Controls.Add(this.lbly2);
            this.gbDatosGenerales.Controls.Add(this.lblx2);
            this.gbDatosGenerales.Controls.Add(this.lblx1);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarUsuario);
            this.gbDatosGenerales.Controls.Add(this.txtEmail);
            this.gbDatosGenerales.Controls.Add(this.txtTel);
            this.gbDatosGenerales.Controls.Add(this.txtApMat);
            this.gbDatosGenerales.Controls.Add(this.label8);
            this.gbDatosGenerales.Controls.Add(this.label7);
            this.gbDatosGenerales.Controls.Add(this.txtApDir);
            this.gbDatosGenerales.Controls.Add(this.label6);
            this.gbDatosGenerales.Controls.Add(this.txtApPat);
            this.gbDatosGenerales.Controls.Add(this.txtNombre);
            this.gbDatosGenerales.Controls.Add(this.txtDNI);
            this.gbDatosGenerales.Controls.Add(this.label5);
            this.gbDatosGenerales.Controls.Add(this.label4);
            this.gbDatosGenerales.Controls.Add(this.label3);
            this.gbDatosGenerales.Controls.Add(this.label2);
            this.gbDatosGenerales.Location = new System.Drawing.Point(19, 147);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(595, 300);
            this.gbDatosGenerales.TabIndex = 30;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // lbly6
            // 
            this.lbly6.AutoSize = true;
            this.lbly6.Location = new System.Drawing.Point(110, 225);
            this.lbly6.Name = "lbly6";
            this.lbly6.Size = new System.Drawing.Size(10, 13);
            this.lbly6.TabIndex = 32;
            this.lbly6.Text = " ";
            // 
            // lbly5
            // 
            this.lbly5.AutoSize = true;
            this.lbly5.Location = new System.Drawing.Point(110, 161);
            this.lbly5.Name = "lbly5";
            this.lbly5.Size = new System.Drawing.Size(10, 13);
            this.lbly5.TabIndex = 31;
            this.lbly5.Text = " ";
            // 
            // lbly4
            // 
            this.lbly4.AutoSize = true;
            this.lbly4.Location = new System.Drawing.Point(110, 129);
            this.lbly4.Name = "lbly4";
            this.lbly4.Size = new System.Drawing.Size(10, 13);
            this.lbly4.TabIndex = 30;
            this.lbly4.Text = " ";
            // 
            // lbly3
            // 
            this.lbly3.AutoSize = true;
            this.lbly3.Location = new System.Drawing.Point(110, 97);
            this.lbly3.Name = "lbly3";
            this.lbly3.Size = new System.Drawing.Size(10, 13);
            this.lbly3.TabIndex = 29;
            this.lbly3.Text = " ";
            // 
            // lbly2
            // 
            this.lbly2.AutoSize = true;
            this.lbly2.Location = new System.Drawing.Point(110, 65);
            this.lbly2.Name = "lbly2";
            this.lbly2.Size = new System.Drawing.Size(10, 13);
            this.lbly2.TabIndex = 28;
            this.lbly2.Text = " ";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(110, 193);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(10, 13);
            this.lblx2.TabIndex = 27;
            this.lblx2.Text = " ";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(110, 33);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(10, 13);
            this.lblx1.TabIndex = 26;
            this.lblx1.Text = " ";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(500, 260);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(83, 34);
            this.btnBuscarUsuario.TabIndex = 25;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 222);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(438, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(126, 190);
            this.txtTel.MaxLength = 9;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(438, 20);
            this.txtTel.TabIndex = 9;
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(126, 126);
            this.txtApMat.MaxLength = 45;
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(438, 20);
            this.txtApMat.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Celular";
            // 
            // txtApDir
            // 
            this.txtApDir.Location = new System.Drawing.Point(126, 158);
            this.txtApDir.MaxLength = 45;
            this.txtApDir.Name = "txtApDir";
            this.txtApDir.Size = new System.Drawing.Size(438, 20);
            this.txtApDir.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(126, 94);
            this.txtApPat.MaxLength = 45;
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(438, 20);
            this.txtApPat.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 62);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(438, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(126, 30);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(438, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(144, 453);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 34);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 51);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestionar Usuario";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(19, 453);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 34);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmGestionarUsuario_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 505);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbTipoUsuario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbDatosGenerales);
            this.Name = "frmGestionarUsuario_secretario";
            this.Text = "frmGestionarUsuario_secretario";
            this.gbTipoUsuario.ResumeLayout(false);
            this.gbTipoUsuario.PerformLayout();
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbTipoUsuario;
        private System.Windows.Forms.CheckBox ckProfesor;
        private System.Windows.Forms.CheckBox ckSecretaria;
        private System.Windows.Forms.CheckBox ckAuxiliar;
        private System.Windows.Forms.CheckBox ckAlumno;
        private System.Windows.Forms.CheckBox ckApoderado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lbly6;
        private System.Windows.Forms.Label lbly5;
        private System.Windows.Forms.Label lbly4;
        private System.Windows.Forms.Label lbly3;
        private System.Windows.Forms.Label lbly2;
    }
}