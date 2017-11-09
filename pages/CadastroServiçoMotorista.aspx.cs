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
                CarregarDDL();
            }
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        int a = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = mot_motoristaDB.SelectCon(a);

        int qtd = ds.Tables[0].Rows.Count;

        ser_servicos serv = new ser_servicos();
        con_condutor con = new con_condutor();

        serv.Ser_datacadastro = data;
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;
        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text + " " + txtHoraRetorno.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text + " " + txtHoraPartida.Text);
        serv.Ser_lugares = Convert.ToInt32(txtLugares.Text);
        serv.Mot_id = mot;
        switch (ser_servicosDB.Insert(serv))
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
        
        string descricao = txtDescricao.Text;

        DataSet id = new DataSet();

        id = ser_servicosDB.SelectID(descricao);

        serv.Ser_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

        sco_servicoscondutor sco = new sco_servicoscondutor();
        if (qtd!=0)
        {
            con.Con_id = Convert.ToInt32(ddlCondutor.SelectedValue);
            sco.Con_id = con;
            sco.Ser_id = serv;
        }





        txtOrigem.Text = "";
        txtDestino.Text = "";
        txtDataFim.Text = "";
        txtDescricao.Text = "";
        txtDataInicio.Text = "";
        txtLugares.Text = "";
        txtHoraPartida.Text = "";
        txtHoraRetorno.Text = "";
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

}