using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_homeMotorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                Sessão usu = (Sessão)Session["nome"];
                //lblSessao.Text = usu.email;
                hdf.Value = usu.id.ToString();
                CampoVazio();
            }
        }
        ServicesLoad();
    }
    public void CampoVazio()
    {

        DataSet ds = mxc_motorista_tipo_contatoDB.SelectAll(Convert.ToInt32(hdf.Value));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 0)
        {
            //lbl.Text = Convert.ToString(cont);
            lbl.Text = "<div class=popup>Para a utilização completa do sistema complete o seu cadastro <a href=CompletaCadastro.aspx>Aqui</a> </div>";
        } 
    }

    DataSet ds = ser_servicosDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LiteralServices.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["ser_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br /><hr />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br /><hr />"
                + "<b>Vagas: </b>" + dados["ser_lugares"] + "<br />"
                + "<a href = 'ServiceInfoMotorista.aspx?ser=" + dados["ser_id"] + "'><button class='btn btn-default' type='button' style='float:right;'>Detalhes</button></a><br />"
            + "</div></div>";
        }
    }
}