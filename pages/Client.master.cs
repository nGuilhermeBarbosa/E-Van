using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Client : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null || Session["perfil"] == null)
        {
            Response.Write("Erro");
        }
        else
        {
            string perfil = Convert.ToString(Session["perfil"]);

            if (perfil == "Cliente")
            {
                lblSessao.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Write("Er");
            }
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        Session.Remove("perfil");
        Response.Redirect("login.aspx");
    }
}
