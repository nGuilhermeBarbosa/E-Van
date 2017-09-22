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
                Carregarddls();
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
                + "<div class='title'>" + dados["pes_nome"]
                + "<span class='text-right'>" + dados["ser_id"] + "</span></div>"
                + "<div class='padding'>"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br />"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}",dados["ser_datainicio"]) + "<br />"
                + "<b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datafim"]) + "<br />"
                + "<b>Mensagem</b>:" + dados["ser_descricao"]
            + "</div></div>";
        }

    }

    public void Carregarddls()
    {
        DataSet ds = ser_servicosDB.SelectAll();

        ddlDelete.DataSource = ds;
        ddlDelete.DataTextField = "ser_id";
        ddlDelete.DataValueField = "ser_id";
        ddlDelete.DataBind();

        ddlDelete.Items.Insert(0, "Selecione o número do serviço");

        ddlEdit.DataSource = ds;
        ddlEdit.DataTextField = "ser_id";
        ddlEdit.DataValueField = "ser_id";
        ddlEdit.DataBind();

        ddlEdit.Items.Insert(0, "Selecione o número do serviço");
    }

    protected void ddlEdit_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(ddlEdit.SelectedValue);
        Context.Items["value"] = id;
        Response.Redirect("editService.aspx");
    }

    protected void ddlDelete_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}