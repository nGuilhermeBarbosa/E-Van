using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_PropostaCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["pas"] != null)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["pas"].ToString()))
            {
                CarregarVisualizar(Request.QueryString["pas"].ToString());
            }
        }
    }
    public void CarregarVisualizar(string par)
    {

        sol_solicitacao usu = new sol_solicitacao();

        DataSet ds = som_solicitacaomotoristaDB.Select(Convert.ToInt32(par));
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
            txtNomeM.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
            txtProposta.Text = ds.Tables[0].Rows[0]["som_proposta"].ToString();
            txtTContato.Text = ds.Tables[0].Rows[0]["tpc_descricao"].ToString();
            txtContato.Text = ds.Tables[0].Rows[0]["mxc_descricao"].ToString();

            //Label1.Text = ds.Tables[0].Rows[0]["pes_id"].ToString();

        }
    }
}