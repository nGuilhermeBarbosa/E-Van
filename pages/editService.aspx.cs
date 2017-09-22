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
                Sessão usu = (Sessão)Session["nome"];
                //lblSessao.Text = usu.email;
                hdf.Value = usu.id.ToString();
                CarregarVisualizar();
            }
        }
    }

    public void CarregarVisualizar()
    {
        ser_servicos usu = new ser_servicos();

        DataSet ds = ser_servicosDB.SelectDados(Convert.ToInt32(Context.Items["value"]));
        Label1.Text = Context.Items["value"].ToString();

        if (ds.Tables[0].Rows.Count == 1)
        {
            Label1.Text = ds.Tables[0].Rows[0]["mot_id"].ToString();
            txtOrigem.Text = ds.Tables[0].Rows[0]["ser_origem"].ToString();
            txtDestino.Text = ds.Tables[0].Rows[0]["ser_destino"].ToString();
            txtDataInicio.Text = ds.Tables[0].Rows[0]["ser_datainicio"].ToString();
            txtDataFim.Text = ds.Tables[0].Rows[0]["ser_datafim"].ToString();
            txtLugares.Text = ds.Tables[0].Rows[0]["ser_lugares"].ToString();
            txtDescricao.Text = ds.Tables[0].Rows[0]["ser_descricao"].ToString();

        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        ser_servicos serv = new ser_servicos();
        serv.Ser_datacadastro = data;
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;
        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text);
        serv.Ser_lugares = Convert.ToInt32(txtLugares.Text);
        serv.Mot_id = mot;


        switch (ser_servicosDB.Update(serv))
        {
            case 0:
                lblMsg.Text = "Cadastrado com sucesso";
                break;
            case -2:
                lblMsg.Text = "ERRO";
                break;
        }
    }
}