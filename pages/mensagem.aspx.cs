using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_mensagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarLiteral();
    }

    DataSet ds = fal_faleconoscoDB.SelectAll();

    public void CarregarLiteral()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            msg.Text += "<div class='serviceBox'> "
                + "<div class='title'>" + dados["fal_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>E-mail</b>: " + dados["fal_email"] + "<br />"
                + "<b>Mensagem</b>: " + dados["fal_mensagem"]
            + "</div></div>";
        }
    }


    protected void limpar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
    }


    protected void btnConfirmaExclusao_Click(object sender, EventArgs e)
    {
        fal_faleconoscoDB.Limpar();
        Response.Redirect("mensagem.aspx", true);
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("mensagem.aspx", true);
    }

    protected void btnAnswer_Click(object sender, EventArgs e)
    {

    }

    protected void btnTest_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalAnswer();", true);
    }
}