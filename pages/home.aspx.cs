using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nome"] == null)
        {
            Server.Transfer("Error.aspx", true);
            //lbl.Text = "ERRO";
        }
        else
        {
            lbl.Text = Session["nome"].ToString();
        }
    }

    protected void btnShowAll_Click(object sender, EventArgs e)
    {
        Session.Remove("nome");
        lbl.Text = "";
        Server.Transfer("index.aspx", true);
    }
}