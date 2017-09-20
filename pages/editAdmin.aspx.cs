using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_addAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CarregarVisualizar();
        }
    }

    public void CarregarVisualizar()
    {
        usu_usuario usu = new usu_usuario();
        pes_pessoa pes = new pes_pessoa();
        pas_passageiro pas = new pas_passageiro();

        DataSet ds = pes_pessoaDB.SelectDados(Convert.ToInt32(Context.Items["value"]));
        Label1.Text = Context.Items["value"].ToString();

        if (ds.Tables[0].Rows.Count == 1)
        {
            Label1.Text = ds.Tables[0].Rows[0]["pes_id"].ToString();
            txtNomeA.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
            ddlSexoA.SelectedValue = ds.Tables[0].Rows[0]["pes_sexo"].ToString();
            txtEmailA.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtDataNasc.Text = ds.Tables[0].Rows[0]["pes_nascimento"].ToString();
            ddlEstadoA.SelectedValue = ds.Tables[0].Rows[0]["pes_estado"].ToString();
            ddlCidadeA.SelectedValue = ds.Tables[0].Rows[0]["pes_cidade"].ToString();
            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (txtSenhaA.Text == txtConfirmarSenha.Text)
        {
            pes_pessoa pes = new pes_pessoa();
            pes.Pes_id = Convert.ToInt32(Label1.Text);
            pes.Pes_nome = txtNomeA.Text;
            pes.Pes_sexo = ddlSexoA.SelectedValue;
            pes.Pes_cidade = ddlCidadeA.SelectedValue;
            pes.Pes_estado = ddlEstadoA.SelectedValue;
            pes.Pes_nascimento = Convert.ToDateTime(txtDataNasc.Text);

            pes_pessoaDB.Update(pes);

            usu_usuario us = new usu_usuario();
            us.Usu_id = Convert.ToInt32(Label1.Text);
            us.Usu_email = txtEmailA.Text;
            us.Usu_senha = txtSenhaA.Text;
            us.Usu_tipo = "Administrador";

            string n = txtNomeA.Text;
            DataSet id = new DataSet();

            id = pes_pessoaDB.SelectByEmail(n);

            pes.Pes_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);
            us.Pes_id = pes;

            usu_usuarioDB.Update(us);

        }
        else
        {
            lblCS.Text = "As senhas devem ser identicas em ambos os campos!";
            lblCS.Visible = true;
        }
    }
}