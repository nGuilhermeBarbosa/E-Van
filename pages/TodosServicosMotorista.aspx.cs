using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services;

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
                CadastroCompleto();
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
            Literal1.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"]
                //+ "<span class='text-right'>" + dados["ser_id"] + "</span>" 
                + "<span class='text-right'><a href='#' onclick='excluir("+ dados["ser_id"] + ", \""+ dados["pes_nome"] + "\");'><span class='glyphicon glyphicon-remove'></span>&nbsp Excluir</a></span>"
                 + "   <span class='text-right'><a href = 'editService.aspx?ser=" + dados["ser_id"] + "' ><span class='glyphicon glyphicon-edit'></span>&nbsp Editar</a></span></div>"
                + "<div class='padding'>"
                + "<b>Origem</b>: " + dados["ser_origem"] + "<br />"
                + "<b>Destino</b>: " + dados["ser_destino"] + "<br /><hr>"
                + "<b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "<br />"
                + "<b>Hora de Saida</b>:" + String.Format("{0:HH:mm}", dados["ser_datainicio"]) + "<br /><hr>"
                + "<b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["ser_datafim"]) + "<br />"
                + "<b>Hora de Volta</b>:" + String.Format("{0:HH:mm}", dados["ser_datafim"]) + "<br /><hr>"
                + "<b>Mensagem</b>:" + dados["ser_descricao"]
            + "</div></div>";
        }

    }
    

    [WebMethod]
    public static string Excluir(string par)
    {
        return par;
    }



    public void Carregarddls()
    {
        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = ser_servicosDB.SelectSer(c);

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
        Server.Transfer("editService.aspx", true);
    }

    protected void ddlDelete_SelectedIndexChanged(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        switch (ser_servicosDB.Delete(Convert.ToInt32(ddlDelete.SelectedValue)))
        {
            case 0:
                Carregarddls();
                //lbl2.Text = "Excluido com sucesso";
                break;
            case -2:
                //lbl2.Text = "<<<   ERRO    >>>";
                break;

        }
        Carregarddls();
        Response.Redirect("TodosServicosMotorista.aspx", true);
    }

    public void CadastroCompleto()
    {
        DataSet ds = mxc_motorista_tipo_contatoDB.SelectAll(Convert.ToInt32(hdf.Value));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 0)
        {
            //lbl.Text = Convert.ToString(cont);
            Response.Redirect("Erro.aspx");
        }
    }
}
