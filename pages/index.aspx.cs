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
        if (!IsPostBack)
        {
            CarregarGrid();
        }
    }

    private void CarregarGrid()
    {
        DataSet ds = mot_motoristaDB.SelectAll();
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd > 0)
        {
            gridUsuario.DataSource = ds.Tables[0].DefaultView;
            gridUsuario.DataBind();
            //--------------------------
            gridUsuario.Visible = true;
            //lbl.Text = "Foram emcontrados " + qtd + " de registros!";
        }
        else
        {
            gridUsuario.Visible = false;
            //lbl.Text = "Não foram encotrado registros...";
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //if (CheckBox1.Checked == false)
        //{
        //    Label1.Visible = true;
        //}
        //else
        //{
        //    //Código do botão aqui
        //    Label1.Visible = false;
        //}


                //usu_usuario us = new usu_usuario();
                //us.Usu_email = txtEmail.Text;
                //us.Usu_senha = txtSenha.Text;


                //cli_cliente cli = new cli_cliente();
                //cli.Cli_nome = txtNome.Text;
                //cli.Cli_sexo = ddlSexo.SelectedValue;
                //cli.Cli_cidade = ddlCidade.SelectedValue;
                //cli.Cli_estado = ddlEstado.SelectedValue;

                switch (ddlPM.Text)
                {
                    case "1":
                        usu_usuario us = new usu_usuario();
                        us.Usu_email = txtEmail.Text;
                        us.Usu_senha = txtSenha.Text;

                        //Insere o Usuario
                        cli_cliente cli = new cli_cliente();
                        cli.Cli_nome = txtNome.Text;
                        cli.Cli_sexo = ddlSexo.SelectedValue;
                        cli.Cli_cidade = ddlCidade.SelectedValue;
                        cli.Cli_estado = ddlEstado.SelectedValue;
                        ////joga o email pra uma variavel

                        string emai = txtEmail.Text;

                        ////cria um dataset, pois o SelectByEmail retorna um dataset
                        DataSet codigo = new DataSet();

                        ////      SelectByEmail       //
                        //pesquisa na tabela usu_usuario o email do usuario que se cadastrou, para entao pegar o usu_id desse usuario

                        ////manda esse id para o dataset criado
                        codigo = usu_usuarioDB.SelectByEmail(emai);

                        ////                          como o dataset é uma tabela coloca os dados em uma, para pegar ele tem que pegar como se fosse uma tabela
                        ////                          entao pega a Tabela 0 ( .Tables[0] ), pois começa a contar a partir do 0, mesma coisa dps nas linhas e colunas
                        ////                          .Rows[0][0] = o primeiro 0 é a Linha e o segundo 0 é a Coluna

                        ////entao pega o que ta na tabela 0, linha 0 e coluna 0, pq a unica coisa que tem é o id do usuario
                        ////e joga pro Usu.id
                        us.Usu_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                //switch (cli_clienteDB.Insert(cli))
                //{
                //    case 0:
                //        lbl.Text = "<<<   OK  >>>";
                //        break;
                //    case -2:
                //        lbl.Text = "<<<  ERRO  >>";
                //        break;

                        switch (cli_clienteDB.Insert(cli))
                        {
                            case 0:
                                lbl.Text = "<<<   OK  >>>";
                                break;
                            case -2:
                                lbl.Text = "<<<  ERRO  >>";
                                break;

                        }
                        break;

                    case "2":
                        usu_usuario usu = new usu_usuario();
                        usu.Usu_email = txtEmail.Text;
                        usu.Usu_senha = txtSenha.Text;

                        //Insere o Usuario
                        switch (usu_usuarioDB.Insert(usu))
                        {
                            case 0:
                                lbl.Text = "<<< OK >>>";
                                break; //caso der certo já sai do switch, igual no switch do motorista
                            case -2:
                                lbl.Text = "<<<  ERRO  >>";
                                break;
                        }

                        mot_motorista mot = new mot_motorista();
                        mot.Mot_nome = txtNome.Text;
                        mot.Mot_sexo = ddlSexo.SelectedValue;
                        mot.Mot_cidade = ddlCidade.SelectedValue;
                        mot.Mot_estado = ddlEstado.SelectedValue;
                        //mot.Mot_cnpj = txtCnpj.Text;
                        ////joga o email pra uma variavel
                        string email = txtEmail.Text;

                        ////cria um dataset, pois o SelectByEmail retorna um dataset
                        DataSet id = new DataSet();

                        ////      SelectByEmail       //
                        //pesquisa na tabela usu_usuario o email do usuario que se cadastrou, para entao pegar o usu_id desse usuario

                        ////manda esse id para o dataset criado
                        id = usu_usuarioDB.SelectByEmail(email);

                        ////                          como o dataset é uma tabela coloca os dados em uma, para pegar ele tem que pegar como se fosse uma tabela
                        ////                          entao pega a Tabela 0 ( .Tables[0] ), pois começa a contar a partir do 0, mesma coisa dps nas linhas e colunas
                        ////                          .Rows[0][0] = o primeiro 0 é a Linha e o segundo 0 é a Coluna

                        ////entao pega o que ta na tabela 0, linha 0 e coluna 0, pq a unica coisa que tem é o id do usuario
                        ////e joga pro Usu.id
                        usu.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                        mot.Usu_id = usu;

                        switch (mot_motoristaDB.Insert(mot))
                        {
                            case 0:
                                lbl.Text = "<<<   OK  >>>";
                                break;
                            case -2:
                                lbl.Text = "<<<  ERRO  >>";
                                break;

                        }
                        break;
                }

                Label1.Visible = false;
            }
        }
        else
        {
            Label1.Text = "As senhas estão diferentes!";
            Label1.Visible = true;
        }

        CarregarGrid();
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
}
