namespace MalvaradoSoft.GestionSecretario
{
    partial class frmGestionarMatricula_secretario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnDeseleccionarTodo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Dni,
            this.Nombre,
            this.ApellidoPat,
            this.Column2,
            this.Ticket});
            this.dataGridView1.Location = new System.Drawing.Point(19, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = " ";
            this.Column1.Name = "Column1";
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ApellidoPat
            // 
            this.ApellidoPat.HeaderText = "Apel. Paterno";
            this.ApellidoPat.Name = "ApellidoPat";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apel. Materno";
            this.Column2.Name = "Column2";
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "Numero Boleta";
            this.Ticket.Name = "Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matricular Alumnos";
            // 
            // btnMatricular
            // 
            this.btnMatricular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnMatricular.ForeColor = System.Drawing.Color.White;
            this.btnMatricular.Location = new System.Drawing.Point(667, 447);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(120, 34);
            this.btnMatricular.TabIndex = 3;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = false;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeseleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDeseleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(216, 447);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(164, 34);
            this.btnDeseleccionarTodo.TabIndex = 4;
            this.btnDeseleccionarTodo.Text = "Deseleccionar Todo";
            this.btnDeseleccionarTodo.UseVisualStyleBackColor = false;
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 65);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Matricular Alumnos";
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.BackColor = System.Drawing.Color.Firebrick;
            this.btnSeleccionarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSeleccionarTodo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(19, 447);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(164, 34);
            this.btnSeleccionarTodo.TabIndex = 26;
            this.btnSeleccionarTodo.Text = "Seleccionar Todo";
            this.btnSeleccionarTodo.UseVisualStyleBackColor = false;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // frmGestionarMatricula_secretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 493);
            this.Controls.Add(this.btnSeleccionarTodo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeseleccionarTodo);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGestionarMatricula_secretario";
            this.Text = "frmGestionarMatricula_secretario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnDeseleccionarTodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarTodo;
    }
}