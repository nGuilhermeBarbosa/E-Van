using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_homeMotorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                Sessão usu = (Sessão)Session["nome"];
                //lblSessao.Text = usu.email;
                hdf.Value = usu.id.ToString();
                CampoVazio();
            }
        }
    }
    public void CampoVazio()
    {

        DataSet ds = mxc_motorista_tipo_contatoDB.SelectAll(Convert.ToInt32(hdf.Value));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 0)
        {
            //lbl.Text = Convert.ToString(cont);
            lbl.Text = "<div class=popup>Para a utilização completa do sistema complete o seu cadastro <a href=CompletaCadastro.aspx>Aqui</a> </div>";
        } 
    }
}