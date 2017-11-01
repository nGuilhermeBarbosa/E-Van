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

        if (Session["perfil"] != null)
        {
            Response.Redirect("homeCliente.aspx");
        }

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
        usu_usuario usu = new usu_usuario();
        usu.Usu_email = txtEmail.Text;
        usu.Usu_senha = Funções.Hash(txtSenha.Text, "SHA512");

        DataSet ds = usu_usuarioDB.SelectLOGIN(usu);
        // mot_motorista mot = new mot_motorista();

        if (ds.Tables[0].Rows.Count == 1)
        {
            Sessão ses = new Sessão(Convert.ToInt32(ds.Tables[0].Rows[0]["usu_id"].ToString()), ds.Tables[0].Rows[0]["usu_email"].ToString(), ds.Tables[0].Rows[0]["pes_nome"].ToString());
            Session["nome"] = ses;
            Session["perfil"] = ds.Tables[0].Rows[0]["usu_tipo"].ToString();
            string perfil = Convert.ToString(Session["perfil"]);


            switch (perfil)
            {
                case "Passageiro":
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
            lbl.Text = "Erro, verifique os campos acima e tente novamente";
        }
    }
}