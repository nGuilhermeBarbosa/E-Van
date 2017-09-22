using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_servicesMotoristas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ServicesLoad();
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
                + "<b>Cidade</b>:" + dados["pes_cidade"] + "<br />"
                + "<b>Saída</b>:" + dados["ser_cidade"] + "<br />"
                + "<p>" + String.Format("{0:dd/MM/yyyy}",dados["ser_datainicio"]) + "</p>"
            + "</div></div>";
        }
    }
}