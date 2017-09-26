using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class pages_services : System.Web.UI.Page
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
            

            LiteralServices.Text += "<div class='serviceBox'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br />"
                + "<b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datafim"]) + "<br />"
                + "<b>Mensagem</b>:" + dados["ser_descricao"]
            + "</div></div>";
        }
    }
    protected void btnEditar_Click(object sender, EventArgs e)
    {
    }
    }