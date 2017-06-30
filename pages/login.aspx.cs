using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
         IF (Session["USUARIO"] != null){

         Usuario usu = Session["USUARIO"] as Usuario
        

        Simples: usar if

        Se for do tipo 1, ou 2 entao pode acessar, caso contrario não

        Complexo: Criar um list de int para mostrar quais tipos podem acessar a pagina

        List<int> tipos = new List<int>();

        tipos.Add(1);
        tipos.Add(2);

        Percorre a lista e comparando com o objeto do usuario

        bool podeAcessar = false;

        for..
            if (usu.usu_tipo_permitido == tipos[i])
                podeAcessar = true;
                break;
            fecha if
        fecha for


        }else{
        
        Redireciona para outra pagina
        }
         /  
         
         */
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        // login e senha.
        // captcha .aspx
        // Select que pega os dados e salva em um objeto
        // compara a senha digitada com a senha do banco
        // se a senha estiver correta você salva em uma sessão
        // ex: Session["USUARIO"] = [objeto do banco] pessoa

        DataSet ds = usu_usuarioDB.SelectLOGIN(txtEmail.Text, txtSenha.Text);

        if (ds.Tables[0].Rows.Count == 1)
        {

            Session["nome"] = ds.Tables[0].Rows[0]["usu_email"].ToString();
            Session["perfil"] = ds.Tables[0].Rows[0]["usu_tipo"].ToString();
            string perfil = Convert.ToString(Session["perfil"]);


            switch (perfil)
            {
                case "Cliente":
                    Response.Redirect("homeCliente.aspx");
                    break;
                case "Motorista":
                    Response.Redirect("homeMotorista.aspx");
                    break;
                case "Administrador":
                    Response.Redirect("allAdmin.aspx");
                    break;
            }

        }
        else
        {
            Response.Write("ERRO");
        }
    }
}