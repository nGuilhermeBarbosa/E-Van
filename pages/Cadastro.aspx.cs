using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Cadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddlTipoConta_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Free.Visible != true)
        {
            Free.Visible = true;
            Premium.Visible = false;
        }
        else
        {
            Free.Visible = false;
            Premium.Visible = true;
        }
    }

    protected void rbM_CheckedChanged(object sender, EventArgs e)
    {
        if(rbM.Checked != false)
        {
            rbA.Checked = false;
            rbM.Checked = true;
        }else{
            rbM.Checked = false;
            rbA.Checked = true;
        }
    }

    protected void rbA_CheckedChanged(object sender, EventArgs e)
    {
        if (rbA.Checked != false)
        {
            rbM.Checked = false;
            rbA.Checked = true;
        }
        else
        {
            rbA.Checked = false;
            rbM.Checked = true;
        }
    }
}