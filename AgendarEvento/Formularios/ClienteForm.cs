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
    
    public partial class ClienteForm : Form
    {
        public void CheckboxState(bool cual, TextBox objeto)
        {
            objeto.Enabled = cual;

        }
        public ClienteForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1000;
            this.Height = 600;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Email = txtEmail.Text;
            cliente.Cedula = txtCedula.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.OtroContacto = txtOtroContacto.Text;


            if(dataGridView1.SelectedRows.Count == 1)
            {

            int clienteid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["clienteid"].Value);
           
            if (clienteid != null)
            {
                  


                cliente.ClienteId = clienteid;
                int result = ClienteDAL.ModificarCliente(cliente);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Modificar");
                }
                else
                {
                    MessageBox.Show("Error al Modificar");
                }
              }
            }
            else
            {
                int result = ClienteDAL.AgregarCliente(cliente);

                if ( result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
             
            }

            refressPantalla();



        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            refressPantalla();
            txtClienteId.Enabled = false;
        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = ClienteDAL.PresentarClientes();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtClienteId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["clienteid"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["email"].Value);
            txtCedula.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Cedula"].Value);
            txtTelefono.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Telefono"].Value);
            txtDireccion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Direccion"].Value);
            txtOtroContacto.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["OtroContacto"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            txtClienteId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtOtroContacto.Clear();
            CheckboxState(true, txtNombre);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int clienteid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteId"].Value);
                int resultado = ClienteDAL.EliminarCliente(clienteid);
                    if (resultado > 0)
                    {
                    MessageBox.Show("Eliminado con Exito");
                    }
                    else
                {
                    MessageBox.Show("Error al Eliminar");
                }

            }

            refressPantalla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir sin guardar los cambios?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Cerrar el formulario actual (AgendarEvento)
                this.Close();

                // Mostrar el formulario del menú principal
                // Asegúrate de reemplazar 'MenuPrincipal' con el nombre real del formulario del menú principal
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
            }
        }
    }
}
