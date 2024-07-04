using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_123
{
    internal class Conexion
    {
        private MySqlConnection Basedatos = new MySqlConnection("server=localhost;user=root;password=Root;database=Biblioteca_123");

        public void Insert(string sql)
        {
            Basedatos.Open();
            var command = new MySqlCommand(sql, Basedatos);
            command.ExecuteNonQuery();
            Basedatos.Close();

        }
        public bool Validar(string sql)
        {
            Basedatos.Open();
            var command = new MySqlCommand(sql, Basedatos);
            int result = Convert.ToInt32(command.ExecuteScalar());
            Basedatos.Close();
            return result == 1;
        }
        public string ObtenerPerfil(string correo)
        {
            Basedatos.Open();
            var sql = $"SELECT Perfil FROM Usuarios WHERE Correo = '{correo}'";
            var command = new MySqlCommand(sql, Basedatos);
            var perfil = command.ExecuteScalar().ToString();
            Basedatos.Close();
            return perfil;
        }
        public DataTable ObtenerDatos(string sql)
        {
            Basedatos.Open();
            var command = new MySqlCommand(sql, Basedatos);
            var adapter = new MySqlDataAdapter(command);
            var dt = new DataTable();
            adapter.Fill(dt);
            Basedatos.Close();
            return dt;
        }





































    }
}
