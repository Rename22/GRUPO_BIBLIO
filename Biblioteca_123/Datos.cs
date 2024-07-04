using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Biblioteca_123
{
    public class Datos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Celular { get; set; }
        public string Perfil { get; set; }

        public void Insertar(Datos u)
        {
            var c = new Conexion();
            var sql = $"INSERT INTO Usuarios (Nombre, Apellido, Correo, Contrasena, Celular, Perfil) VALUES ('{u.Nombre}', '{u.Apellido}', '{u.Correo}', '{u.Contrasena}', '{u.Celular}', '{u.Perfil}')";
            c.Insert(sql);
        }





    }
}
