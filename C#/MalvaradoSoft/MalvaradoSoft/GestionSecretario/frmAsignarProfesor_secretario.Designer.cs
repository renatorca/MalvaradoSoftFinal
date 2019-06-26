namespace MalvaradoSoft.GestionSecretario
{
    partial class frmAsignarProfesor_secretario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelGrado = new System.Windows.Forms.Label();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignarProfesor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGrado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.labelGrado);
            this.groupBox1.Controls.Add(this.labelSeccion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 123);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Curso";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(80, 86);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(107, 26);
            this.txtSeccion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seccion:";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(80, 54);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(107, 26);
            this.txtGrado.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(107, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGrado.Location = new System.Drawing.Point(12, 27);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(62, 17);
            this.labelGrado.TabIndex = 7;
            this.labelGrado.Text = "Nombre:";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSeccion.Location = new System.Drawing.Point(12, 59);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(52, 17);
            this.labelSeccion.TabIndex = 8;
            this.labelSeccion.Text = "Grado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(194, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 36);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAsignarProfesor
            // 
            this.btnAsignarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAsignarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAsignarProfesor.ForeColor = System.Drawing.Color.White;
            this.btnAsignarProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarProfesor.Location = new System.Drawing.Point(36, 410);
            this.btnAsignarProfesor.Name = "btnAsignarProfesor";
            this.btnAsignarProfesor.Size = new System.Drawing.Size(136, 36);
            this.btnAsignarProfesor.TabIndex = 20;
            this.btnAsignarProfesor.Text = "Asignar Profesor";
            this.btnAsignarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarProfesor.UseVisualStyleBackColor = false;
            this.btnAsignarProfesor.Click += new System.EventHandler(this.btnAsignarProfesor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 64);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.Move += new System.EventHandler(this.Panel1_Move);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(341, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asignar Profesor Al Curso";
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.AllowUserToDeleteRows = false;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvProfesores.Location = new System.Drawing.Point(12, 211);
            this.dgvProfesores.MultiSelect = false;
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesores.Size = new System.Drawing.Size(345, 174);
            this.dgvProfesores.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Profesor";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Asignar";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmAsignarProfesor_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 476);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignarProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignarProfesor_secretario";
            this.Text = "frmAsignarProfesor_secretario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignarProfesor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}