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

                //string emai = txtEmail.Text;


                //DataSet codigo = new DataSet();


                //codigo = usu_usuarioDB.SelectByEmail(emai);


                //us.Usu_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                //cli.Usu_id = us;

                //switch (cli_clienteDB.Insert(cli))
                //{
                //    case 0:
                //        lbl.Text = "<<<   OK  >>>";
                //        break;
                //    case -2:
                //        lbl.Text = "<<<  ERRO  >>";
                //        break;

                //}
                
          
                usu_usuario usu = new usu_usuario();
                usu.Usu_email = txtEmail.Text;
                usu.Usu_senha = txtSenha.Text;

                mot_motorista mot = new mot_motorista();
                mot.Mot_nome = txtNome.Text;
                mot.Mot_sexo = ddlSexo.SelectedValue;
                mot.Mot_cidade = ddlCidade.SelectedValue;
                mot.Mot_estado = ddlEstado.SelectedValue;

                string email = txtEmail.Text;


                DataSet id = new DataSet();


                id = usu_usuarioDB.SelectByEmail(email);


                usu.Usu_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);
                mot.Usu_id = usu;

                switch (mot_motoristaDB.Insert(mot))
                {
                    case 0:
                        lbl.Text = "<<< OK >>>";
                        break;
                    case -2:
                        lbl.Text = "<<<  ERRO  >>";
                        break;
                }
               
        
        CarregarGrid();

    }
}
