using DemoAspx.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;


namespace DemoAspx
{
    public partial class UpdateDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    string id = Request.QueryString["id"];
                    LoadDipendente(id);
                }
            }
        }

        private async void LoadDipendente(string id)
        {
            using(HttpClient client = new HttpClient())
            {
                string apiEndpoint = "https://localhost:44321/getById?id=" + id;
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                string jsonResponse = await response.Content.ReadAsStringAsync();
                DipendenteResponse dipendenteResponse = JsonConvert.DeserializeObject<DipendenteResponse>(jsonResponse);

                Dipendente dipendente = dipendenteResponse.dipendente;

                txtID.Text = dipendente.id.ToString();
                txtNome.Text = dipendente.nome;
                txtCognome.Text = dipendente.cognome;
                txtEta.Text = dipendente.eta.ToString();
            }
        }

        protected async void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            Dipendente dipendenteUp = new Dipendente();
            dipendenteUp.nome = txtNome.Text;
            dipendenteUp.cognome = txtCognome.Text;
            dipendenteUp.eta = int.Parse(txtEta.Text);

            string jsonDipendente = Newtonsoft.Json.JsonConvert.SerializeObject(dipendenteUp);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiEndpoint = "https://localhost:44321/updateDipendente?id=" + id;
                    HttpResponseMessage response = await client.PutAsync(apiEndpoint, new StringContent(jsonDipendente, Encoding.UTF8, "application/json"));
                }
                catch(Exception ex)
                {
                    Response.Redirect("ErroreGenerico.aspx");
                }
                
            }
            Response.Redirect("HomePage.aspx");

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}