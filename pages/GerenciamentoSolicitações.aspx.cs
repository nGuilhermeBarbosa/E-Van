﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_r_management : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                //Sessão usu = (Sessão)Session["nome"];
                ////lblSessao.Text = usu.email;
                //hdf.Value = usu.id.ToString();
                CarregarLiteral();
            }
        }
    }

    public void CarregarLiteral()
    {
        hdf.Value = Session["value"].ToString();

        pas_passageiro pas = new pas_passageiro();

        DataSet codigo = new DataSet();

        codigo = pas_passageiroDB.SelectID(Convert.ToInt32(hdf.Value));

        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = pas_passageiroDB.SelectSolicitacao(c);

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            LSolicitacao.Text += "<div class = 'list-item'><div class='serviceBox shadow'> "
                + "<div class='title'>" + dados["pes_nome"]
                //+ "<span class='text-right'>" + dados["sol_id"] + "</span>" 
                + "<span class='text-right'><a href='#' onclick='excluir(" + dados["sol_id"] + ", \"" + dados["pes_nome"] + "\");'><span class='glyphicon glyphicon-remove'></span>&nbsp;Excluir</a></span>"
                 + "   <span class='text-right'><a href = 'editService.aspx?ser=" + dados["sol_id"] + "' ><span class='glyphicon glyphicon-edit'></span>&nbsp;Editar</a></span>" +
                 "</div>"
                + "<div class='padding'>"
                + "<p class = 'origem'><b>Origem</b>: " + dados["sol_origem"] + "</p>"
                + "<p class = 'destino'><b>Destino</b>: " + dados["sol_destino"] + "</p><hr>"
                + "<p><b>Data De Saida</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datainicio"]) + "</p>"
                + "<p><b>Hora de Saida</b>:" + String.Format("{0:HH:mm}", dados["sol_datainicio"]) + "</p><hr>"
                + "<p><b>Data De Volta</b>:" + String.Format("{0:dd/MM/yyyy}", dados["sol_datafim"]) + "</p>"
                + "<p><b>Hora de Volta</b>:" + String.Format("{0:HH:mm}", dados["sol_datafim"]) + "</p>"
                + "<button class='btn btn-default' style='float:right;'>Detalhes</button><br />"
            + "</div></div></div>";
        }
    }
}