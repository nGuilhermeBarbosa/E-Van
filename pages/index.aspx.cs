using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(CheckBox1.Checked == false)
        {
            Label1.Visible = true;
        }
        else
        {
            //Código do botão aqui
            Label1.Visible = false;
        }
    }
}