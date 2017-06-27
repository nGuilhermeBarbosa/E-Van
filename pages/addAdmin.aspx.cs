using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_addAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCancelaCadastro_Click(object sender, EventArgs e)
    {

    }
    protected void btnConfirmaCadastro_Click(object sender, EventArgs e)
    {


        txtNome.Text = "";
        txtNomeUsuario.Text = "";
        txtTelAdm.Text = "";
        txtEmail.Text = "";
        txtSenha.Text = "";
        txtConfirmarSenha.Text = "";
        txtCpf.Text = "";
        dataNasc.Text = "";
        txtEnd.Text = "";
        
    }
}