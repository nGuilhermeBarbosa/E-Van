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


        if (txtSenha.Text == txtConfirmarSenha.Text)
        {
            //Insere o Usuario
            //string tipo = "Administrador";

            Adm_Administrador adm = new Adm_Administrador();
            adm.Adm_nome = txtNome.Text;
            adm.Adm_sexo = ddlSexo.SelectedValue;
            usu_usuario us = new usu_usuario();
            us.Usu_email = txtEmail.Text;
            us.Usu_senha = txtSenha.Text;
            us.Usu_tipo = "Administrador";
            adm.Adm_cidade = ddlCidade.SelectedValue;
            adm.Adm_estado = ddlEstado.SelectedValue;
            //adm.Adm_cpf = txtCpf.Text;


            usu_usuarioDB.Insert(us);
            ////joga o email pra uma variavel
            string email = txtEmail.Text;

            ////cria um dataset, pois o SelectByEmail retorna um dataset
            DataSet id = new DataSet();


            id = usu_usuarioDB.SelectByEmail(email);


            us.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

            adm.Usu_id = us;

            switch (adm_administradorDB.Insert(adm))
            {
                case 0:
                    lbl.Text = "Cadastrado com sucesso";

                    lblCS.Visible = false;
                    txtNome.Text = "";
                    txtEmail.Text = "";
                    txtSenha.Text = "";

                    break;
                case -2:
                    lbl.Text = "Erro, verifique os campos acima e tente novamente";
                    break;
            }
            
        }
        else
        {
            lblCS.Text = "As senhas devem ser identicas em ambos os campos!";
            lblCS.Visible = true;
        }
    }
}