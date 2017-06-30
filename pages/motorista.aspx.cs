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
        if (!IsPostBack)
        {
            CarregarVisualizar();
        }
    }
    public void CarregarVisualizar()
    {
        mot_motorista mot = new mot_motorista();

        DataSet ds = mot_motoristaDB.Select(mot);

        if (ds.Tables[0].Rows.Count == 1)
        {
            txtNome.Text = ds.Tables[0].Rows[0]["mot_nome"].ToString();
            txtCNPJ.Text = ds.Tables[0].Rows[0]["mot_cnpj"].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0]["mot_cidade"].ToString();
            txtEstado.Text = ds.Tables[0].Rows[0]["mot_estado"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
        }
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AlterarDadosMotorista.aspx");
    }
}