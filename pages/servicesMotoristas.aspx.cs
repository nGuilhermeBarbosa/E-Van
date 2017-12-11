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
        ServicesLoad();
    }


    DataSet ds = ser_servicosDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            if (Convert.ToDateTime(dados["ser_datafim"]) < DateTime.Now)
            {
                ser_servicosDB.Delete(Convert.ToInt32(dados["ser_id"]));
            }
            LiteralServices.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<p class='origem'><b>Origem</b>: " + dados["ser_origem"] + "</p>"
                + "<p class='destino'><b>Destino</b>: " + dados["ser_destino"] + "</p><hr />"
                + "<p><b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br /><hr /></p>"
                + "<p><b>Vagas: </b>" + dados["ser_lugares"] + "<br /></p>"
                + "<button type='button' class='btn btn-default' style='float:right;'><a href = 'ServiceInfoMotorista.aspx?ser=" + dados["ser_id"] + "'>Detalhes</button></a><br />"
            + "</p></div></div></div>";
        }
    }
}