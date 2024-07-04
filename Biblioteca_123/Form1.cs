    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbPerfil.Items.Add("Administrador");
            cbPerfil.Items.Add("Bibliotecario");
            cbPerfil.Items.Add("Usuario");
            cbPerfil.SelectedIndex = 2;
        }


        private void button1(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                // Código para registrar al usuario
                MessageBox.Show("Usuario registrado correctamente");
                // Aquí puedes agregar la lógica para guardar el usuario en tu base de datos
            }
        }
        private bool ValidarFormulario()
        {
            // Validar Nombre
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return false;
            }

            // Validar Apellido
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El apellido es obligatorio");
                return false;
            }

            // Validar Correo Electrónico
            if (!Regex.IsMatch(textBox3.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Correo electrónico no válido");
                return false;
            }

            // Validar Contraseña
            if (textBox4.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                return false;
            }

            // Validar Confirmar Contraseña
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }

            // Validar Celular
            if (!Regex.IsMatch(textBox6.Text, @"^\d+$"))
            {
                MessageBox.Show("El celular debe ser un número válido");
                return false;
            }

            return true;
        }
        private void button2 (object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Datos usuario = new Datos
                {
                    Nombre = textBox1.Text,
                    Apellido = textBox2.Text,
                    Correo = textBox3.Text,
                    Contrasena = textBox4.Text,
                    Celular = textBox5.Text,
                    Perfil = cbPerfil.SelectedItem.ToString() // Obtener el perfil seleccionado
                };

                usuario.Insertar(usuario);

                MessageBox.Show("Usuario registrado correctamente");
                LimpiarFormulario();
            }

        }
        private void LimpiarFormulario()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();       
            cbPerfil.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Formulario = new FormLogin();
            Formulario.Show();
            this.Hide();
        }

        private void cbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
