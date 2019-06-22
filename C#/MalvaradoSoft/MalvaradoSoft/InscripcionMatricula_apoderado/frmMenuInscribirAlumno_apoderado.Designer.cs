namespace MalvaradoSoft.Apoderado
{
    partial class frmMenuInscribirAlumno_apoderado
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
            this.dgvAlumnosInscritos = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apel_Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ap_Materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscritos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnosInscritos
            // 
            this.dgvAlumnosInscritos.AllowUserToDeleteRows = false;
            this.dgvAlumnosInscritos.AllowUserToResizeColumns = false;
            this.dgvAlumnosInscritos.AllowUserToResizeRows = false;
            this.dgvAlumnosInscritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnosInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.nombre,
            this.Apel_Paterno,
            this.Ap_Materno,
            this.matricular,
            this.Column1});
            this.dgvAlumnosInscritos.Location = new System.Drawing.Point(29, 174);
            this.dgvAlumnosInscritos.Name = "dgvAlumnosInscritos";
            this.dgvAlumnosInscritos.ReadOnly = true;
            this.dgvAlumnosInscritos.RowHeadersVisible = false;
            this.dgvAlumnosInscritos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAlumnosInscritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosInscritos.Size = new System.Drawing.Size(575, 194);
            this.dgvAlumnosInscritos.TabIndex = 1;
            this.dgvAlumnosInscritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnosInscritos_CellContentClick);
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DNI.Frozen = true;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 113;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 115;
            // 
            // Apel_Paterno
            // 
            this.Apel_Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apel_Paterno.Frozen = true;
            this.Apel_Paterno.HeaderText = "Apel. Paterno";
            this.Apel_Paterno.Name = "Apel_Paterno";
            this.Apel_Paterno.ReadOnly = true;
            this.Apel_Paterno.Width = 114;
            // 
            // Ap_Materno
            // 
            this.Ap_Materno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ap_Materno.Frozen = true;
            this.Ap_Materno.HeaderText = "Ap. Materno";
            this.Ap_Materno.Name = "Ap_Materno";
            this.Ap_Materno.ReadOnly = true;
            this.Ap_Materno.Width = 116;
            // 
            // matricular
            // 
            this.matricular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.matricular.HeaderText = "Matricular";
            this.matricular.Name = "matricular";
            this.matricular.ReadOnly = true;
            this.matricular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matricular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.matricular.Width = 114;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Condición";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(633, 174);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(139, 23);
            this.btnInscribir.TabIndex = 2;
            this.btnInscribir.Text = "Inscribir Alumno";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(633, 242);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(139, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar Inscripción";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(633, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar Inscripción";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inscripcion de Alumnos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(29, 553);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 23);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // frmMenuInscribirAlumno_apoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.dgvAlumnosInscritos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuInscribirAlumno_apoderado";
            this.Text = "frmMenuInscribirAlumno_apoderado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosInscritos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvAlumnosInscritos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apel_Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ap_Materno;
        private System.Windows.Forms.DataGridViewButtonColumn matricular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}