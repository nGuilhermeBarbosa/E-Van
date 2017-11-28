﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_TodosVeiculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            //Sessão usu = (Sessão)Session["nome"];
            ////lblSessao.Text = usu.email;
            //hdf.Value = usu.id.ToString();
            CadastroCompleto();
        }
        VeiculoLoad();
    }
    DataSet ds = tra_transporteDB.SelectAll();

    public void VeiculoLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["tra_modelo"] + "</div>"
                + "<div class='padding'>"
                + "<b>Lugares Disponiveis: </b> " + dados["tra_lugares"] + "<br />"
               // + "<b>Cidade</b>:" + dados["pes_cidade"] + "<br />"
               // + "<b>Contato</b>:" + dados["usu_email"] + "<br />"
                + "</div></div>";
        }
    }
    public void CadastroCompleto()
    {
        hdf.Value = Session["value"].ToString();
        DataSet ds = mxc_motorista_tipo_contatoDB.SelectAll(Convert.ToInt32(hdf.Value));
        int qtd = ds.Tables[0].Rows.Count;

        if (qtd == 0)
        {
            //lbl.Text = Convert.ToString(cont);
            Response.Redirect("Erro.aspx");
        }
    }
}