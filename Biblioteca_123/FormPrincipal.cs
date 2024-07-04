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
    public partial class FormPrincipal : Form
    {
        private string perfil;

        public FormPrincipal(string perfil)
        {
            InitializeComponent();
            this.perfil = perfil;
            ConfigurarPermisos();
        }
        private void ConfigurarPermisos()
        {
            if (perfil == "Administrador")
            {
                // Permisos completos
                btnGestionUsuarios.Visible = true;
                btnGestionLibros.Visible = true;
                btnReportes.Visible = true;
            }
            else if (perfil == "Bibliotecario")
            {
                // Permisos limitados
                btnGestionUsuarios.Visible = false;
                btnGestionLibros.Visible = true;
                btnReportes.Visible = true;
            }
            else if (perfil == "Usuario")
            {
                // Permisos mínimos
                btnGestionUsuarios.Visible = false;
                btnGestionLibros.Visible = false;
                btnReportes.Visible = false;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
