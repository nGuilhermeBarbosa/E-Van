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
        if (txtSenha.Text == txtConfirmarSenha.Text)
        {
            if (CheckBox1.Checked == false)
            {
                Label1.Text = "Para prosseguir você deve concordar com os Termos de Uso!";
                Label1.Visible = true;
            }
            else
            {

                switch (ddlPM.Text)
                {
                    case "1":
                        usu_usuario us = new usu_usuario();
                        us.Usu_email = txtEmail.Text;
                        us.Usu_senha = txtSenha.Text;

                        //Insere o Usuario
                        Adm_Administrador adm = new Adm_Administrador();
                        adm.Adm_nome = txtNome.Text;
                        adm.Adm_telefone = Convert.ToInt32(txtTelAdm.Text);
                        adm.Adm_sexo = ddlAddAdmin.SelectedValue;
                        adm.Adm_datanascimento = dataNasc.Text;
                        adm.Adm_cidade = ddlCidade.SelectedValue;
                        adm.Adm_estado = ddlEstado.SelectedValue;

                        ////joga o email pra uma variavel

                        string emai = txtEmail.Text;

                        ////cria um dataset, pois o SelectByEmail retorna um dataset
                        DataSet codigo = new DataSet();

                        ////      SelectByEmail       //
                        //pesquisa na tabela usu_usuario o email do usuario que se cadastrou, para entao pegar o usu_id desse usuario

                        ////manda esse id para o dataset criado
                        codigo = adm_administradorDB.SelectByEmail(emai);

                        ////                          como o dataset é uma tabela coloca os dados em uma, para pegar ele tem que pegar como se fosse uma tabela
                        ////                          entao pega a Tabela 0 ( .Tables[0] ), pois começa a contar a partir do 0, mesma coisa dps nas linhas e colunas
                        ////                          .Rows[0][0] = o primeiro 0 é a Linha e o segundo 0 é a Coluna

                        ////entao pega o que ta na tabela 0, linha 0 e coluna 0, pq a unica coisa que tem é o id do usuario
                        ////e joga pro Usu.id
                        us.Usu_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                        adm.Usu_id = us;

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

        ddlAddAdmin.Text = "";
        txtNome.Text = "";
        txtNomeUsuario.Text = "";
        txtTelAdm.Text = "";
        txtEmail.Text = "";
        txtSenha.Text = "";
        txtConfirmarSenha.Text = "";
        txtCpf.Text = "";
        dataNasc.Text = "";
        txtEnd.Text = "";
        ddlEstado.Text = "";
        ddlCidade.Text = "";

        
    }
}