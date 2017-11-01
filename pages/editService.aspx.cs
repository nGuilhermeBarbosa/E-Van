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

        DataSet ds = ser_servicosDB.SelectDados(Convert.ToInt32(par));
        Label1.Text = par;

        if (ds.Tables[0].Rows.Count == 1)
        {
            Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
            txtOrigem.Text = ds.Tables[0].Rows[0]["ser_origem"].ToString();
            txtDestino.Text = ds.Tables[0].Rows[0]["ser_destino"].ToString();
            txtDataInicio.Text = ds.Tables[0].Rows[0]["ser_datainicio"].ToString();
            txtDataFim.Text = ds.Tables[0].Rows[0]["ser_datafim"].ToString();
            txtLugares.Text = ds.Tables[0].Rows[0]["ser_lugares"].ToString();
            txtDescricao.Text = ds.Tables[0].Rows[0]["ser_descricao"].ToString();
            Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();

        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;

        ser_servicos serv = new ser_servicos();
        serv.Ser_id = Convert.ToInt32(Label1.Text);
        serv.Ser_datacadastro = data;
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;
        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text);
        serv.Ser_lugares = Convert.ToInt32(txtLugares.Text);


        switch (ser_servicosDB.Update(serv))
        {
            case 0:
                //lblMsg.Text = "Atualizado com sucesso";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                break;
            case -2:
                //lblMsg.Text = "ERRO";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalE();", true);
                break;
        }
    }
}