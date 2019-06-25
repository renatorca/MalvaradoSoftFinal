namespace MalvaradoSoft.RegistrarNotas_profesor
{
    partial class frmRegistrarFeedback_profesor
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(319, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFeed
            // 
            this.txtFeed.Location = new System.Drawing.Point(12, 41);
            this.txtFeed.Multiline = true;
            this.txtFeed.Name = "txtFeed";
            this.txtFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeed.Size = new System.Drawing.Size(382, 117);
            this.txtFeed.TabIndex = 16;
            this.txtFeed.TextChanged += new System.EventHandler(this.editarFeedback);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Feedback:";
            // 
            // frmRegistrarFeedback_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 169);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtFeed);
            this.Controls.Add(this.label2);
            this.Name = "frmRegistrarFeedback_profesor";
            this.Text = "frmRegistrarFeedback_profesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confirmacionCierre);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtFeed;
        private System.Windows.Forms.Label label2;
    }
}