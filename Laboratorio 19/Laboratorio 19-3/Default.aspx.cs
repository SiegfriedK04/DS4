using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;

namespace Laboratorio_19_3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected async void btnGetValueById_Click(object sender, EventArgs e)
        {
            await GetValueById("2");
        }

        private async Task GetValueById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44313/api/");

                try
                {
                    HttpResponseMessage response = await client.GetAsync($"values/{id}");
                    response.EnsureSuccessStatusCode();

                    var responseData = await response.Content.ReadAsStringAsync();
                    myLabel.Text = $"Respuesta del API (valor para ID {id}): " + responseData;
                }
                catch (Exception ex)
                {
                    myLabel.Text = "Error al conectar con el API: " + ex.Message;
                }
            }
        }
    }
}
