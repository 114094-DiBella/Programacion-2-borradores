using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using ClassLibrary1.dominio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();

        }

        private async void cargarCombo()
        {
            string url = "";
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);

            var body = await result.Content.ReadAsStringAsync();
            var listaIngredientes = JsonConvert.DeserializeObject<List<Ingredientes>>(body);

            throw new NotImplementedException();
        }
    }
}
