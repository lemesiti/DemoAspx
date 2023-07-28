using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoAspx
{
    public partial class DeleteDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnDelete_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiEndpoint = "https://localhost:44321/deleteDipendente?id=" + txtID.Text;
                    HttpResponseMessage response = await client.DeleteAsync(apiEndpoint);
                }
                catch (Exception ex)
                {
                    Response.Redirect("ErroreGenerico.aspx");
                }
                Response.Redirect("HomePage.aspx");
            }
        }
    }
}