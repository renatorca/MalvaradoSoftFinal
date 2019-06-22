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
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroNotas)).BeginInit();
            this.SuspendLayout();
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
            this.btnGuardar.Location = new System.Drawing.Point(402, 113);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // frmRegistrarNotas_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 367);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}