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
        //O cadastro NÃO está funcionando
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        sol_solicitacao sol = new sol_solicitacao();
        sol.Sol_origem = txtCidadeO.Text;
        sol.Sol_destino = txtCidadeD.Text;
        sol.Sol_data = Data.Text;
        sol.Sol_qtdpessoas = Convert.ToInt32(TextBox1.Text);

        string email = txtNome.Text;

        usu_usuario usu = new usu_usuario();
        DataSet id = new DataSet();

        id = usu_usuarioDB.SelectByEmail(email);
        //sol.Cli_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);


        switch (sol_solicitacaoDB.Insert(sol))
        {
            case 0:
                Label1.Text = "Cadastrado com sucesso";
                txtCidadeD.Text = null;
                txtCidadeO.Text = null;
                Data.Text = null;
                TextBox1.Text = null;
                txtNome.Text = null;
                txtMensagem.Text = null;
                break;
            case -2:
                Label1.Text = "Erro, verifique os campos acima e tente novamente";
                break;
        }
    }
}