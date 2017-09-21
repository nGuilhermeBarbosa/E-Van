using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_AlterarDadosPessoais : System.Web.UI.Page
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
                CarregarVisualizar();
                //CarregarDDL();
            }
        }
    }
    public void CarregarVisualizar()
    {
        usu_usuario usu = new usu_usuario();
        mot_motorista mot = new mot_motorista();
        pes_pessoa pes = new pes_pessoa();
        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        tpc_tipo_contato tpc = new tpc_tipo_contato();

        DataSet ds = mot_motoristaDB.SelectDados(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            hdfID.Value = ds.Tables[0].Rows[0]["pes_id"].ToString();
            txtNome.Text = ds.Tables[0].Rows[0]["pes_nome"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["usu_email"].ToString();
            txtCNPJ.Text = ds.Tables[0].Rows[0]["mot_cnpj"].ToString();
            ddlSexo.SelectedItem.Text = ds.Tables[0].Rows[0]["pes_sexo"].ToString();
            ddlCidade.SelectedItem.Text = ds.Tables[0].Rows[0]["pes_cidade"].ToString();
            ddlEstado.SelectedItem.Text = ds.Tables[0].Rows[0]["pes_estado"].ToString();
            ddl.SelectedItem.Text = ds.Tables[0].Rows[0]["tpc_descricao"].ToString();
            txtTelefone.Text = ds.Tables[0].Rows[0]["mxc_descricao"].ToString();
            txtData.Text = ds.Tables[0].Rows[0]["pes_nascimento"].ToString();

        }
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        mot_motorista mot = new mot_motorista();
        tpc_tipo_contato tpc = new tpc_tipo_contato();

        DataSet ds = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        if (ds.Tables[0].Rows.Count == 1)
        {
            //if (mxc.Mxc_descricao == null)
            //{
            //    hdfM.Value = ds.Tables[0].Rows[0]["mot_id"].ToString();

            //    tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);
            //    CarregarDDL();

            //    mot.Mot_id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            //    mxc.Tpc_id = tpc;
            //    mxc.Mxc_descricao = txtTelefone.Text;
            //    mxc.Mot_id = mot;
            //}
            mot.Mot_cnpj = txtCNPJ.Text;
            mot_motoristaDB.Update(mot);

            tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);
            mxc.Tpc_id = tpc;

            //tpc_tipo_contatoDB.Update(tpc);

            mxc.Mxc_descricao = txtTelefone.Text;
            mxc_motorista_tipo_contatoDB.Update(mxc);

            pes_pessoa pes = new pes_pessoa();
            pes.Pes_id = Convert.ToInt32(hdf.Value);
            pes.Pes_nome = txtNome.Text;
            pes.Pes_sexo = ddlSexo.SelectedValue;
            pes.Pes_cidade = ddlCidade.SelectedValue;
            pes.Pes_estado = ddlEstado.SelectedValue;
            pes.Pes_nascimento = Convert.ToDateTime(txtData.Text);

            switch (pes_pessoaDB.Update(pes))
            {
                case 0:
                    //Response.Write("OK");
                    Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
                    break;
                case -2:
                    //Response.Write("ERRO");
                    Response.Write("<script>alert('Ocorreu um Erro');</script>");
                    break;
            }

        }


        // switch (pas_passageiroDB.Update(cli))
        //{
        //    case 0:
        //        //Response.Write("OK");
        //        Label1.Text = "Dados Alterados com sucesso";
        //        break;
        //    case -2:
        //        //Response.Write("ERRO");
        //        Label1.Text = "Ocorreu um erro ao atualizar os dados, por favor confira os campos
        //            "e tente novamente";
        //        break;
        //}
    }
    //public void CarregarDDL()
    //{
    //    DataSet ds = tpc_tipo_contatoDB.SelectAll();
    //    ddl.DataSource = ds;
    //    ddl.DataTextField = "tpc_descricao";
    //    ddl.DataValueField = "tpc_id";
    //    ddl.DataBind();
    //    ddl.Items.Insert(0, "Selecione");
    //}
}