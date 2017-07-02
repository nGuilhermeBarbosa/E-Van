using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Driver : System.Web.UI.MasterPage
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

            if (perfil == "Motorista")
            {
                Sessão usu = (Sessão)Session["nome"];
                lbl.Text = usu.email;
                //hdf.Value = usu.id.ToString();
                //lbl.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Redirect("Erro.aspx");
            }
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        Session.Remove("perfil");
        Response.Redirect("login.aspx");
    }
}
