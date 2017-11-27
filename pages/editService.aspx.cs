using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_CadastroServiço : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                if (Request.QueryString["ser"] != null)
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["ser"].ToString()))
                    {
                        CarregarVisualizar(Request.QueryString["ser"].ToString());
                        CarregarDDL();
                        CarregarDDLT();
                    }
                    else Response.Redirect("TodosServicosMotorista.aspx");
                }
                else
                    Response.Redirect("TodosServicosMotorista.aspx");

                //CarregarVisualizar();
            }
        }
    }

    public void CarregarVisualizar(string par)
    {
        ser_servicos usu = new ser_servicos();
        con_condutor con = new con_condutor();

        DataSet data = ser_servicosDB.SelectCon(Convert.ToInt32(par));

        Label1.Text = par;
        int qtd = data.Tables[0].Rows.Count;
        if (qtd != 0)
        {
            DataSet ds = ser_servicosDB.SelectDados(Convert.ToInt32(par));
            if (ds.Tables[0].Rows.Count == 1)
            {
                Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
                txtOrigem.Text = ds.Tables[0].Rows[0]["ser_origem"].ToString();
                txtDestino.Text = ds.Tables[0].Rows[0]["ser_destino"].ToString();
                txtDataInicio.Text = ds.Tables[0].Rows[0]["ser_datainicio"].ToString();
                txtDataFim.Text = ds.Tables[0].Rows[0]["ser_datafim"].ToString();
                txtLugares.Text = ds.Tables[0].Rows[0]["ser_lugares"].ToString();
                txtDescricao.Text = ds.Tables[0].Rows[0]["ser_descricao"].ToString();
                ddlCondutor.SelectedValue = ds.Tables[0].Rows[0]["con_id"].ToString();
                ddlTransporte.SelectedValue = ds.Tables[0].Rows[0]["tra_id"].ToString();
                Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
                Label4.Text = ds.Tables[0].Rows[0]["con_id"].ToString();
            }
        }
        else
        {
            DataSet ds = ser_servicosDB.SelectDadosCon(Convert.ToInt32(par));
            if (ds.Tables[0].Rows.Count == 1)
            {
                Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
                txtOrigem.Text = ds.Tables[0].Rows[0]["ser_origem"].ToString();
                txtDestino.Text = ds.Tables[0].Rows[0]["ser_destino"].ToString();
                txtDataInicio.Text = ds.Tables[0].Rows[0]["ser_datainicio"].ToString();
                txtDataFim.Text = ds.Tables[0].Rows[0]["ser_datafim"].ToString();
                txtLugares.Text = ds.Tables[0].Rows[0]["ser_lugares"].ToString();
                txtDescricao.Text = ds.Tables[0].Rows[0]["ser_descricao"].ToString();
                //ddlCondutor.SelectedValue = ds.Tables[0].Rows[0]["con_id"].ToString();
                ddlTransporte.SelectedValue = ds.Tables[0].Rows[0]["tra_id"].ToString();
                Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
            }
        }
    }
    public void CarregarDDL()
    {
        DataSet ds = con_condutorDB.SelectAll();
        ddlCondutor.DataSource = ds;
        ddlCondutor.DataTextField = "con_nome";
        ddlCondutor.DataValueField = "con_id";
        ddlCondutor.DataBind();
        ddlCondutor.Items.Insert(0, "Selecione");
    }
    public void CarregarDDLT()
    {
        DataSet ds = tra_transporteDB.SelectAll();
        ddlTransporte.DataSource = ds;
        ddlTransporte.DataTextField = "tra_modelo";
        ddlTransporte.DataValueField = "tra_id";
        ddlTransporte.DataBind();
        ddlTransporte.Items.Insert(0, "Selecione");
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        ser_servicos serv = new ser_servicos();
        tra_transporte tra = new tra_transporte();
        con_condutor con = new con_condutor();
        sco_servicoscondutor sco = new sco_servicoscondutor();

        tra.Tra_id = Convert.ToInt32(ddlTransporte.SelectedValue);
        serv.Tra_id = tra;
        //serv.Ser_datacadastro = data;
        serv.Ser_id = Convert.ToInt32(Label1.Text);
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;
        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text + " " + txtHoraRetorno.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text + " " + txtHoraPartida.Text);
        serv.Ser_lugares = Convert.ToInt32(txtLugares.Text);

        //serv.Mot_id = mot;
        switch (ser_servicosDB.Update(serv))
        {
            case 0:
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSS();", true);
                //lblMsg.Text = "Cadastrado com sucesso";
                break;
            case -2:
                //lblMsg.Text = "ERRO";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSE();", true);
                break;
        }


        DataSet id = new DataSet();

        if (ddlCondutor.SelectedIndex != 0)
        {
            con.Con_id = Convert.ToInt32(ddlCondutor.SelectedValue);

            id = sco_servicoscondutorDB.SelectID(Convert.ToInt32(Label4.Text), Convert.ToInt32(Label1.Text));

            sco.Sco_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

            sco.Con_id = con;
            sco.Ser_id = serv;
            sco_servicoscondutorDB.Update(sco);
        }
    }
}