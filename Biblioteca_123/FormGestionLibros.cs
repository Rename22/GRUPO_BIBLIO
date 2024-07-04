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
            CargarCategorias();
            CargarLibros();
        }
        private void CargarCategorias()
        {
            var c = new Conexion();
            var sql = "SELECT DISTINCT Categoria FROM Libros";
            var dt = c.ObtenerDatos(sql);
            cmbCategorias.Items.Clear();
            cmbCategorias.Items.Add("Todas");
            foreach (DataRow row in dt.Rows)
            {
                cmbCategorias.Items.Add(row["Categoria"].ToString());
            }
            cmbCategorias.SelectedIndex = 0;
        }
        private void FiltrarLibros(string categoria)
        {
            var c = new Conexion();
            var sql = categoria == "Todas" ? "SELECT * FROM Libros" : $"SELECT * FROM Libros WHERE Categoria = '{categoria}'";
            var dt = c.ObtenerDatos(sql);
            dgvLibros.DataSource = dt;
        }
        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cmbCategorias.SelectedItem.ToString();
            FiltrarLibros(categoriaSeleccionada);
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
            formLibro.Show();
            this.Hide();
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
                    formLibro.FormClosed += new FormClosedEventHandler(FormLibro_FormClosed);
                    formLibro.Show();
                    this.Hide();
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

        private void btnVerDetalles_Click(object sender, EventArgs e)
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

                    var formDetalleLibro = new FormDetalleLibro(libro);
                    formDetalleLibro.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro de la lista para ver sus detalles.");
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            CargarLibros();
        }

        
    }
}
