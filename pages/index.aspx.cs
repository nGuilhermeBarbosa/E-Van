using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["perfil"] != null)
        {
            Response.Redirect("homeCliente.aspx");
        }

        if (!IsPostBack)
        {

        }
    }


    protected void ddlPM_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Convert.ToInt32(ddlPM.SelectedItem.Value) == 0)
        {
            Label2.Text = "Por favor selecione uma opção";
            Label2.Visible = true;
        }
        else if (Convert.ToInt32(ddlPM.SelectedItem.Value) == 1)
        {
            pPassageiro.Visible = true;
            pMotorista.Visible = false;
            Label2.Visible = false;
        }
        else
        {
            pPassageiro.Visible = false;
            pMotorista.Visible = true;
            Label2.Visible = false;
        }
    }

    protected void btnCadastrarPassageiro_Click(object sender, EventArgs e)
    {
        if (txtSenha.Text == txtSenha2.Text)
        {
            if (CheckBox1.Checked == false)
            {
                Label1.Text = "Para prosseguir você deve concordar com os Termos de Uso!";
                Label1.Visible = true;
            }
            else if (Convert.ToInt32(ddlPM.SelectedItem.Value) == 0)
            {
                Label2.Text = "Por favor selecione uma opção para proseguir com o cadastro";
                Label2.Visible = true;
                Label1.Visible = false;
            }
            else
            {

                pes_pessoa pessoa = new pes_pessoa();
                pessoa.Pes_nome = txtNome.Text;
                pessoa.Pes_sexo = ddlSexo.SelectedValue;
                pessoa.Pes_cidade = ddlCidade.SelectedValue;
                pessoa.Pes_estado = ddlEstado.SelectedValue;
                pessoa.Pes_sexo = ddlSexo.SelectedValue;
                pessoa.Pes_nascimento = Convert.ToDateTime(txtData.Text);
                string name = txtNome.Text;

                pes_pessoaDB.Insert(pessoa);

                DataSet codigo = new DataSet();

                codigo = pes_pessoaDB.SelectByEmail(name);

                pessoa.Pes_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                

                usu_usuario us = new usu_usuario();
                us.Usu_email = txtEmail.Text;
                us.Usu_senha = Funções.Hash(txtSenha.Text, "SHA512");
                us.Usu_tipo = ddlPM.SelectedValue;
                us.Pes_id = pessoa;

                usu_usuarioDB.Insert(us);

                pas_passageiro passageiro = new pas_passageiro();
                passageiro.Pas_cpf = txtCpf.Text;

                ////joga o email pra uma variavel
                string email = txtEmail.Text;

                ////cria um dataset, pois o SelectByEmail retorna um dataset
                DataSet id = new DataSet();

                id = usu_usuarioDB.SelectByEmail(email);

                us.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                passageiro.Usu_id = us;


                switch (pas_passageiroDB.Insert(passageiro))
                {
                    case 0:
                        Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                        txtEmail.Text = "";
                        txtNome.Text = "";
                        txtCpf.Text = "";
                        Label1.Visible = false;
                        break;
                    case -2:
                        Response.Write("<script>alert('Ocorreu um erro, por favor verifique os campos e tente novamente');</script>");
                        break;
                }



                //Server.Transfer("login.aspx", true);

            }
        }


        else
        {
            Label1.Text = "As senhas estão diferentes!";
            Label1.Visible = true;
        }



    }

    protected void btnCadastrarMotorista_Click(object sender, EventArgs e)
    {
        if (txtSenhaCM.Text == txtSenhaM.Text)
        {
            if (CheckBox1.Checked == false)
            {
                Label1.Text = "Para prosseguir você deve concordar com os Termos de Uso!";
                Label1.Visible = true;
            }
            else
            {

                pes_pessoa pes = new pes_pessoa();
                pes.Pes_nome = txtNomeM.Text;
                pes.Pes_sexo = ddlSexoM.SelectedValue;
                pes.Pes_cidade = ddlCidadeM.SelectedValue;
                pes.Pes_estado = ddlEstadoM.SelectedValue;
                pes.Pes_nascimento = Convert.ToDateTime(txtDataM.Text);

                pes_pessoaDB.Insert(pes);

                string nome = txtNomeM.Text;

                DataSet cod = new DataSet();

                cod = pes_pessoaDB.SelectByEmail(nome);

                pes.Pes_id = Convert.ToInt32(cod.Tables[0].Rows[0][0]);


                usu_usuario us = new usu_usuario();
                us.Usu_email = txtEmailM.Text;
                us.Usu_senha = Funções.Hash(txtSenhaM.Text, "SHA512");
                us.Usu_tipo = ddlPM.SelectedValue;
                us.Pes_id = pes;

                usu_usuarioDB.Insert(us);

                mot_motorista mot = new mot_motorista();
                mot.Mot_cnpj = txtCnpj.Text;

                ////joga o email pra uma variavel
                string emai = txtEmailM.Text;

                ////cria um dataset, pois o SelectByEmail retorna um dataset
                DataSet ds = new DataSet();


                ds = usu_usuarioDB.SelectByEmail(emai);


                us.Usu_id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                mot.Usu_id = us;

                switch (mot_motoristaDB.Insert(mot))
                {
                    case 0:
                        Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                        txtEmailM.Text = "";
                        txtNomeM.Text = "";
                        txtCnpj.Text = "";
                        break;
                    case -2:
                        Response.Write("<script>alert('Ocorreu um erro, por favor verifique os campos e tente novamente');</script>");

                        break;
                }

                //Server.Transfer("Cadastro.aspx", true);


            }

            Label1.Visible = false;
        }


        else
        {
            Label1.Text = "As senhas estão diferentes!";
            Label1.Visible = true;
        }


    }


    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (ddlPM.SelectedIndex == 1)
        {

            if (txtSenha.Text == txtSenha2.Text)
            {
                if (CheckBox1.Checked == false)
                {
                    Label1.Text = "Para prosseguir você deve concordar com os Termos de Uso!";
                    Label1.Visible = true;
                }
                else if (Convert.ToInt32(ddlPM.SelectedItem.Value) == 0)
                {
                    Label2.Text = "Por favor selecione uma opção para proseguir com o cadastro";
                    Label2.Visible = true;
                    Label1.Visible = false;
                }
                else
                {

                    pes_pessoa pessoa = new pes_pessoa();
                    pessoa.Pes_nome = txtNome.Text;
                    pessoa.Pes_sexo = ddlSexo.SelectedValue;
                    pessoa.Pes_cidade = ddlCidade.SelectedValue;
                    pessoa.Pes_estado = ddlEstado.SelectedValue;
                    pessoa.Pes_sexo = ddlSexo.SelectedValue;
                    pessoa.Pes_nascimento = Convert.ToDateTime(txtData.Text);
                    string name = txtNome.Text;

                    pes_pessoaDB.Insert(pessoa);

                    DataSet codigo = new DataSet();

                    codigo = pes_pessoaDB.SelectByEmail(name);

                    pessoa.Pes_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);



                    usu_usuario us = new usu_usuario();
                    us.Usu_email = txtEmail.Text;
                    us.Usu_senha = Funções.Hash(txtSenha.Text, "SHA512");
                    us.Usu_tipo = ddlPM.SelectedValue;
                    us.Pes_id = pessoa;

                    usu_usuarioDB.Insert(us);

                    pas_passageiro passageiro = new pas_passageiro();
                    passageiro.Pas_cpf = txtCpf.Text;

                    ////joga o email pra uma variavel
                    string email = txtEmail.Text;

                    ////cria um dataset, pois o SelectByEmail retorna um dataset
                    DataSet id = new DataSet();

                    id = usu_usuarioDB.SelectByEmail(email);

                    us.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                    passageiro.Usu_id = us;


                    switch (pas_passageiroDB.Insert(passageiro))
                    {
                        case 0:
                            Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                            txtEmail.Text = "";
                            txtNome.Text = "";
                            txtCpf.Text = "";
                            Label1.Visible = false;
                            break;
                        case -2:
                            Response.Write("<script>alert('Ocorreu um erro, por favor verifique os campos e tente novamente');</script>");
                            break;
                    }



                    //Server.Transfer("login.aspx", true);

                }
            }


            else
            {
                Label1.Text = "As senhas estão diferentes!";
                Label1.Visible = true;
            }

        }
        else
        {

            if (txtSenhaCM.Text == txtSenhaM.Text)
            {
                if (CheckBox1.Checked == false)
                {
                    Label1.Text = "Para prosseguir você deve concordar com os Termos de Uso!";
                    Label1.Visible = true;
                }
                else
                {

                    pes_pessoa pes = new pes_pessoa();
                    pes.Pes_nome = txtNomeM.Text;
                    pes.Pes_sexo = ddlSexoM.SelectedValue;
                    pes.Pes_cidade = ddlCidadeM.SelectedValue;
                    pes.Pes_estado = ddlEstadoM.SelectedValue;
                    pes.Pes_nascimento = Convert.ToDateTime(txtDataM.Text);

                    pes_pessoaDB.Insert(pes);

                    string nome = txtNomeM.Text;

                    DataSet cod = new DataSet();

                    cod = pes_pessoaDB.SelectByEmail(nome);

                    pes.Pes_id = Convert.ToInt32(cod.Tables[0].Rows[0][0]);


                    usu_usuario us = new usu_usuario();
                    us.Usu_email = txtEmailM.Text;
                    us.Usu_senha = Funções.Hash(txtSenhaM.Text, "SHA512");
                    us.Usu_tipo = ddlPM.SelectedValue;
                    us.Pes_id = pes;

                    usu_usuarioDB.Insert(us);

                    mot_motorista mot = new mot_motorista();
                    mot.Mot_cnpj = txtCnpj.Text;

                    ////joga o email pra uma variavel
                    string emai = txtEmailM.Text;

                    ////cria um dataset, pois o SelectByEmail retorna um dataset
                    DataSet ds = new DataSet();


                    ds = usu_usuarioDB.SelectByEmail(emai);


                    us.Usu_id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    mot.Usu_id = us;

                    switch (mot_motoristaDB.Insert(mot))
                    {
                        case 0:
                            Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                            txtEmailM.Text = "";
                            txtNomeM.Text = "";
                            txtCnpj.Text = "";
                            break;
                        case -2:
                            Response.Write("<script>alert('Ocorreu um erro, por favor verifique os campos e tente novamente');</script>");

                            break;
                    }

                    //Server.Transfer("Cadastro.aspx", true);


                }

                Label1.Visible = false;
            }


            else
            {
                Label1.Text = "As senhas estão diferentes!";
                Label1.Visible = true;
            }

        }
    }
}

