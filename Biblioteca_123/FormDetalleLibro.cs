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
    public partial class FormDetalleLibro : Form
    {
        public FormDetalleLibro(Libro libro)
        {
            InitializeComponent();
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtEditorial.Text = libro.Editorial;
            txtAnioPublicacion.Text = libro.AnioPublicacion.ToString();
            txtCategoria.Text = libro.Categoria;
        }

        

        private void FormDetalleLibro_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
