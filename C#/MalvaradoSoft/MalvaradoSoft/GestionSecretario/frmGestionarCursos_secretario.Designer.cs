namespace MalvaradoSoft.GestionSecretario
{
    partial class frmGestionarCursos_secretario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarCursos_secretario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarTipoNota = new System.Windows.Forms.Button();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnBorrarCurso = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gestionar Cursos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(399, 514);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(179, 34);
            this.btnRegresar.TabIndex = 33;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarTipoNota
            // 
            this.btnAgregarTipoNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarTipoNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAgregarTipoNota.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTipoNota.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTipoNota.Image")));
            this.btnAgregarTipoNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTipoNota.Location = new System.Drawing.Point(193, 514);
            this.btnAgregarTipoNota.Name = "btnAgregarTipoNota";
            this.btnAgregarTipoNota.Size = new System.Drawing.Size(174, 34);
            this.btnAgregarTipoNota.TabIndex = 32;
            this.btnAgregarTipoNota.Text = "Agregar Evaluación";
            this.btnAgregarTipoNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarTipoNota.UseVisualStyleBackColor = false;
            this.btnAgregarTipoNota.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCurso.Image")));
            this.btnAgregarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCurso.Location = new System.Drawing.Point(193, 222);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(174, 34);
            this.btnAgregarCurso.TabIndex = 31;
            this.btnAgregarCurso.Text = "Registrar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnBorrarCurso
            // 
            this.btnBorrarCurso.BackColor = System.Drawing.Color.Firebrick;
            this.btnBorrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBorrarCurso.ForeColor = System.Drawing.Color.White;
            this.btnBorrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarCurso.Image")));
            this.btnBorrarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarCurso.Location = new System.Drawing.Point(399, 222);
            this.btnBorrarCurso.Name = "btnBorrarCurso";
            this.btnBorrarCurso.Size = new System.Drawing.Size(179, 34);
            this.btnBorrarCurso.TabIndex = 30;
            this.btnBorrarCurso.Text = "Borrar Curso";
            this.btnBorrarCurso.UseVisualStyleBackColor = false;
            this.btnBorrarCurso.Click += new System.EventHandler(this.btnBorrarCurso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCursos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(165, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 156);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursos";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCursos.Location = new System.Drawing.Point(9, 20);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(452, 153);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.cmbLevel);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(165, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 94);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Curso";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Image")));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(404, 16);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(36, 33);
            this.btnBuscarUsuario.TabIndex = 25;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(144, 57);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(227, 28);
            this.cmbLevel.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 26);
            this.txtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grado:";
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnModificarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModificarCurso.ForeColor = System.Drawing.Color.White;
            this.btnModificarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCurso.Location = new System.Drawing.Point(300, 272);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(174, 34);
            this.btnModificarCurso.TabIndex = 35;
            this.btnModificarCurso.Text = "Modificar Curso";
            this.btnModificarCurso.UseVisualStyleBackColor = false;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 282;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "level";
            this.Column2.HeaderText = "Grado";
            this.Column2.Name = "Column2";
            // 
            // frmGestionarCursos_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarTipoNota);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.btnBorrarCurso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionarCursos_secretario";
            this.Text = "frmGestionarCursos_secretario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregarTipoNota;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnBorrarCurso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}