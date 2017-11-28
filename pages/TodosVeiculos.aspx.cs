using System;
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
            VeiculoLoad();
            CadastroCompleto();
        }
    }
    

    public void VeiculoLoad()
    {
        hdf.Value = Session["value"].ToString();

        mot_motorista mot = new mot_motorista();

        DataSet codigo = new DataSet();

        codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));
        // Label1.Text = par;
        int c = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        DataSet ds = tra_transporteDB.SelectDados(c);

        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal.Text += "<div class='list-item'><div class='serviceBox shadow'> "
                + "<p class='destino title'>" + dados["tra_modelo"]
                + "<span class='glyphicon glyphicon-remove text_right'>&nbsp Excluir</span></span>"
                + "<span class='glyphicon glyphicon-edit'>&nbsp Editar</span></span></p>" + "</p>"
                + "<div class='padding'>"
                + "<p><b>Tipo de Veiculo</b>: " + dados["tve_descricao"] + "</p>"
                + "<p><b>Lugares</b>:" + dados["tra_lugares"] + "</p>"
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