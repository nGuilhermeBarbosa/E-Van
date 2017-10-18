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
        ServicesLoad();
    }
    DataSet ds = ser_servicosDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal1.Text += "<div class='serviceBox'> "
                + "<div class='title'><a href='" + dados["pes_nome"] + "'>"+ dados["pes_nome"] + "</a></div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["ser_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br /><hr />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br /><hr />"
                + "<b>Vagas: </b>" + dados["ser_lugares"] + "<br />"
                + "<button class='btn btn-default' style='float:right;'>Detalhes</button><br />"
            + "</div></div>";
        }
    }
}