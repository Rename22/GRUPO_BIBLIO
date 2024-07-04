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
    public partial class FormGestionLibros : Form
    {
        public FormGestionLibros()
        {
            InitializeComponent();
            CargarLibros();
        }

        private void FormGestionLibros_Load(object sender, EventArgs e)
        {

        }
        private void CargarLibros()
        {
            var c = new Conexion();
            var sql = "SELECT * FROM Libros";
            var dt = c.ObtenerDatos(sql);
            dgvLibros.DataSource = dt;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            var formLibro = new FormLibro();
            formLibro.ShowDialog();
            CargarLibros();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["Id"].Value);
                var c = new Conexion();
                var sql = $"SELECT * FROM Libros WHERE Id = {id}";
                var dt = c.ObtenerDatos(sql);

                if (dt.Rows.Count > 0)
                {
                    var libro = new Libro
                    {
                        Id = id,
                        Titulo = dt.Rows[0]["Titulo"].ToString(),
                        Autor = dt.Rows[0]["Autor"].ToString(),
                        Editorial = dt.Rows[0]["Editorial"].ToString(),
                        AnioPublicacion = Convert.ToInt32(dt.Rows[0]["AnioPublicacion"]),
                        Categoria = dt.Rows[0]["Categoria"].ToString()
                    };

                    var formLibro = new FormLibro(libro);
                    formLibro.ShowDialog();
                    CargarLibros(); // Refrescar la lista de libros después de editar uno
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["Id"].Value);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var libro = new Libro();
                    libro.Eliminar(id);
                    CargarLibros(); // Refrescar la lista de libros después de eliminar uno
                }
            }
        }
    }
}
