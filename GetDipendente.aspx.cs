using DemoAspx.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace DemoAspx
{
    public partial class GetDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void LoadDipendente(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiEndpoint = "https://localhost:44321/getById?id=" + txtID.Text;
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                string jsonResponse = await response.Content.ReadAsStringAsync();
                DipendenteResponse dipendenteResponse = JsonConvert.DeserializeObject<DipendenteResponse>(jsonResponse);
                Dipendente dipendente = dipendenteResponse.dipendente;

                txtNome.Text = dipendente.nome;
                txtCognome.Text = dipendente.cognome;
                txtEta.Text = dipendente.eta.ToString();
                
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}