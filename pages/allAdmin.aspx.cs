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
            CarregarGrid();
        }
        
    }

    DataSet ds = adm_administradorDB.SelectAll();

    private void CarregarGrid()
    {
        DataSet ds = adm_administradorDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0)
        {
            gridAdmin.DataSource = ds.Tables[0].DefaultView;
            gridAdmin.DataBind();
            gridAdmin.Visible = true;
            lbl.Text = "Foram encontrados " + qtd + " de registros!";
        }
        else
        {
            gridAdmin.Visible = false;
            lbl.Text = "Não foram encontrados registros...";
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
        CarregarGrid();
        CarregarddlAdmin();
    }
}