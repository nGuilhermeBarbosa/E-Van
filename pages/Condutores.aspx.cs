using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Condutores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] != null)
        {
            CondutorLoad();
            CadastroCompleto();
        }
    }

    public void CondutorLoad()
    {
        hdf.Value = Session["value"].ToString();

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;
        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = con_condutorDB.SelectDados(c);

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            ltrCondutores.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<p class='destino title'>" + dados["con_nome"] 
                + "<span class='glyphicon glyphicon-remove text_right'>&nbsp Excluir</span></span>"
                + "<span class='glyphicon glyphicon-edit'>&nbsp Editar</span></span></p>"
                + "<div class='padding'>"
                + "<p><b>Cpf</b>: " + dados["con_cpf"] + "</p>"
                + "<p><b>Tipo de Contato</b>:" + dados["tpc_descricao"] + "</p>"
                + "<p><b>Contato</b>: " + dados["ctp_descricao"] + " </p>"
                + "</p></div></div></div>";
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