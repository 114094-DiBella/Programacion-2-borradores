using ClassLibrary1.Models;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Net.Http.Json;
using WinFormsApp1.Http;
using static Azure.Core.HttpHeader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int auxDetalle;
        public Form1()
        {
            InitializeComponent();
            auxDetalle= 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarMateriales();

        }

        private async void cargarMateriales()
        {
           /* Al cargar el formulario se deberá tener el combo de productos cargado según
            los registros de la tabla T_Materiales*/

            string url = "https://localhost:7171/api/Orden/materiales";
            var result = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Material>>(result);
            cbMaterial.DataSource = lst;
            cbMaterial.DisplayMember = "Nombre";
            cbMaterial.ValueMember = "idMaterial";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*Deberá validar los campos obligatorios según la definición de campos de tabla
            T_ORDENES*/

            if (dtpFecha.Value == DateTime.Now) {
                
                MessageBox.Show("Debe ingresar una fecha distinta de Hoy", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(txtResponsable.Text == null)
            {
                MessageBox.Show("Debe ingresar un responsable", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbMaterial.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar un material", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtCantidad.Text == null) {
                MessageBox.Show("Debe seleccionar una cantidad", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*? Deberá controlar que no se pueden grabar dos veces el mismo material como
                detalle*/
            Material item = (Material)cbMaterial.SelectedItem;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["ColId"].Value != null &&
                     row.Cells["ColMaterial"].Value != null &&
                     row.Cells["ColMaterial"].Value.ToString().Equals(item.Nombre))
                {
                    MessageBox.Show("El Material: " + cbMaterial.Text + " ya se encuentra registrado", "Informaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int cantidad =Convert.ToInt32( txtCantidad.Text);
                if(item.Stock <= cantidad)
                {
                    MessageBox.Show("La cantidad ingresada es mayor al stock disponible!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DetalleOrden det = new DetalleOrden(auxDetalle,item,cantidad);
                dataGridView1.Rows.Add(new object[] { det.IdDetalle, det.Material.Nombre, det.Material.Stock, det.Cantidad, "Quitar" });
                auxDetalle++;



            }
        }

        

        /*? Deberá controlar que no se pueden grabar dos veces el mismo material como
        detalle*/

        /*? Deberá controlar además que solo es posible confirmar una orden si todos los
        materiales incluidos tienen stock suficiente.*/

        /*? Al confirmar deberá controlar que se hayan ingresado datos de al menos un
        material.*/

        /*? Deberá indicar la navegación de los componentes de arriba hacia abajo.*/

        /*? Programar el botón Quitar por cada fila de la grilla que permita eliminar un
        detalle de la orden de retiro.*/

        /*? Al registrar una orden se deberá mostrar un mensaje de confirmación
        indicando el número generado y la pantalla deberá quedar lista para una
        nueva carga.*/


    }
}
