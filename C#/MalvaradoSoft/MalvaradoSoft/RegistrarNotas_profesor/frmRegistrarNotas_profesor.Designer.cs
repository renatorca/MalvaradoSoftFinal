﻿namespace MalvaradoSoft.RegistrarNotas_profesor
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
            this.cboGradoSeccion = new System.Windows.Forms.ComboBox();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.dgvRegistroNotas = new System.Windows.Forms.DataGridView();
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGradoSeccion
            // 
            this.cboGradoSeccion.FormattingEnabled = true;
            this.cboGradoSeccion.Location = new System.Drawing.Point(111, 61);
            this.cboGradoSeccion.Name = "cboGradoSeccion";
            this.cboGradoSeccion.Size = new System.Drawing.Size(175, 21);
            this.cboGradoSeccion.TabIndex = 14;
            // 
            // cboCursos
            // 
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(111, 24);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(175, 21);
            this.cboCursos.TabIndex = 13;
            // 
            // dgvRegistroNotas
            // 
            this.dgvRegistroNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreAlumno,
            this.colPC1,
            this.colPC2,
            this.colEx1,
            this.colPC3,
            this.colPC4,
            this.colEx2});
            this.dgvRegistroNotas.Location = new System.Drawing.Point(12, 151);
            this.dgvRegistroNotas.Name = "dgvRegistroNotas";
            this.dgvRegistroNotas.Size = new System.Drawing.Size(538, 199);
            this.dgvRegistroNotas.TabIndex = 12;
            this.dgvRegistroNotas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingresarFeedback);
            // 
            // colNombreAlumno
            // 
            this.colNombreAlumno.HeaderText = "Nombre";
            this.colNombreAlumno.Name = "colNombreAlumno";
            this.colNombreAlumno.ReadOnly = true;
            this.colNombreAlumno.Width = 300;
            // 
            // colPC1
            // 
            this.colPC1.HeaderText = "PC1";
            this.colPC1.Name = "colPC1";
            this.colPC1.Width = 30;
            // 
            // colPC2
            // 
            this.colPC2.HeaderText = "PC2";
            this.colPC2.Name = "colPC2";
            this.colPC2.Width = 30;
            // 
            // colEx1
            // 
            this.colEx1.HeaderText = "EX1";
            this.colEx1.Name = "colEx1";
            this.colEx1.Width = 30;
            // 
            // colPC3
            // 
            this.colPC3.HeaderText = "PC3";
            this.colPC3.Name = "colPC3";
            this.colPC3.Width = 30;
            // 
            // colPC4
            // 
            this.colPC4.HeaderText = "PC4";
            this.colPC4.Name = "colPC4";
            this.colPC4.Width = 30;
            // 
            // colEx2
            // 
            this.colEx2.HeaderText = "EX2";
            this.colEx2.Name = "colEx2";
            this.colEx2.Width = 30;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(386, 110);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(84, 110);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grado y seccion:";
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
            // frmRegistrarNotas_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 367);
            this.Controls.Add(this.cboGradoSeccion);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.dgvRegistroNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistrarNotas_profesor";
            this.Text = "frmRegistrarNotas_profesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGradoSeccion;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.DataGridView dgvRegistroNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}