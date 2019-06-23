namespace MalvaradoSoft.RegistrarNotas_profesor
{
    partial class frmRegistrarNotas_profesor
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
            this.dgvRegistroNotas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboBimestre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroNotas
            // 
            this.dgvRegistroNotas.AllowUserToAddRows = false;
            this.dgvRegistroNotas.AllowUserToDeleteRows = false;
            this.dgvRegistroNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroNotas.Location = new System.Drawing.Point(12, 151);
            this.dgvRegistroNotas.Name = "dgvRegistroNotas";
            this.dgvRegistroNotas.ReadOnly = true;
            this.dgvRegistroNotas.Size = new System.Drawing.Size(538, 199);
            this.dgvRegistroNotas.TabIndex = 12;
            this.dgvRegistroNotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingresarFeedback);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(381, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sección:";
            // 
            // txtCourse
            // 
            this.txtCourse.Enabled = false;
            this.txtCourse.Location = new System.Drawing.Point(82, 19);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 14;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(82, 49);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 15;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(82, 86);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(100, 20);
            this.txtSection.TabIndex = 16;
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(316, 19);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(121, 21);
            this.cboAno.TabIndex = 17;
            // 
            // cboBimestre
            // 
            this.cboBimestre.FormattingEnabled = true;
            this.cboBimestre.Location = new System.Drawing.Point(316, 49);
            this.cboBimestre.Name = "cboBimestre";
            this.cboBimestre.Size = new System.Drawing.Size(121, 21);
            this.cboBimestre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bimestre:";
            // 
            // btnBuscarAlumnos
            // 
            this.btnBuscarAlumnos.Location = new System.Drawing.Point(243, 122);
            this.btnBuscarAlumnos.Name = "btnBuscarAlumnos";
            this.btnBuscarAlumnos.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarAlumnos.TabIndex = 21;
            this.btnBuscarAlumnos.Text = "Buscar alumnos";
            this.btnBuscarAlumnos.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnos.Click += new System.EventHandler(this.btnBuscarAlumnos_Click);
            // 
            // frmRegistrarNotas_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 367);
            this.Controls.Add(this.btnBuscarAlumnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBimestre);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistroNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistrarNotas_profesor";
            this.Text = "frmRegistrarNotas_profesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistroNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboBimestre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAlumnos;
    }
}