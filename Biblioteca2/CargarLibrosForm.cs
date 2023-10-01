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
    public partial class frmCargarLibros : Form
    {
        private Biblioteca biblioteca;
        public frmCargarLibros(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string editorial = txtEditorial.Text.Trim();

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(autor) && !string.IsNullOrEmpty(editorial))
            {
                bool status = biblioteca.agregarLibro(nombre, autor, editorial);
                if (status)
                {
                    MessageBox.Show("Se cargó el libro correctamente", "LIBRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Text = "";
                    txtAutor.Text = "";
                    txtEditorial.Text = "";

                }
                else
                {
                    MessageBox.Show("Ups! Este libro ya existe", "LIBRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Completa todos los campos correctamente", "LIBRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
