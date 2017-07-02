using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_AlterarDadosCliente : System.Web.UI.Page
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
        usu_usuario usu = new usu_usuario();


        DataSet ds = cli_clienteDB.SelectDados(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["cli_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["cli_nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtCPF.Text = ds.Tables[0].Rows[0]["cli_cpf"].ToString();
            ddlSexo .SelectedItem.Text = ds.Tables[0].Rows[0]["cli_sexo"].ToString();
            ddlCidade.SelectedItem.Text = ds.Tables[0].Rows[0]["cli_cidade"].ToString();
            ddlEstado.SelectedItem.Text = ds.Tables[0].Rows[0]["cli_estado"].ToString();
            txtData.Text = ds.Tables[0].Rows[0]["cli_datanascimento"].ToString();

        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        cli_cliente cli = new cli_cliente();
        cli.Cli_id = Convert.ToInt32(hdf.Value);
        cli.Cli_nome = txtNome.Text;
        cli.Cli_sexo = ddlSexo.SelectedValue;
        cli.Cli_cidade = ddlCidade.SelectedValue;
        cli.Cli_estado = ddlEstado.SelectedValue;
        cli.Cli_cpf = txtCPF.Text;
        cli.Cli_datanascimento = Convert.ToDateTime(txtData.Text);

        switch (cli_clienteDB.Update(cli))
        {
            case 0:
                //Response.Write("OK");
                Label1.Text = "Dados Alterados com sucesso";
                break;
            case -2:
                //Response.Write("ERRO");
                Label1.Text = "Ocorreu um erro ao atualizar os dados, por favor confira os campos " +
                    "e tente novamente";
                break;
        }
    }
}