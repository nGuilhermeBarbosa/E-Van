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
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                CarregarLiteral();
                //CarregarVisualizar();
            }
        }
    }

    public void CarregarLiteral()
    {
        DataSet ds = sol_solicitacaoDB.Select();

        foreach (DataRow dados in ds.Tables[0].Rows)
        {

            LSolicitacao.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"]
                 //+ "   <span class='text-right'><a href='#?sol=" + dados["sol_id"] + "' data-toggle='modal' data-target='#meModal'><span class='glyphicon glyphicon-pencil'></span>&nbsp Proposta</a><span> </ div >" +
                 +"</div>"
                + "<div class='padding'>"
                + "<p class='origem'><b>Origem</b>: " + dados["sol_origem"] + "</p>"
                + "<p class='destino'><b>Destino</b>: " + dados["sol_destino"] + "<br /><hr>"
                + "<p><b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datainicio"]) + "</p>"
                + "<p><b>Hora de Saida</b>:" + String.Format("{0:HH:mm}", dados["sol_datainicio"]) + "</p><hr>"
                + "<p><b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datafim"]) + "</p>"
                + "<p><b>Hora de Volta</b>:" + String.Format("{0:HH:mm}", dados["sol_datafim"]) + "</p><br />"
                + "<button type='button' class='btn btn-default' style='float:right;'><a href = 'Proposta.aspx?sol=" + dados["sol_id"] + "'>Detalhes</button></a></button>"
            + "</p></div></div></div>";
            //hdf1.Value = ""+dados["sol_id"];
        }


    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

        hdf.Value = Session["value"].ToString();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        sol_solicitacao sol = new sol_solicitacao();

        sol.Sol_id = Convert.ToInt32(hdf1.Value);

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = c;

        som_solicitacaomotorista som = new som_solicitacaomotorista();
        som.Sol_id = sol;
        som.Mot_id = mot;
        som.Som_proposta = Convert.ToDouble(txtProposta.Text);
        som_solicitacaomotoristaDB.Insert(som);
    }

}