using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_CadastroServiço : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        ser_servicos serv = new ser_servicos();
        serv.Ser_datacadastro = txtData.Text;
        serv.Ser_origem = txtOrigem.Text;
        serv.Ser_destino = txtDestino.Text;
        serv.Ser_descricao = txtDescricao.Text;



        switch (ser_servicosDB.Insert(serv))
        {
            case 0:
                lblMsg.Text = "Cadastrado com sucesso";
                break;
            case -2:
                lblMsg.Text = "ERRO";
                break;
        }

        txtOrigem.Text = "";
        txtDestino.Text = "";
        txtData.Text = "";
        txtDescricao.Text = "";
    }
}