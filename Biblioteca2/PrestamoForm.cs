using System;
using System.Collections;
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
    public partial class frmPrestamo : Form
    {
        public Biblioteca biblioteca;
        private List<Prestamo> prestamos = new List<Prestamo>();

        public frmPrestamo(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca;
        }

        private void CargarTabla()
        {
            dtgvPrestamos.Rows.Clear();

            foreach (Prestamo p in prestamos)
            {
                int fila = dtgvPrestamos.Rows.Add();

                dtgvPrestamos.Rows[fila].Cells[0].Value = p.LectorDni;
                dtgvPrestamos.Rows[fila].Cells[1].Value = p.LibroNombre;
            }
        }
        public string prestarLibro(string tituloLibro, string dniLector)
        {
            Lector lector = biblioteca.buscarLector(dniLector);
            Libro libro = biblioteca.buscarLibro(tituloLibro);

            if (lector == null)
            {
                return "LECTOR INEXISTENTE";
            }

            if (libro == null)
            {
                return "LIBRO INEXISTENTE";
            }

            if (lector.Libros.Count >= 3)
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            lector.Libros.Add(libro);
            biblioteca.eliminarLibro(libro.Nombre);
            prestamos.Add(new Prestamo(lector.Dni, libro.Nombre));

            return "PRESTAMO EXITOSO";

        }
        private void btnPedirLibro_Click(object sender, EventArgs e)
        {            

            string dniLector = txtDni.Text;
            string tituloLibro = txtLibro.Text;

            string resultado = prestarLibro(tituloLibro, dniLector);

            switch (resultado)
            {
                case "PRESTAMO EXITOSO":
                    MessageBox.Show("Se realizó el préstamo correctamente", "PRESTAMO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "LIBRO INEXISTENTE":
                    MessageBox.Show("LIBRO INEXISTENTE. El libro no existe en la biblioteca", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "TOPE DE PRESTAMO ALCANZADO":
                    MessageBox.Show("TOPE DE PRESTAMO ALCANZADO. El lector ya tiene tres libros en préstamo.", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "LECTOR INEXISTENTE":
                    MessageBox.Show("LECTOR INEXISTENTE. El lector no se encuentra registrado en la biblioteca", "PRESTAMO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            CargarTabla();
        }
    

        private void frmPrestamo_Load(object sender, EventArgs e)
        {

            List<Lector> lectores = biblioteca.getLectores();

            foreach (Lector lector in lectores)
            {
                foreach (Libro libro in lector.Libros)
                {
                    prestamos.Add(new Prestamo(lector.Dni, libro.getTitulo()));
                }
            }

            CargarTabla();

        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            Lector lector = biblioteca.buscarLector(txtDni.Text);
            if (lector != null)
            {
                Libro libro = lector.buscarLibro(txtLibro.Text);
                if (libro != null)
                {

                    biblioteca.agregarLibro(libro.Nombre, libro.Autor, libro.Editorial);
                    lector.eliminarLibro(libro.Nombre);
                    prestamos.RemoveAll(prestamo => prestamo.LibroNombre == libro.Nombre);
                    CargarTabla();
                    MessageBox.Show("Se devolvió libro correctamente", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Ups! libro incorrecto", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ups! lector incorrecto", "DEVOLUCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
