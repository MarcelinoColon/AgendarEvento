using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendarEvento
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Width = 500;
            this.Height = 300;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            textBox2.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private bool Autenticar(string usuario, string contraseña)
        {
            // Aquí deberías verificar las credenciales
            // Para fines de demostración, vamos a asumir que el usuario y la contraseña son "admin"
            return usuario == "admin" && contraseña == "admin";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            String contraseña = textBox2.Text;

            if (Autenticar(usuario, contraseña))
            {
                MenuPrincipal menuPricipal = new MenuPrincipal();
                menuPricipal.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK); 
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para restablecer su contraseña, por favor contacte con el administrador.");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para restablecer su contraseña, por favor contacte con el administrador.");
        }
    }
}
