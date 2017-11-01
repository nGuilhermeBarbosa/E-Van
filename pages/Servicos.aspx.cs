using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_Servicos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            ServicesLoad();
        }
    }

    DataSet ds = ser_servicosDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal1.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["ser_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br /><hr />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br /><hr />"
                + "<b>Vagas: </b>" + dados["ser_lugares"] + "<br />"
                + "<button type='button' class='btn btn-default' style='float:right;' data-toggle='modal' data-target='#modalNext' onclick=''>Detalhes</button><br />"
            + "</div></div>";
        }
    }

    protected void btnGtHP_Click(object sender, EventArgs e)
    {
        Server.Transfer("index.aspx", true);
    }
}