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
                hdf.Value = Session["value"].ToString();
                mot_motorista mot = new mot_motorista();
                DataSet codigo = new DataSet();
                codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
                mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);
                int a = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);
                DataSet ds = mot_motoristaDB.SelectPETC(a);
                foreach (DataRow dados in ds.Tables[0].Rows)
                {
                    if (Convert.ToString(dados["tip_descricao"]) == "Free")
                    {
                        ExibirLimite();
                    }
                }

                DateTime data = DateTime.Today;
                DateTime firstDay = new DateTime(data.Year, data.Month, 1);

                if (data == firstDay)
                {
                    int publicacoes = 0;
                    mot.Mot_publicacoes = publicacoes;
                    mot_motoristaDB.UpdatePublicacoes(mot);
                }
                CarregarLiteral();
                CadastroCompleto();
            }
        }
    }

    public void CarregarLiteral()
    {
        hdf.Value = Session["value"].ToString();

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);
        int esCounter = 0;
        DataSet ds = ser_servicosDB.SelectServicos(c);
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            if (Convert.ToDateTime(dados["ser_datafim"]) < DateTime.Now)
            {
                ser_servicosDB.Delete(Convert.ToInt32(dados["ser_id"]));
                esCounter++;
            }
            else
            {
                Literal1.Text += "  <div class='list-item'><div class='serviceBox shadow'> "
                  + "<div class='title'>" + dados["pes_nome"]
                //+ "<span class='text-right'>" + dados["ser_id"] + "</span>" 
                + "<span class='text-right'><a href='#' onclick='excluir(" + dados["ser_id"] + ", \"" + dados["pes_nome"] + "\");'><span class='glyphicon glyphicon-remove'></span>&nbsp Excluir</a></span>"
                 + "<span class='text-right'><a href = 'editService.aspx?ser=" + dados["ser_id"] + "'><span class='glyphicon glyphicon-edit'></span>&nbsp Editar</a></span></div>"
                + "<div class='padding'>"
                + "<p class='origem'><b>Origem</b>: " + dados["ser_origem"] + "</p>"
                + "<p class='destino'><b>Destino</b>: " + dados["ser_destino"] + "</p><hr>"
                + "<p><b>Data De Saida</b>:<e class='saida'>" + String.Format("{0:dd/MM/yyyy}", dados["ser_datainicio"]) + "</e></p>"
                + "<p><b>Hora de Saida</b>:<e class='horasaida'>" + String.Format("{0:HH:mm}", dados["ser_datainicio"]) + "</e></p><hr>"
                + "<p><b>Data De Volta</b>:<e class='chegada'>" + String.Format("{0:dd/MM/yyyy}", dados["ser_datafim"]) + "</e></p>"
                + "<p><b>Hora de Volta</b>:<e class='horachegada'>" + String.Format("{0:HH:mm}", dados["ser_datafim"]) + "</e></p><hr>"
                + "<p><b>Mensagem</b>:" + dados["ser_descricao"]
            + "</p></div></div></div>";
            }

            if (esCounter > 0)
            {
                fbse.Text = "Serviços expirados: " + esCounter;
                fbse.Visible = true;
            }
            else
            {
                fbse.Visible = false;
            }

        }

    }


    [WebMethod]
    public static string Excluir(string par)
    {
        return par;
    }



    //public void Carregarddls(string par)
    //{
    //    mot_motorista mot = new mot_motorista();

    //    DataSet codigo = new DataSet();

    //    codigo = mot_motoristaDB.SelectID(Convert.ToInt32(par));

    //    int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

    //    DataSet ds = ser_servicosDB.SelectSer(c);

    //    ddlDelete.DataSource = ds;
    //    ddlDelete.DataTextField = "ser_id";
    //    ddlDelete.DataValueField = "ser_id";
    //    ddlDelete.DataBind();

    //    ddlDelete.Items.Insert(0, "Selecione o número do serviço");

    //    ddlEdit.DataSource = ds;
    //    ddlEdit.DataTextField = "ser_id";
    //    ddlEdit.DataValueField = "ser_id";
    //    ddlEdit.DataBind();

    //    ddlEdit.Items.Insert(0, "Selecione o número do serviço");
    //}

    protected void ddlEdit_SelectedIndexChanged(object sender, EventArgs e)
    {
        //int id = Convert.ToInt32(ddlEdit.SelectedValue);
        //Context.Items["value"] = id;
        //Server.Transfer("editService.aspx", true);
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
                //Carregarddls();
                //lbl2.Text = "Excluido com sucesso";
                break;
            case -2:
                //lbl2.Text = "<<<   ERRO    >>>";
                break;

        }
        //Carregarddls();
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

    protected void csm_Click(object sender, EventArgs e)
    {
        Server.Transfer("CadastroServiçoMotorista.aspx", true);
    }

    public void ExibirLimite()
    {
        hdf.Value = Session["value"].ToString();

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        int a = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = mot_motoristaDB.SelectPETC(a);

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            fbUnlimited.Visible = false;
            fbLimite.Text = "Publicações: " + dados["mot_publicacoes"] + "/5";
            fbLimite.Visible = true;
        }

    }
}
