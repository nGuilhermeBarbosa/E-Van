using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_TodosMotoristasCliente : System.Web.UI.Page
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
            LiteralMotoristas.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Sexo</b>: " + dados["pes_sexo"] + "<br />"
                + "<b>Cidade</b>:" + dados["pes_cidade"] + "<br />"
                + "<b>Contato</b>:" + dados["usu_email"] + "<br />"
                + "</div></div>";
        }
    }
}