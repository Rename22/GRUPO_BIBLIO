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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarCredenciales(txtCorreo.Text, txtContraseña.Text))
            {
                var c = new Conexion();
                string perfil = c.ObtenerPerfil(txtCorreo.Text);

                MessageBox.Show("Login exitoso");
                var formPrincipal = new FormPrincipal(perfil);
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }
        }

        private bool ValidarCredenciales(string correo, string contrasena)
        {
            var c = new Conexion();
            var sql = $"SELECT COUNT(1) FROM Usuarios WHERE Correo = '{correo}' AND Contrasena = '{contrasena}'";
            return c.Validar(sql);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Lógica para recuperación de contraseñas
            MessageBox.Show("Funcionalidad de recuperación de contraseñas no implementada");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formRegistro = new Form1();
            formRegistro.Show();
            this.Hide();
        }
    }
}
