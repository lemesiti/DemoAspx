using System;
using System.Threading.Tasks;
using System.Net.Http;
using DemoAspx.Model;
using Newtonsoft.Json;
using System.Web.UI.WebControls;

namespace DemoAspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await LoadDipendentiAsync();
            }
        
        }

        private async Task LoadDipendentiAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiEndpoint = "https://localhost:44321/getAll";
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                if (response != null)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    DipendentiResponse dipendentiResponse = JsonConvert.DeserializeObject<DipendentiResponse>(jsonResponse);
                    gvEmployees.DataSource = dipendentiResponse.dipendenteList;
                    gvEmployees.DataBind();

                }
            }

        }



        protected void gvEmployees_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete_Dip")
            {

                string idSelected = Convert.ToInt32(e.CommandArgument).ToString();
                if (!string.IsNullOrEmpty(idSelected))
                {
                    Page.RegisterAsyncTask(new System.Web.UI.PageAsyncTask(() => DeleteAsync(idSelected)));
                }
            }
            else if(e.CommandName == "Update_Dip")
            {
                string idSelected = Convert.ToInt32(e.CommandArgument).ToString();
                Response.Redirect("UpdateDipendente.aspx?id=" + idSelected);
            }
        }


        private async Task DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiEndpoint = "https://localhost:44321/deleteDipendente?id=" + id;
                HttpResponseMessage response = await client.DeleteAsync(apiEndpoint);

                if(response != null)
                {
                    await LoadDipendentiAsync();
                }
            }
        }


        /*
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;

            if (!string.IsNullOrEmpty(name))

            {

                lblMessage.Text = "Welcome, " + name + "!";

            }

            else

            {

                lblMessage.Text = "Please enter your name.";

            }
        */




    }

}

