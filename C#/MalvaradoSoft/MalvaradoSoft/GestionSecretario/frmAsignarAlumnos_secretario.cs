﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MalvaradoSoft.GestionSecretario
{
    public partial class frmAsignarAlumnos_secretario : Form
    {
        public frmAsignarAlumnos_secretario()
        {
            InitializeComponent();
        }

        private void btnCrearSeccion_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("¿Está seguro de registrar la sección?", "Mensaje de validación", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}