using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            if (Convert.ToDateTime(dados["ser_datafim"]) < DateTime.Now)
            {
                ser_servicosDB.Delete(Convert.ToInt32(dados["ser_id"]));
            }
            Literal1.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<p class='origem'><b>Origem</b>: " + dados["ser_origem"] + "</p>"
                + "<p class='destino'><b>Destino</b>: " + dados["ser_destino"] + "<hr /></p>"
                + "<p><b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<p/><hr />"
                + "<p><b>Vagas: </b>" + dados["ser_lugares"] + "</p>"
                + "<button type='button' class='btn btn-default' style='float:right;' data-toggle='modal' data-target='#modalNext' onclick=''>Detalhes</button><br />"
            + "</div></div></div>";
        }
    }

    protected void btnGtHP_Click(object sender, EventArgs e)
    {
        Server.Transfer("index.aspx", true);
    }
}