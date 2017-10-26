using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_SolicitaçõesServiçosMotorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarLiteral();
    }

    public void CarregarLiteral()
    {
        DataSet ds = sol_solicitacaoDB.SelectAll();

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LSolicitacao.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>"// + dados["pes_nome"]
                //+ "<span class='text-right'>" + dados["sol_id"] + "</span>" 
                 + "   <span class='text-right'><a href='#' data-toggle='modal' data-target='#meModal'><span class='glyphicon glyphicon-pencil'></span>&nbsp Proposta</a></span>" +
                 "</div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["sol_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["sol_destino"] + "<br /><hr>"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datainicio"]) + "<br />"
                + "<b>Hora de Saida</b>:" + String.Format("{0:HH:mm}", dados["sol_datainicio"]) + "<br /><hr>"
                + "<b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datafim"]) + "<br />"
                + "<b>Hora de Volta</b>:" + String.Format("{0:HH:mm}", dados["sol_datafim"]) + "<br /><br />"
                + "<button type='button' class='btn btn-default' style='float:right;'>Detalhes</button><br />"
            + "</div></div>";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}