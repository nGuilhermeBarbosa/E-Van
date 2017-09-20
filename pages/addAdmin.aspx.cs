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


        if (txtSenhaA.Text == txtConfirmarSenha.Text)
        {
            //Insere o Usuario
            //string tipo = "Administrador";

            pes_pessoa pes = new pes_pessoa();
            pes.Pes_nome = txtNomeA.Text;
            pes.Pes_sexo = ddlSexoA.SelectedValue;
            pes.Pes_cidade = ddlCidadeA.SelectedValue;
            pes.Pes_estado = ddlEstadoA.SelectedValue;
            pes.Pes_nascimento = Convert.ToDateTime(txtDataNasc.Text);

            pes_pessoaDB.Insert(pes);



            usu_usuario us = new usu_usuario();
            us.Usu_email = txtEmailA.Text;
            us.Usu_senha = txtSenhaA.Text;
            us.Usu_tipo = "Administrador";

            string n = txtNomeA.Text;
            ////cria um dataset, pois o SelectByEmail retorna um dataset
            DataSet id = new DataSet();

            id = pes_pessoaDB.SelectByEmail(n);

            pes.Pes_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);
            us.Pes_id = pes;
            //adm.Adm_cpf = txtCpf.Text;

            usu_usuarioDB.Insert(us);
            ////joga o email pra uma variavel

            //switch (pes_pessoaDB.Insert(pes))
            //{
            //    case 0:
            //        lbl.Text = "Cadastrado com sucesso";

            //        lblCS.Visible = false;
            //        txtNomeA.Text = "";
            //        txtEmailA.Text = "";
            //        txtSenhaA.Text = "";

            //        break;
            //    case -2:
            //        lbl.Text = "Erro, verifique os campos acima e tente novamente";
            //        break;
            //}

            txtNomeA.Text = null;
            txtEmailA.Text = null;
            txtSenhaA.Text = null;
            txtDataNasc.Text = null;
            lbl.Text = "<script>alert('Administrador cadastrado com sucesso');</script>";
        }
        else
        {
            lblCS.Text = "As senhas devem ser identicas em ambos os campos!";
            lblCS.Visible = true;
        }
    }
}