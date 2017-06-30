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

        if (Session["nome"] != null)
        {
            Server.Transfer("homeCliente.aspx", true);
            //lbl.Text = "ERRO";
        }

    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        usu_usuario usu = new usu_usuario();

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
            lbl.Visible = false;

        }
        else
        {
            Response.Write("");
            lbl.Visible = true;
            lbl.Text = "Email ou Senha Incorretos";
        }
    }
}