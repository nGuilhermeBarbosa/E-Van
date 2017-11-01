using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_teste : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServicesLoad();
    }
    DataSet ds = tdo_tipodocumentoDB.SelectAll();

    public void ServicesLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            Literal1.Text += "<div class='serviceBox shadow'> "
                + "<div class='title'> Imagem&nbsp;" + dados["tdo_id"] + "</div>"
                + "<div class='padding'>"
                + "<img src='../pg/uploads/" + dados["tdo_image"] + "' width='200px'/><br />"
                + "</div></div>";
        }
    }
}