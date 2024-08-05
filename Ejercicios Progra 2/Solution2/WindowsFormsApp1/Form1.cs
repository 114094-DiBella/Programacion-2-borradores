using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Http;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarMateriales();
        }

        private async void cargarMateriales()
        {
          /*  
            string url = "https://localhost:7171/api/Orden/materiales";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
           // var lst = JsonConvert.DeserializeObject<List<sbyte>>(result);
           // cboMateriales.DataSource = lst;
            cboMateriales.DisplayMember = "Nombre";
            cboMateriales.ValueMember = "Id";
            */
        }
    }
}
