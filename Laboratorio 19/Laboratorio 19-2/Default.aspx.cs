using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Laboratorio_19_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected async void btnGetAllValues_Click(object sender, EventArgs e)
        {
            await GetAllValues();
        }

        private async Task GetAllValues()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");

                try
                {
                    HttpResponseMessage response = await client.GetAsync("values");
                    response.EnsureSuccessStatusCode();

                    var responseData = await response.Content.ReadAsStringAsync();
                    myLabel.Text = "Respuesta del API (todos los valores): " + responseData;
                }
                catch (Exception ex)
                {
                    myLabel.Text = "Error al conectar con el API: " + ex.Message;
                }
            }
        }
    }
}
