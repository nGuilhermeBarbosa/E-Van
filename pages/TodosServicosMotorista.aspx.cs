using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_Default : System.Web.UI.Page
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
                CarregarLiteral();
            }
        }
    }

    public void CarregarLiteral()
    {
        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = ser_servicosDB.SelectServicos(c);

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal1.Text += "<div class='serviceBox'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br />"
                + "<b>Data De Saida</b>:" + dados["ser_datainicio"] + "<br />"
                + "<b>Data De Volta</b>:" + dados["ser_datafim"]
            + "</div></div>";
        }

    }
}