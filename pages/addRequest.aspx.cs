using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_addRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Sessão usu = (Sessão)Session["nome"];
        ////lblSessao.Text = usu.email;
        //hdf.Value = usu.id.ToString();
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        hdf.Value = Session["value"].ToString();
        sol_solicitacao sol = new sol_solicitacao();
        sol.Sol_origem = txtOrigem.Text;
        sol.Sol_destino = txtDestino.Text;
        sol.Sol_datainicio = Convert.ToDateTime(txtDataInicio.Text);
        sol.Sol_datainicio = Convert.ToDateTime(txtHoraInicio.Text);
        sol.Sol_datafim = Convert.ToDateTime(txtDataFim.Text);
        sol.Sol_datafim = Convert.ToDateTime(txtHoraFim.Text);
        sol.Sol_qtdpessoas = Convert.ToInt32(txtPessoas.Text);
        if (cbl.Checked == true)
        {
            sol.Sol_private = true;
        }
        else
        {
            sol.Sol_private = false;
        }
        sol.Sol_descricao = txtMensagem.Text;
        pas_passageiro pas = new pas_passageiro();

        DataSet id = new DataSet();

        id = usu_usuarioDB.Select(Convert.ToInt32(hdf.Value));

        pas.Pas_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

        sol.Pas_id = pas;

        switch (sol_solicitacaoDB.Insert(sol))
        {
            case 0:
                //Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSS();", true);
                txtDestino.Text = null;
                txtMensagem.Text = null;
                txtDataInicio.Text = null;
                txtDataFim.Text = null;
                txtOrigem.Text = null;
                txtPessoas.Text = null;
                break;
            case -2:
                //Response.Write("<script>alert('Erro, verifique os campos acima e tente novamente');</script>");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSE();", true);
                break;
        }
        
    }
}