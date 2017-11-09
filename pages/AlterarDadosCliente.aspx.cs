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
                //Sessão usu = (Sessão)Session["nome"];
                ////lblSessao.Text = usu.email;
                //hdf.Value = usu.id.ToString();
                CarregarVisualizar();
            }
        }
    }
    public void CarregarVisualizar()
    {
        hdf.Value = Session["value"].ToString();
        usu_usuario usu = new usu_usuario();
        pas_passageiro pas = new pas_passageiro();
        pes_pessoa pes = new pes_pessoa();

        DataSet ds = pas_passageiroDB.SelectDados(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["pes_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtCPF.Text = ds.Tables[0].Rows[0]["pas_cpf"].ToString();
            ddlSexo .SelectedItem.Text = ds.Tables[0].Rows[0]["pes_sexo"].ToString();
            ddlCidade.SelectedItem.Text = ds.Tables[0].Rows[0]["pes_cidade"].ToString();
            ddlEstado.SelectedItem.Text = ds.Tables[0].Rows[0]["pes_estado"].ToString();
            txtData.Text = ds.Tables[0].Rows[0]["pes_nascimento"].ToString();

        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        pas_passageiro cli = new pas_passageiro();
        cli.Pas_cpf = txtCPF.Text;

        pes_pessoa pes = new pes_pessoa();
        pes.Pes_id = Convert.ToInt32(hdf.Value);
        pes.Pes_nome = txtNome.Text;
        pes.Pes_sexo = ddlSexo.SelectedValue;
        pes.Pes_cidade = ddlCidade.SelectedValue;
        pes.Pes_estado = ddlEstado.SelectedValue;
        pes.Pes_nascimento = Convert.ToDateTime(txtData.Text);

        usu_usuario usu = new usu_usuario();
        usu.Usu_email = txtEmail.Text;

        switch (pes_pessoaDB.Update(pes))
        {
            case 0:
                //Response.Write("OK");
                Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                break;
            case -2:
                //Response.Write("ERRO");
                Response.Write("<script>alert('Ocorreu um Erro');</script>");
                break;
        }
        // switch (pas_passageiroDB.Update(cli))
        //{
        //    case 0:
        //        //Response.Write("OK");
        //        Label1.Text = "Dados Alterados com sucesso";
        //        break;
        //    case -2:
        //        //Response.Write("ERRO");
        //        Label1.Text = "Ocorreu um erro ao atualizar os dados, por favor confira os campos
        //            "e tente novamente";
        //        break;
        //}
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("DadosCliente.aspx");
    }
}