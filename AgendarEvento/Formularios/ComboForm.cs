using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendarEvento.Formularios
{
    public partial class ComboForm : Form
    {
        public ComboForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Width = 1000;
            this.Height = 600;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = ComboDAL.PresentarCombo();
        }
        private void ComboForm_Load(object sender, EventArgs e)
        {
            refressPantalla();
            txtComboid.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Combo combo = new Combo();
            combo.Nombre = txtNombre.Text;
            combo.Descripcion = txtDescripcion.Text;


            if (dataGridView1.SelectedRows.Count == 1)
            {

                int comboid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Comboid"].Value);

                if (comboid != null)
                {
                    combo.Comboid = comboid;
                    int result = ComboDAL.ModificarCombo(combo);

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
                int result = ComboDAL.AgregarCombo(combo);

                if (result > 0)
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtComboid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Comboid"].Value);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txtDescripcion.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Descripcion"].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtComboid.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {

                int comboid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Comboid"].Value);
                int resultado = ComboDAL.EliminarCombo(comboid);
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
