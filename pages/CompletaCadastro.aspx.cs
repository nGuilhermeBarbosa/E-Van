using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_CompletaCadastro : System.Web.UI.Page
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
                CarregarDDL();
            }
        }
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        DataSet ds = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = Convert.ToInt32(ds.Tables[0].Rows[0]["mot_id"]);

        tpc_tipo_contato tpc = new tpc_tipo_contato();
        tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);
        //tpc.Tpc_descricao = ddl.SelectedItem.Text;
        //tpc_tipo_contatoDB.Insert(tpc);

        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        mxc.Mxc_descricao = txtTelefone.Text;
        mxc.Mot_id = mot;
        mxc.Tpc_id = tpc;

        mxc_motorista_tipo_contatoDB.Insert(mxc);

    }

    public void CarregarDDL()
    {
        DataSet ds = tpc_tipo_contatoDB.SelectAll();
        ddl.DataSource = ds;
        ddl.DataTextField = "tpc_descricao";
        ddl.DataValueField = "tpc_id";
        ddl.DataBind();
        ddl.Items.Insert(0, "Selecione");
    }
}