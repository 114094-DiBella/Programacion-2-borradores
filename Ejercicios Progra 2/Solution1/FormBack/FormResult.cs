using FormBack.Http;
using ModelosDeClases.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormBack
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            cargarRaces();
            cargarDrivers();
            cargarPosition();
            cargarResultados();
        }

        private async void cargarResultados()
        {
            // URL de la API para obtener los resultados
            string url = "https://localhost:7206/api/Formula/results";

            try
            {
                // Obtén los resultados desde la API
                var result = await ClientSingleton.GetInstance().GetAsync(url);
                var resultados = JsonConvert.DeserializeObject<List<Result>>(result);

                // Llena el DataGridView con los resultados
                foreach (var res in resultados)
                {
                    dgvResults.Rows.Add(
                        res.ResultId,
                        res.RaceId,         // Similar para RaceId
                        res.DriverId,       // Suponiendo que DriverId es un identificador, puedes querer mostrar un nombre
                        res.Position,
                        res.Points,
                        res.FasttestLapTime
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los resultados: {ex.Message}");
            }


        }

        private void cargarPosition()
        {
            int minPosc = 1;
            int maxPosc = 25;

            // Limpia los elementos actuales del ComboBox
            cbPosition.Items.Clear();

            // Agrega los elementos al ComboBox
            for (int i = minPosc; i <= maxPosc; i++)
            {
                cbPosition.Items.Add(i.ToString());
            }

            // Opcionalmente, puedes establecer el primer ítem como seleccionado
            if (cbPosition.Items.Count > 0)
            {
                cbPosition.SelectedIndex = 0;
            }
        }

        private async void cargarDrivers()
        {
            string url = "https://localhost:7206/api/Formula/drivers";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Driver>>(result);
            cbDriver.DataSource = lst;
            cbDriver.DisplayMember = "FirstName";
            cbDriver.ValueMember = "DriverId";

        }

        private async void cargarRaces()
        {
            string url = "https://localhost:7206/api/Formula/races";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Race>>(result);
            cbRace.DataSource = lst;
            cbRace.DisplayMember = "Name";
            cbRace.ValueMember = "RaceId";
        }

        private void dudPoints_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //txt de vuelta mas rapida
        }

        private async void btnAgregarResult_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos necesarios están completos
            if (cbDriver.SelectedValue == null || cbRace.SelectedValue == null || cbPosition.SelectedIndex == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            var result = new Result
            {
                DriverId = (int)cbDriver.SelectedValue,
                RaceId = (int)cbRace.SelectedValue,
                Position = (int)cbPosition.SelectedIndex,
                Points = Convert.ToInt32(txtPoints.Text),
                FasttestLapTime = txtBestLap.Text
            };

            // Serializa el objeto Result a JSON
            var jsonResult = JsonConvert.SerializeObject(result);


            // Define la URL para la API
            string url = "https://localhost:7206/api/Formula/CreateResult";

            try
            {
                // Envía el resultado a la API
                var response = await ClientSingleton.GetInstance().PostAsync(url, jsonResult);

                if (!string.IsNullOrEmpty(response))
                {
                    MessageBox.Show("Resultado agregado exitosamente.");
                    // Opcionalmente, podrías limpiar los campos o actualizar la vista
                    cbDriver.SelectedIndex = -1;
                    cbRace.SelectedIndex = -1;
                    cbPosition.SelectedIndex = -1;
                    txtBestLap.Clear();
                }
                else
                {
                    MessageBox.Show("Error al agregar el resultado. Intenta nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción: {ex.Message}");
            }

        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoints.Text))
            {

                MessageBox.Show("Debe ingresar puntos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbDriver.Text))
            {

                MessageBox.Show("Debe ingresar un piloto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbPosition.Text))
            {

                MessageBox.Show("Debe ingresar una position", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbRace.Text))
            {

                MessageBox.Show("Debe ingresar una carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            await guardarResult();

        }

        private async Task guardarResult()
        {
            try
            {

                Result result = new Result
                {
                    DriverId = Convert.ToInt32(cbDriver.SelectedIndex),
                    RaceId = Convert.ToInt32(cbRace.SelectedIndex),
                    Position = Convert.ToInt32(cbPosition.SelectedIndex),
                    Points = Convert.ToInt32(txtPoints.Text),
                    FasttestLapTime = txtBestLap.Text

                };

                string bodyContext = JsonConvert.SerializeObject(result);
                string url = "https://localhost:7206/api/Formula/CreateResult";

                var resultado = await ClientSingleton.GetInstance().PostAsync(url, bodyContext);

                if (resultado != null)
                {
                    MessageBox.Show("Resultado registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error, no se pudo registar", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cargarResultados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();   

        }
    }
}
