using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_TodosMotoristas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServicesLoad();
    }
    DataSet ds = mot_motoristaDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LiteralMotoristas.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<p class='destino title'>" + dados["pes_nome"] + "</p>"
                + "<div class='padding'>"
                + "<p><b>Sexo</b>: " + dados["pes_sexo"] + "</p>"
                + "<p><b>Cidade</b>:" + dados["pes_cidade"] + "</p>"
                + "<p><b>Contato</b>:" + dados["usu_email"] + "</p>"
                + "</p></div></div></div>";
        }
    }
}