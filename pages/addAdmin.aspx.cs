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
            
        }
    }

    protected void btnConfirmaCadastro_Click(object sender, EventArgs e)
    {


    //    if (txtSenhaA.Text == txtConfirmarSenha.Text)
    //    {
    //        //Insere o Usuario
    //        //string tipo = "Administrador";

    //        Adm_Administrador adm = new Adm_Administrador();
    //        adm.Adm_nome = txtNomeA.Text;
    //        adm.Adm_sexo = ddlSexoA.SelectedValue;
    //        usu_usuario us = new usu_usuario();
    //        us.Usu_email = txtEmailA.Text;
    //        us.Usu_senha = txtSenhaA.Text;
    //        us.Usu_tipo = "Administrador";
    //        adm.Adm_cidade = ddlCidadeA.SelectedValue;
    //        adm.Adm_estado = ddlEstadoA.SelectedValue;
    //        adm.Adm_nascimento = Convert.ToDateTime(txtDataNasc.Text);
    //        //adm.Adm_cpf = txtCpf.Text;


    //        usu_usuarioDB.Insert(us);
    //        ////joga o email pra uma variavel
    //        string email = txtEmailA.Text;
    //        ////cria um dataset, pois o SelectByEmail retorna um dataset
    //        DataSet id = new DataSet();


    //        id = usu_usuarioDB.SelectByEmail(email);


    //        us.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

    //        adm.Usu_id = us;

    //        switch (adm_administradorDB.Insert(adm))
    //        {
    //            case 0:
    //                lbl.Text = "Cadastrado com sucesso";

    //                lblCS.Visible = false;
    //                txtNomeA.Text = "";
    //                txtEmailA.Text = "";
    //                txtSenhaA.Text = "";

    //                break;
    //            case -2:
    //                lbl.Text = "Erro, verifique os campos acima e tente novamente";
    //                break;
    //        }
            
    //    }
    //    else
    //    {
    //        lblCS.Text = "As senhas devem ser identicas em ambos os campos!";
    //        lblCS.Visible = true;
    //    }
    }
}