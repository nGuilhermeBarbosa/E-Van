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
        pes_pessoa pes = new pes_pessoa();
        pas_passageiro pas = new pas_passageiro();

        DataSet ds = pas_passageiroDB.SelectDados(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["pes_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtCpf.Text = ds.Tables[0].Rows[0]["pas_cpf"].ToString();
            txtSexo.Text = ds.Tables[0].Rows[0]["pes_sexo"].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0]["pes_cidade"].ToString();
            txtEstado.Text = ds.Tables[0].Rows[0]["pes_estado"].ToString();
            txtDataNascimento.Text = ds.Tables[0].Rows[0]["pes_nascimento"].ToString();

        }
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AlterarDadosCliente.aspx");
    }
}