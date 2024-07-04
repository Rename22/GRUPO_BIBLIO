using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_123
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }
        public string Categoria { get; set; }

        public void Insertar(Libro libro)
        {
            var c = new Conexion();
            var sql = $"INSERT INTO Libros (Titulo, Autor, Editorial, AnioPublicacion, Categoria) VALUES ('{libro.Titulo}', '{libro.Autor}', '{libro.Editorial}', {libro.AnioPublicacion}, '{libro.Categoria}')";
            c.Insert(sql);
        }

        public void Editar(Libro libro)
        {
            var c = new Conexion();
            var sql = $"UPDATE Libros SET Titulo = '{libro.Titulo}', Autor = '{libro.Autor}', Editorial = '{libro.Editorial}', AnioPublicacion = {libro.AnioPublicacion}, Categoria = '{libro.Categoria}' WHERE Id = {libro.Id}";
            c.Insert(sql);
        }

        public void Eliminar(int id)
        {
            var c = new Conexion();
            var sql = $"DELETE FROM Libros WHERE Id = {id}";
            c.Insert(sql);
        }
    }

}
