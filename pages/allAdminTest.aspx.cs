using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_allAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarddlAdmin();
            CarregarLiteral();
        }
        
    }

    DataSet ds = adm_administradorDB.SelectAll();

    public void CarregarLiteral()
    {
        foreach(DataRow dados in ds.Tables[0].Rows)
        {
            Literal1.Text += "<div class='serviceBox'> "
                + "<div class='title'>" + dados["adm_nome"] + "</div>"
                + "<div class='padding'>"
                + "<b>Sexo</b>: " + dados["adm_sexo"] + "<br />"
                + "<b>Estado</b>: " + dados["adm_estado"] + "<br />"
                + "<b>Cidade</b>:"+ dados["adm_cidade"]
            + "</div></div>";
        }
        
    }



    public void CarregarddlAdmin()
    {
        DataSet ds = adm_administradorDB.SelectAll();

        ddlAdmin.DataSource = ds;
        ddlAdmin.DataTextField = "adm_nome";
        ddlAdmin.DataValueField = "adm_id";
        ddlAdmin.DataBind();

        ddlAdmin.Items.Insert(0, "Selecione o Admin que deseja excluir");
    }

    protected void ddlAmdmin_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (adm_administradorDB.Delete(Convert.ToInt32(ddlAdmin.SelectedValue)))
        {
            case 0:
                CarregarddlAdmin();
                lbl2.Text = "Excluido com sucesso";
                break;
            case -2:
                lbl2.Text = "<<<   ERRO    >>>";
                break;

        }
        CarregarddlAdmin();
        Response.Redirect("allAdminTest.aspx", true);
    }
}