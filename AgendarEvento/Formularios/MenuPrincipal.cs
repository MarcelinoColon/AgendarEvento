using AgendarEvento.Formularios;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1000; 
            this.Height = 600; 
            this.FormBorderStyle = FormBorderStyle.Sizable; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgendarEvento agendarEventoForm = new AgendarEvento();
            agendarEventoForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();
            cliente.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboForm combo = new ComboForm();
            combo.Show();
            this.Close();
        }
    }
}
