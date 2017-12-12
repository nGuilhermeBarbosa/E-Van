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
                lbl.Text = usu.nome;
                //Context.Items["value"] = usu.id.ToString();
                hdf.Value = usu.id.ToString();
                //lbl.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Redirect("error.aspx");
            }
        }
        DateTime data = DateTime.Today;
        DateTime firstDay = new DateTime(data.Year, data.Month, 1);
        mot_motorista mot = new mot_motorista();
        if (data == firstDay)
        {
            int publicacoes = 0;
            mot.Mot_publicacoes = publicacoes;
            mot_motoristaDB.UpdatePublicacoes(mot);
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        //Response.Write("ERRO");
        Session.Remove("nome");
        Session.Remove("perfil");
        Session.Remove("value");
        Response.Redirect("index.aspx");
    }
}
