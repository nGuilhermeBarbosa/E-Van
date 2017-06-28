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
        if (!IsPostBack)
        {
            CarregarGrid();
        }
    }
    private void CarregarGrid()
    {
        DataSet ds = adm_administradorDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0)
        {
            gridAdmin.DataSource = ds.Tables[0].DefaultView;
            gridAdmin.DataBind();
            //--------------------------
            gridAdmin.Visible = true;
            //lbl.Text = "Foram emcontrados " + qtd + " de regisros!";
        }
        else
        {
            gridAdmin.Visible = false;
            //lbl.Text = "Não foram encotrado registros...";
        }
    }
    protected void btnCancelaCadastro_Click(object sender, EventArgs e)
    {

    }
    protected void btnConfirmaCadastro_Click(object sender, EventArgs e)
    {
        Adm_Administrador adm = new Adm_Administrador();
        usu_usuario usu = new usu_usuario();

        usu.Usu_email = txtEmail.Text;
        usu.Usu_senha = txtSenha.Text;


        adm.Adm_nome = txtNome.Text;
        adm.Adm_telefone = Convert.ToInt32(txtTelAdm.Text);
        adm.Adm_sexo = ddlAddAdmin.SelectedValue;
        adm.Adm_nascimento = dataNasc.Text;
        adm.Adm_cidade = ddlCidade.SelectedValue;
        adm.Adm_estado = ddlEstado.SelectedValue;
        adm.Adm_cpf = txtCpf.Text;
        string email = txtEmail.Text;

        DataSet codigo = new DataSet();

        codigo = usu_usuarioDB.SelectByEmail(email);

        usu.Usu_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        adm.Usu_id = usu;

        usu_usuarioDB.Insert(usu);        

        adm.Usu_id = usu;

        switch (adm_administradorDB.Insert(adm))
        {
            case 0:
                lblTeste.Text = "<<<   OK  >>>";
                break;
            case -2:
                lblTeste.Text = "<<<  ERRO  >>";
                break;
        }

        CarregarGrid();

        txtNome.Text = "";
        txtTelAdm.Text = "";
        txtEmail.Text = "";
        txtSenha.Text = "";
        txtConfirmarSenha.Text = "";
        txtCpf.Text = "";
        dataNasc.Text = "";       
    }
}