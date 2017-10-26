using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_faleConosco : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        fal_faleconosco fal = new fal_faleconosco();
        fal.fal_nome = TextBox1.Text;
        fal.fal_email = TextBox2.Text;
        fal.fal_mensagem = TextBox3.Text;

        switch (fal_faleconoscoDB.Insert(fal))
        {
            case 0:
                //lblFeedBack.Text = "<script>alert('Mensagem enviada com sucesso');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalCb();", true);
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox3.Text = null;
                break;
                
            case -2:
                lblFeedBack.Text = "Erro";
                break;
        }
    }
}