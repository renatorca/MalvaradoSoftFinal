namespace MalvaradoSoft.GestionSecretario
{
    partial class frmAsignarEventoCursosXSeccion_secretario
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
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.labelGrado = new System.Windows.Forms.Label();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarEventos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGrado);
            this.groupBox1.Controls.Add(this.labelGrado);
            this.groupBox1.Controls.Add(this.labelSeccion);
            this.groupBox1.Controls.Add(this.cmbSeccion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(60, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sección";
            // 
            // cmbGrado
            // 
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Location = new System.Drawing.Point(76, 19);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(112, 28);
            this.cmbGrado.TabIndex = 9;
            this.cmbGrado.SelectedValueChanged += new System.EventHandler(this.CmbGrado_SelectedValueChanged);
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelGrado.Location = new System.Drawing.Point(12, 22);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(52, 17);
            this.labelGrado.TabIndex = 7;
            this.labelGrado.Text = "Grado:";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelSeccion.Location = new System.Drawing.Point(12, 66);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(62, 17);
            this.labelSeccion.TabIndex = 8;
            this.labelSeccion.Text = "Seccion:";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(76, 61);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(112, 28);
            this.cmbSeccion.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(163, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEditarEventos
            // 
            this.btnEditarEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditarEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnEditarEventos.ForeColor = System.Drawing.Color.White;
            this.btnEditarEventos.Location = new System.Drawing.Point(18, 230);
            this.btnEditarEventos.Name = "btnEditarEventos";
            this.btnEditarEventos.Size = new System.Drawing.Size(123, 36);
            this.btnEditarEventos.TabIndex = 20;
            this.btnEditarEventos.Text = "Editar Eventos";
            this.btnEditarEventos.UseVisualStyleBackColor = false;
            this.btnEditarEventos.Click += new System.EventHandler(this.BtnEditarHorario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 64);
            this.panel1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Asignar Evento Al Curso";
            // 
            // frmAsignarEventoCursosXSeccion_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 297);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditarEventos);
            this.Name = "frmAsignarEventoCursosXSeccion_secretario";
            this.Text = "frmAsignarEventoCursosXSeccion_secretario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}