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

        ser_servicos serv = new ser_servicos();
        serv.Ser_datacadastro = data;
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;
        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text);
        serv.Ser_datafim = Convert.ToDateTime(txtHoraRetorno.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text);
        serv.Ser_datainicio = Convert.ToDateTime(txtHoraPartida.Text);
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

        txtOrigem.Text = "";
        txtDestino.Text = "";
        txtDataFim.Text = "";
        txtDescricao.Text = "";
        txtDataInicio.Text = "";
        txtLugares.Text = "";
        txtHoraPartida.Text = "";
        txtHoraRetorno.Text = "";
    }
}