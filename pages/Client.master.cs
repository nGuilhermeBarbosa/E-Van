using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_Client : System.Web.UI.MasterPage
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

            if (perfil == "Passageiro")
            {
                Sessão usu = (Sessão)Session["nome"];
                lblSessao.Text = usu.nome;
                Context.Items["value"] = usu.id.ToString();
                CarregarLiteral();
                //hdf.Value = usu.id.ToString();
                //lblSessao.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Redirect("error.aspx");
            }
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        Session.Remove("perfil");
        Session.Remove("value");
        Response.Redirect("index.aspx");
    }

    public void CarregarLiteral()
    {
        hdf.Value = Session["value"].ToString();

        pas_passageiro pas = new pas_passageiro();

        DataSet codigo = new DataSet();

        codigo = pas_passageiroDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = som_solicitacaomotoristaDB.SelectProposta(c);
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd != 0)
        {
            DataSet data = sol_solicitacaoDB.Select(c);
            foreach (DataRow dados in data.Tables[0].Rows)
            {
                Literal.Text += "<li><a href='PropostaCliente.aspx?pas="+dados["pas_id"]+"'>O Motorista " + dados["pes_nome"] + " mandou uma proposta</a></li><br/>";
            }

        }
        else{
            Literal.Text += "<li><a href='#'>Sem Notificações</a></li>";
        }
    }

    protected void btnDesativar_Click(object sender, EventArgs e)
    {

    }
}
