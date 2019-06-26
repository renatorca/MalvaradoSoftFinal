namespace MalvaradoSoft.RegistrarNotas_profesor
{
    partial class frmListarCursos_profesor
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
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.colNombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreCurso,
            this.colNivel,
            this.colSeccion});
            this.dgvCursos.Location = new System.Drawing.Point(16, 156);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(546, 252);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registrarNotas);
            // 
            // colNombreCurso
            // 
            this.colNombreCurso.DataPropertyName = "cursoJoel";
            this.colNombreCurso.HeaderText = "Curso";
            this.colNombreCurso.Name = "colNombreCurso";
            this.colNombreCurso.ReadOnly = true;
            this.colNombreCurso.Width = 300;
            // 
            // colNivel
            // 
            this.colNivel.DataPropertyName = "gradoJoel";
            this.colNivel.HeaderText = "Grado";
            this.colNivel.Name = "colNivel";
            this.colNivel.ReadOnly = true;
            // 
            // colSeccion
            // 
            this.colSeccion.DataPropertyName = "seccionJoel";
            this.colSeccion.HeaderText = "Seccion";
            this.colSeccion.Name = "colSeccion";
            this.colSeccion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cursos a cargo";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Seleccione un curso para registrar notas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 64);
            this.panel1.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(26, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Listar Cursos";
            // 
            // frmListarCursos_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCursos);
            this.Name = "frmListarCursos_profesor";
            this.Text = "frmListarCursos_profesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}