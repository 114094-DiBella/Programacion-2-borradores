using FormBack.Http;
using ModelosDeClases.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FormBack
{
    public partial class Form1 : Form
    {
        private Driver driver;
        public Form1()
        {
            InitializeComponent();
            driver = new Driver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            dtpBirth.Value = DateTime.Now;
            cargarEquipos();
        }

        private async void cargarEquipos()
        {
            string url = "https://localhost:7206/api/Formula/teams";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Team>>(result);
            cboTeam.DataSource = lst;
            cboTeam.DisplayMember = "TeamName";
            cboTeam.ValueMember = "TeamId";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un equipo
            if (string.IsNullOrWhiteSpace(cboTeam.Text))
            {
                MessageBox.Show("Debe seleccionar un Team!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se hayan ingresado los nombres y apellidos
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre y Apellido válidos!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se haya ingresado la nacionalidad
            if (string.IsNullOrWhiteSpace(txtNation.Text))
            {
                MessageBox.Show("Debe ingresar una Nacionalidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verificar si el driver ya está en la lista
            foreach (DataGridViewRow row in dgvDrivers.Rows)
            {
                if (row.Cells["idDrivCol"].Value != null &&
                    row.Cells["colFirstName"].Value != null &&
                    row.Cells["colLastName"].Value != null &&
                    row.Cells["colFirstName"].Value.ToString().Equals(txtName.Text) &&
                    row.Cells["colLastName"].Value.ToString().Equals(txtLastName.Text))
                {
                    MessageBox.Show("DRIVER: " + txtName.Text + " " + txtLastName.Text + " ya se encuentra en la lista!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Agregar el driver al DataGridView
            dgvDrivers.Rows.Add(new object[] { 0, txtName.Text, txtLastName.Text, txtNation.Text, cboTeam.Text });

            // Limpiar los campos después de agregar
            txtName.Clear();
            txtLastName.Clear();
            txtNation.Clear();
            cboTeam.SelectedIndex = -1;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTeam.Text))
            {
                MessageBox.Show("Debe seleccionar un Team!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se hayan ingresado los nombres y apellidos
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre y Apellido válidos!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar que se haya ingresado la nacionalidad
            if (string.IsNullOrWhiteSpace(txtNation.Text))
            {
                MessageBox.Show("Debe ingresar una Nacionalidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await guardarDriver();

        }

        private async Task guardarDriver()
        {
            try
            {
                // Crear un nuevo objeto Driver y asignar los valores
                Driver driver = new Driver
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Nationality = txtNation.Text,
                    TeamId = Convert.ToInt32(cboTeam.SelectedValue), // Asegúrate de que SelectedValue esté correctamente configurado
                    DateOfBirth = dtpBirth.Value
                };

                // Serializar el objeto Driver a JSON
                string bodyContent = JsonConvert.SerializeObject(driver);

                // Definir la URL de la API
                string url = "https://localhost:7206/api/Formula/CreateDriver";

                // Hacer la solicitud POST a la API
                var result = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

                // Verificar el resultado de la solicitud
                if (result.Equals("Driver creado exitosamente"))
                {
                    MessageBox.Show("Driver registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error, no se pudo crear el driver", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDrivers.Columns["Acciones"].Index && e.RowIndex >= 0)
            {
                // Confirmar la eliminación
                var result = MessageBox.Show("¿Está seguro de que desea quitar este piloto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila del DataGridView
                    dgvDrivers.Rows.RemoveAt(e.RowIndex);
                }
            }

        }
    }
}
