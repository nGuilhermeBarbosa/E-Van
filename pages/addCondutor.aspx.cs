using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_addCondutor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                CarregarDDL();
            }
        }
    }

    protected void btnAdicionar_Click(object sender, EventArgs e)
    {
        hdf1.Value = Session["value"].ToString();

        DataSet codigo = new DataSet();
        codigo = con_condutorDB.SelectM(Convert.ToInt32(hdf1.Value));

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

        con_condutor con = new con_condutor();

        con.Con_cpf = txtCPF.Text;
        con.Con_nome = txtNome.Text;
        con.Mot_id = mot;

        string name = txtNome.Text;

        con_condutorDB.Insert(con);

        DataSet id = new DataSet();

        id = con_condutorDB.SelectCon(name);

        con.Con_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

        tpc_tipo_contato tpc = new tpc_tipo_contato();
        ctp_condutor_tipo_contato ctp = new ctp_condutor_tipo_contato();

        if (ddl.SelectedValue == 1.ToString())
        {
            ctp.Ctp_descricao = txtTelefone.Text;
        }
        else if (ddl.SelectedValue == 2.ToString())
        {
            ctp.Ctp_descricao = txtCelular.Text;
        }
        else if (ddl.SelectedValue == 3.ToString())
        {
            ctp.Ctp_descricao = txtWhatsapp.Text;
        }
        else if (ddl.SelectedValue == 4.ToString())
        {
            ctp.Ctp_descricao = txtEmail.Text;
        }

        tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);


        ctp.Con_id = con;
        ctp.Tpc_id = tpc;


        switch (ctp_condutor_tipo_contatoDB.Insert(ctp))
        {
            case 0:

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                txtNome.Text = null;
                txtCPF.Text = null;
                txtTelefone.Text = null;
                txtCelular.Text = null;
                txtWhatsapp.Text = null;
                break;
            case -2:

                //ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalE();", true);
                break;
        }


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

    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl.SelectedValue == 0.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = false;
            txtEmail.Visible = false;
        }
        else if (ddl.SelectedValue == 1.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = true;
            txtWhatsapp.Visible = false;
            txtEmail.Visible = false;
        }
        else if (ddl.SelectedValue == 2.ToString())
        {
            txtCelular.Visible = true;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = false;
            txtEmail.Visible = false;
        }
        else if (ddl.SelectedValue == 3.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = true;
            txtEmail.Visible = false;
        }
        else if (ddl.SelectedValue == 4.ToString())
        {
            txtCelular.Visible = false;
            txtTelefone.Visible = false;
            txtWhatsapp.Visible = false;
            txtEmail.Visible = true;
        }
    }
    public void Carregarddl()
    {

    }
}