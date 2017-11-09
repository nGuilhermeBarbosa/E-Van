using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_motorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Sessão usu = (Sessão)Session["nome"];
            ////lblSessao.Text = usu.email;
            //hdf1.Value = usu.id.ToString();
            CarregarVisualizarM();
        }
    }
    public void CarregarVisualizarM()
    {
        hdf1.Value = Session["value"].ToString();
        usu_usuario usu = new usu_usuario();
        pes_pessoa pes = new pes_pessoa();
        mot_motorista mot = new mot_motorista();
        tpc_tipo_contato tpc = new tpc_tipo_contato();
        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();

        DataSet ds = mot_motoristaDB.SelectDados(Convert.ToInt32(hdf1.Value));
        hdfID.Value = ds.Tables[0].Rows[0]["pes_id"].ToString();
        txtNome.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
        txtCNPJ.Text = ds.Tables[0].Rows[0]["mot_cnpj"].ToString();
        txtSexo.Text = ds.Tables[0].Rows[0]["pes_sexo"].ToString();
        txtDataNascimento.Text = ds.Tables[0].Rows[0]["pes_nascimento"].ToString();
        txtCidade.Text = ds.Tables[0].Rows[0]["pes_cidade"].ToString();
        txtEstado.Text = ds.Tables[0].Rows[0]["pes_estado"].ToString();
        txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
        txtTipoTelefone.Text = ds.Tables[0].Rows[0]["tpc_descricao"].ToString();
        txtTelefone.Text = ds.Tables[0].Rows[0]["mxc_descricao"].ToString();

    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AlterarDadosMotorista.aspx");
    }
}