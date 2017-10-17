﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_Client : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null || Session["perfil"] == null)
        {
            //Response.Redirect("error.aspx");
        }
        else
        {
            string perfil = Convert.ToString(Session["perfil"]);

            if (perfil == "Passageiro")
            {
                Sessão usu = (Sessão)Session["nome"];
                lblSessao.Text = usu.nome;
                //hdf.Value = usu.id.ToString();
                //lblSessao.Text = Session["nome"].ToString();
            }
            else
            {
                Response.Redirect("error.aspx");
            }
        }
    }
    
    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        Session.Remove("perfil");
        Response.Redirect("index.aspx");
    }

    protected void btnDesativar_Click(object sender, EventArgs e)
    {

    }
}
