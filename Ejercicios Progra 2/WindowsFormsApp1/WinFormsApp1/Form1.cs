using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using ClassLibrary1.dominio;
using Newtonsoft.Json;

namespace RecetasFront
{
    public partial class Frm_Alta : Form
    {
        private Dictionary<int, Ingredientes> ingredientesDict;

        public Frm_Alta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await cargarCombo();
        }

        private async Task cargarCombo()
        {
            string url = "https://localhost:7134/api/controller/ingredientes"; // Verifica la URL correcta
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var result = await client.GetAsync(url);
                    result.EnsureSuccessStatusCode();

                    var body = await result.Content.ReadAsStringAsync();
                    var listaIngredientes = JsonConvert.DeserializeObject<List<Ingredientes>>(body);

                    // Almacenar ingredientes en un diccionario para acceso rápido
                    ingredientesDict = listaIngredientes.ToDictionary(i => i.Id);

                    cbIngrediente.DataSource = listaIngredientes;
                    cbIngrediente.DisplayMember = "Name";
                    cbIngrediente.ValueMember = "Id";
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Request error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }



        

        private async void btnAgregar_Click(object sender, EventArgs e)
        {


            string url = "https://localhost:7134/api/controller/guardarReceta"; // Verifica la URL correcta
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Obtener el objeto Ingredientes usando el Id seleccionado
                    int ingredienteId = (int)cbIngrediente.SelectedValue;
                    Ingredientes ingredienteSeleccionado = ingredientesDict[ingredienteId];

                    // Crea una nueva receta con sus detalles
                    Receta nuevaReceta = new Receta
                    {
                        IdReceta = 5,
                        NameReceta = txtNombre.Text,
                        TipoReceta = 1, // Asegúrate de que este valor sea válido según tu lógica
                        Cheff = txtCheff.Text,
                        Detalles = new List<DetalleReceta>
                        {
                            new DetalleReceta
                            {
                                Ingrediente = ingredienteSeleccionado, // Usa el objeto completo
                                Cantidad = dudCantidad.SelectedIndex // Usa el valor del NumericUpDown como cadena
                            }
                        }
                    };

                    // Serializa la receta a JSON
                    var json = JsonConvert.SerializeObject(nuevaReceta);
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    // Envía la receta al servidor
                    var response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Receta guardada con éxito.");
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Request error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
    }
}
