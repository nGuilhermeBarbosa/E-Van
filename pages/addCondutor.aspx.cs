using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_addCondutor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdicionar_Click(object sender, EventArgs e)
    {

        //Inserir o código de "Insert" aqui
        txtNome.Text = null;
        txtCPF.Text = null;
        txtTelefone.Text = null;
        txtCelular.Text = null;
        txtWhatsapp.Text = null;
    }

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddl.SelectedValue == 0.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = true;
            txtWhatsapp.Visible = false;
        }else if (ddl.SelectedValue == 1.ToString())
        {
            txtCelular.Visible = true;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = false;
        }else if (ddl.SelectedValue == 2.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = true;
        }
    }
}