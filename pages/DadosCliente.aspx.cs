using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_DadosCliente : System.Web.UI.Page
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


        DataSet ds = pas_passageiroDB.SelectDados(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["cli_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["cli_nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtCpf.Text = ds.Tables[0].Rows[0]["cli_cpf"].ToString();
            txtSexo.Text = ds.Tables[0].Rows[0]["cli_sexo"].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0]["cli_cidade"].ToString();
            txtEstado.Text = ds.Tables[0].Rows[0]["cli_estado"].ToString();
            txtDataNascimento.Text = ds.Tables[0].Rows[0]["cli_datanascimento"].ToString();

        }
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AlterarDadosCliente.aspx");
    }
}