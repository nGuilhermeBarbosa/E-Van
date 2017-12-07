using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_Profilecliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PerfilLoad();
    }

    DataSet ds = pas_passageiroDB.SelectAll();

    public void PerfilLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LiteralPerfilPassageiro.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Sexo</b>: " + dados["pes_sexo"] + "<br />"
                + "<b>Cidade</b>:" + dados["pes_cidade"] + "<br />"
                + "<b>Contato</b>:" + dados["usu_email"] + "<br />"
                + "</div></div>";
        }
    }

}