using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null || Session["perfil"] == null)
        {
            Response.Redirect("error.aspx");
        }
        else
        {
            string perfil = Convert.ToString(Session["perfil"]);

            if (perfil == "Cliente")
            {
                lblAdmin.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Redirect("error.aspx");
            }

        }
    }
}
