﻿using System;
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
                
                        usu_usuario us = new usu_usuario();
                        us.Usu_email = txtEmail.Text;
                        us.Usu_senha = txtSenha.Text;
                        us.Usu_tipo = ddlPM.SelectedValue;

                        usu_usuarioDB.Insert(us);

                        //Insere o Usuario

                cli_cliente cli = new cli_cliente();
                cli.Cli_nome = txtNome.Text;
                cli.Cli_sexo = ddlSexo.SelectedValue;
                cli.Cli_cidade = ddlCidade.SelectedValue;
                cli.Cli_estado = ddlEstado.SelectedValue;
                cli.Cli_cpf = txtCpf.Text;
                cli.Cli_datanascimento = Convert.ToDateTime(txtData.Text);
                ////joga o email pra uma variavel
                string email = txtEmail.Text;
               
                ////cria um dataset, pois o SelectByEmail retorna um dataset
                DataSet id = new DataSet();


                        id = usu_usuarioDB.SelectByEmail(email);


                        us.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                        cli.Usu_id = us;


                switch (cli_clienteDB.Insert(cli))
                {
                    case 0:
                        lbl.Text = "Cadastrado com Sucesso";
                        txtEmail.Text = "";
                        txtNome.Text = "";
                        txtCpf.Text = "";
                        Label1.Visible = false;
                        break;
                    case -2:
                        lbl.Text = "Ocorreu um erro, por favor verifique os campos e tente novamente";

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
                
                usu_usuario usu = new usu_usuario();
                usu.Usu_email = txtEmailM.Text;
                usu.Usu_senha = txtSenhaM.Text;
                usu.Usu_tipo = ddlPM.SelectedValue;

                usu_usuarioDB.Insert(usu);
                

                mot_motorista mot = new mot_motorista();
                mot.Mot_nome = txtNomeM.Text;
                mot.Mot_sexo = ddlSexoM.SelectedValue;
                mot.Mot_cidade = ddlCidadeM.SelectedValue;
                mot.Mot_estado = ddlEstadoM.SelectedValue;
                mot.Mot_cnpj = txtCnpj.Text;
                mot.Mot_dataNascimento = Convert.ToDateTime(txtDataM.Text);
                ////joga o email pra uma variavel
                string emai = txtEmailM.Text;
                
                ////cria um dataset, pois o SelectByEmail retorna um dataset
                DataSet ds = new DataSet();


                ds = usu_usuarioDB.SelectByEmail(emai);


                usu.Usu_id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                        mot.Usu_id = usu;

                switch (mot_motoristaDB.Insert(mot))
                {
                    case 0:
                        lbl.Text = "Cadastrado com Sucesso";
                        txtEmailM.Text = "";
                        txtNomeM.Text = "";
                        txtCnpj.Text = "";
                        break;
                    case -2:
                        lbl.Text = "Ocorreu um erro, por favor verifique os campos e tente novamente";

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

