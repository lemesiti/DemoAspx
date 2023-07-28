using DemoAspx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace DemoAspx
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnAggiungiDip(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            int eta = int.Parse(txtEta.Text);

            Dipendente dipendenteNew = new Dipendente();
            dipendenteNew.nome = nome;
            dipendenteNew.cognome = cognome;
            dipendenteNew.eta = eta;

            string jsonDipendente = Newtonsoft.Json.JsonConvert.SerializeObject(dipendenteNew);
            string apiEndpoint = "https://localhost:44321/createDipendente";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(apiEndpoint, new StringContent(jsonDipendente, Encoding.UTF8, "application/json"));
            }
            Response.Redirect("HomePage.aspx");

        }
    }
}