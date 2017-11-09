using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pages_serviceInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    DataSet ds = ser_servicosDB.SelectAll();

    public void ServiceLoad()
    {
        foreach (DataRow dados in ds.Tables[0].Rows)
        {
            lInfo.Text = "< div class='col-lg-8'>" +
            "<div class='title'>João</div>" +
            "<div class='serviceBox'>" +
                "<div class='title'>Serviço</div>" +
                "<div class='padding'>" +
                //Local
                "<br />" +
                //Origem
                "<br />" +
                //Destino
                "<br />" +
                "</div>" +
            //Data
            "</div>" +

            "<div class='serviceBox'>" +
                "<div class='title'>Contatos</div>" +
                "<div class='padding'>" +
                //Informação de contato (telefone, celular ou whatsapp)
                //Email
                "</div>" +
            "</div>" +

            "<div class='serviceBox'>" +
                "<div class='title w3'>Motorista</div>" +
                "<div class='padding'>" +
                //nome
                //cnh
                "</div>" +
            "</div>" +

            "<div class='serviceBox'>" +
                "<div class='title'>Veículo</div>" +
                "<div class='padding'>" +
                    //número do veículo 
                    //Tipo
                    //Complementos
                    //Lugares
                    "<table>" +
                        "<tr>" +
                            "<td>" +
                                "<div class='photoDriver border'>" +
                                //foto ABNT
                                "</div>" +
                            "</td>" +
                            "<td>" +
                                "<div class='photoDriver border'>" +
                                //Foto ARTESP
                                "</div>" +
                            "</td>" +
                        "</tr>" +
                    "</table>" +
                "</div>" +
                "<p>Lugares Disponíveis: " +/*lugares disponíveis*/"</p>" +
            "</div>" +

            "<div class='serviceBox info padding Free'>" +
        //Você tem interesse nesse serviço?
        "<br />" +
            "    <asp:CheckBox ID = 'CheckBox1' runat='server' Text='Sim' />" +
            "</div>" +

        "</div>" +

        "<div class='col-lg-4'>" +
            "<div class='title'>Fotos do Veículo</div>" +
            "<div class='photoGallery mainPhoto'>" +
            "</div>" +
            "<div class='galleryField'>" +
                "<div class='photoGallery'></div>" +
                "<div class='photoGallery'></div>" +
                "<div class='photoGallery'></div>" +
            "</div>" +
        "</div>" +
    "</div>";
        }
    }
}