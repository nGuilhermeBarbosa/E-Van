﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class pages_motorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                Sessão usu = (Sessão)Session["nome"];
                //lblSessao.Text = usu.email;
                hdf1.Value = usu.id.ToString();
                CarregarVisualizarM();
            }
        }
    }
    public void CarregarVisualizarM()
    {
        mot_motorista mot = new mot_motorista();

        DataSet ds = mot_motoristaDB.SelectDados(Convert.ToInt32(hdf1.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["mot_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["mot_nome"].ToString();
            txtCNPJ.Text = ds.Tables[0].Rows[0]["mot_cnpj"].ToString();
            txtSexo.Text = ds.Tables[0].Rows[0]["mot_sexo"].ToString();
            txtDataNascimento.Text = ds.Tables[0].Rows[0]["mot_datanascimento"].ToString();
            txtCidade.Text = ds.Tables[0].Rows[0]["mot_cidade"].ToString();
            txtEstado.Text = ds.Tables[0].Rows[0]["mot_estado"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();

        }
        else
        {
            Response.Write("ERRO");
        }
    }
    protected void btnAlterar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AlterarDadosMotorista.aspx");
    }
}