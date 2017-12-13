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
            LSolicitacao.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>"// + dados["pes_nome"]
                                       //+ "<span class='text-right'>" + dados["sol_id"] + "</span>" 
                 + "   <span class='text-right'><a href='#' data-toggle='modal' data-target='#meModal'><span class='glyphicon glyphicon-pencil'></span>&nbsp Proposta</a></span>" +
                 "</div>"
                + "<div class='padding'>"
                + "<p class='origem'><b>Origem</b>: " + dados["sol_origem"] + "</p>"
                + "<p class='destino'><b>Destino</b>: " + dados["sol_destino"] + "<br /><hr>"
                + "<p><b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datainicio"]) + "</p>"
                + "<p><b>Hora de Saida</b>:" + String.Format("{0:HH:mm}", dados["sol_datainicio"]) + "</p><hr>"
                + "<p><b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datafim"]) + "</p>"
                + "<p><b>Hora de Volta</b>:" + String.Format("{0:HH:mm}", dados["sol_datafim"]) + "</p><br />"
                + "<button type='button' class='btn btn-default' style='float:right;' data-target='#modalDetalhes' data-toggle='modal'>Detalhes</button>"
            + "</p></div></div></div>";
        }

    }
}