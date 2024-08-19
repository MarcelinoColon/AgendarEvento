using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendarEvento
{
    public partial class AgendarEvento : Form
    {
        public AgendarEvento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1000;
            this.Height = 600;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        Categorias cat = new Categorias();

        private void AgendarEvento_Load(object sender, EventArgs e)
        {
            refressPantalla();

            cboCliente.DataSource = cat.CargarClientes();
            cboCliente.DisplayMember = "nombre";
            cboCliente.ValueMember = "clienteid";


            cboCombo.DataSource = cat.CargarCombos();
            cboCombo.DisplayMember = "nombre_Combo";
            cboCombo.ValueMember = "comboid";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = EventoDAL.PresentarEvento();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.ClienteId = Convert.ToInt32(cboCliente.SelectedValue);
            evento.ComboId = Convert.ToInt32(cboCombo.SelectedValue);
            evento.TipoEvento = cboTipoEvento.Text;
            evento.FechaEvento = txtFecha.Text;
            evento.HoraInicio = txtHoraInicio.Text;
            evento.HoraFin = txtHoraFin.Text;
            evento.Direccion = txtDireccion.Text;
            evento.Animacion = txtAnimacion.Text;
            evento.NotasAdicionales = txtNotas.Text;

            int result = EventoDAL.AgendarEvento(evento);

            if (result > 0)
            {
                MessageBox.Show("Exito al Guardar");
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
            refressPantalla();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int eventoid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["eventoid"].Value);
                int resultado = EventoDAL.EliminarEvento(eventoid);
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
    }
}
