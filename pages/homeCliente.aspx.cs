using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null)
        {
            Server.Transfer("error.aspx", true);
            //lbl.Text = "ERRO";
        }

        ServicesLoad();
    }

    protected void btnShowAll_Click(object sender, EventArgs e)
    {
        
    }
    DataSet ds = ser_servicosDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LiteralServices.Text += "<div class='serviceBox'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["ser_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br /><hr />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br /><hr />"
                + "<b>Vagas: </b>" + dados["ser_lugares"] + "<br />"
                + "<button class='btn btn-default' type='button' style='float:right;'>Detalhes</button><br />"
            + "</div></div>";
        }
    }


}