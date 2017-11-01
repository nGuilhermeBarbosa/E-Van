using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Selecionar_forma_de_pagamento : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["perfil"]) == "Cliente")
        {
            this.MasterPageFile = "~/Client.master";
        }
        else if (Convert.ToString(Session["perfil"]) == "Driver")
        {
            this.MasterPageFile = "~/Driver.master";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void rbCartao_CheckedChanged(object sender, EventArgs e)
    {
        rbBoleto.Checked = false;
        rbPaypal.Checked = false;
        PanelCartao.Visible = true;
        PanelBoleto.Visible = false;
        PanelPayPal.Visible = false;
    }

    protected void rbBoleto_CheckedChanged(object sender, EventArgs e)
    {
        rbCartao.Checked = false;
        rbPaypal.Checked = false;
        PanelBoleto.Visible = true;
        PanelCartao.Visible = false;
        PanelPayPal.Visible = false;
    }

    protected void bVisa_CheckedChanged(object sender, EventArgs e)
    {
        bMaster.Checked = false;
    }

    protected void bMaster_CheckedChanged(object sender, EventArgs e)
    {
        bVisa.Checked = false;
    }

    protected void rbPaypal_CheckedChanged(object sender, EventArgs e)
    {
        rbCartao.Checked = false;
        rbBoleto.Checked = false;
        PanelBoleto.Visible = false;
        PanelCartao.Visible = false;
        PanelPayPal.Visible = true;
    }
}