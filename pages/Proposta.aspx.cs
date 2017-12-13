using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Proposta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["sol"] != null)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["sol"].ToString()))
            {
                CarregarVisualizar(Request.QueryString["sol"].ToString());
            }
        }
    }

    public void CarregarVisualizar(string par)
    {

        sol_solicitacao usu = new sol_solicitacao();

        DataSet ds = sol_solicitacaoDB.SelectDados(Convert.ToInt32(par));
        Label1.Text = par;

        if (ds.Tables[0].Rows.Count == 1)
        {
            //Label1.Text = ds.Tables[0].Rows[0]["ser_id"].ToString();
            txtOrigem.Text = ds.Tables[0].Rows[0]["sol_origem"].ToString();
            txtDestino.Text = ds.Tables[0].Rows[0]["sol_destino"].ToString();
            txtDataInicio.Text = String.Format("{0:dd/MM/yyyy}", ds.Tables[0].Rows[0]["sol_datainicio"].ToString());
            txtDataFim.Text = String.Format("{0:dd/MM/yyyy}", ds.Tables[0].Rows[0]["sol_datafim"].ToString());
            //txtHoraInicio.Text = String.Format("{0:HH:MM}", ds.Tables[0].Rows[0]["sol_datainicio"].ToString());
            //txtHoraFim.Text = String.Format("{0:HH:MM}", ds.Tables[0].Rows[0]["sol_datafim"].ToString());
            txtPessoas.Text = ds.Tables[0].Rows[0]["sol_qtdpessoas"].ToString();
            txtMensagem.Text = ds.Tables[0].Rows[0]["sol_descricao"].ToString();
            //Label1.Text = ds.Tables[0].Rows[0]["pes_id"].ToString();

        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        hdf.Value = Session["value"].ToString();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        sol_solicitacao sol = new sol_solicitacao();

        sol.Sol_id = Convert.ToInt32(Label1.Text);

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = c;

        som_solicitacaomotorista som = new som_solicitacaomotorista();
        som.Sol_id = sol;
        som.Mot_id = mot;
        som.Som_proposta = Convert.ToDouble(txtProposta.Text);
        switch (som_solicitacaomotoristaDB.Insert(som))
        {
            case 0:
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                txtProposta.Text = null;
                break;
            case -2:
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalE();", true);
                break;
        }
    }
}