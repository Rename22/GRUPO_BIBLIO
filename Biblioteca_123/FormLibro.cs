using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_123
{
    public partial class FormLibro : Form
    {
        private Libro libro;
        public FormLibro(Libro libro = null)
        {
            InitializeComponent();
            this.libro = libro;

            if (libro != null)
            {
                // Si se está editando un libro, cargar los datos en el formulario
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                txtEditorial.Text = libro.Editorial;
                txtAnioPublicacion.Text = libro.AnioPublicacion.ToString();
                txtCategoria.Text = libro.Categoria;
            }
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                if (libro == null) // Añadir un nuevo libro
                {
                    libro = new Libro
                    {
                        Titulo = txtTitulo.Text,
                        Autor = txtAutor.Text,
                        Editorial = txtEditorial.Text,
                        AnioPublicacion = int.Parse(txtAnioPublicacion.Text),
                        Categoria = txtCategoria.Text
                    };
                    libro.Insertar(libro);
                }
                else // Editar un libro existente
                {
                    libro.Titulo = txtTitulo.Text;
                    libro.Autor = txtAutor.Text;
                    libro.Editorial = txtEditorial.Text;
                    libro.AnioPublicacion = int.Parse(txtAnioPublicacion.Text);
                    libro.Categoria = txtCategoria.Text;
                    libro.Editar(libro);
                }

                MessageBox.Show("Libro guardado correctamente");
                this.Close();
            }
        }




        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Los campos Título y Autor son obligatorios");
                return false;
            }

            if (!int.TryParse(txtAnioPublicacion.Text, out _))
            {
                MessageBox.Show("El año de publicación debe ser un número válido");
                return false;
            }

            return true;
        }
    }
}
