using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmAltaLectores : Form
    {
        public Biblioteca biblioteca;
        public frmAltaLectores(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dniStr = txtDNI.Text.Trim();

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
            {
                if (int.TryParse(dniStr, out int dni) && dni >= 1000000 && dni <= 99999999)
                {
                    bool status = biblioteca.altaLector(nombre, apellido, dniStr);
                    if (status)
                    {
                        MessageBox.Show("Se cargó el lector correctamente", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDNI.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ups! Este lector ya existe", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no es válido. Debe ser un número de 7 a 8 dígitos.", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos correctamente", "LECTOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
