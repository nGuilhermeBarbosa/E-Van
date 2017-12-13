using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_ServiceInfoMotorista : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ser"] != null)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["ser"].ToString()))
            {
                ServiceLoad(Convert.ToInt32(Request.QueryString["ser"].ToString()));
            }
        }
    }

    public void ServiceLoad(int par)
    {

        DataSet data = ser_servicosDB.SelectI(par);
        int qtd = data.Tables[0].Rows.Count;
        if (qtd != 0)
        {
            DataSet ds = ser_servicosDB.SelectInfoService(par);
            foreach (DataRow dados in ds.Tables[0].Rows)
            {

                LiteralInfo.Text = "<div class = 'row'>" +
                "<div class='col-lg-8'>" +
                "<div class='title'>" + dados["pes_nome"] + "</div>" +
                "<div class='serviceBox'>" +
                    "<div class='title'>Serviço</div>" +
                    "<div class='padding'>" +
                    "<b> Origem </b>: " + dados["ser_origem"] + "<br />" +
                    "<b> Destino </b>: " + dados["ser_destino"] + "<br />" +
                    "<b> Data de Partida </b>: " + dados["ser_datainicio"] + "<br />" +
                    "<b> Data de Retorno </b>: " + dados["ser_datafim"] + "<br />" +
                    "<b> Vagas Disponiveis </b>: " + dados["ser_lugares"] + "<br />" +
                    "<b> Descricao </b>: " + dados["ser_descricao"] + "<br />" +
                    "</div>" +
                "</div>" +

                "<div class='serviceBox'>" +
                    "<div class='title w3'>Motorista</div>" +
                    "<div class='padding'>" +
                    "<b> Nome </b>: " + dados["con_nome"] + "<br />" +
                    "<b> CPF </b>: " + dados["con_cpf"] + "<br />" +
                    "<b> Contato </b>: " + dados["tpc_descricao"] + " " + dados["ctp_descricao"] + "<br />" +
                "</div>" +
                "</div>" +

                "<div class='serviceBox'>" +
                    "<div class='title'>Veículo</div>" +
                    "<div class='padding'>" +
                        "<b> Tipo do Veiculo </b>: " + dados["tve_descricao"] + "<br />" +
                        "<b> Modelo </b>: " + dados["tra_modelo"] + "<br />" +
                        "<b> Placa </b>: " + dados["tra_placa"] + "<br />" +
                        "<b> Recursos </b>: " + dados["rec_descricao"] + "<br />" +
                    "</div>" +
                    "<p>Lugares Disponíveis: " + dados["tra_lugares"] + "</p>" +
                "</div>" +
                "</div>" +


                "<div class='col-lg-4'>" +
                "<div class='title'>Fotos do Veículo</div>" +
                "<div class='photoGallery mainPhoto'><img id='myImg' src='../pg/uploads/" + dados["img_foto"] + "' alt='Trolltunga, Norway' width='380px' height = '200px'>" +
                "</div>" +
                //"<div class='photoGallery mainPhoto'><img width='350px' src = '../pg/uploads/" + dados["img_foto"] + "'/></div>" +
                //"<div class='galleryField'>" +
                //    "<div class='photoGallery'></div>" +
                //    "<div class='photoGallery'></div>" +
                //    "<div class='photoGallery'></div>" +
                //"</div>" +
                "</div>" +
                "</div>";
            }
        }
        else
        {
            DataSet ds = ser_servicosDB.SelectInfoCon(par);
            foreach (DataRow dados in ds.Tables[0].Rows)
            {

                LiteralInfo.Text = "<div class = 'row'>" +
                "<div class='col-lg-8'>" +
                "<div class='title'>" + dados["pes_nome"] + "</div>" +
                "<div class='serviceBox'>" +
                    "<div class='title'>Serviço</div>" +
                    "<div class='padding'>" +
                    "<b> Origem </b>: " + dados["ser_origem"] + "<br />" +
                    "<b> Destino </b>: " + dados["ser_destino"] + "<br />" +
                    "<b> Data de Partida </b>: " + dados["ser_datainicio"] + "<br />" +
                    "<b> Data de Retorno </b>: " + dados["ser_datafim"] + "<br />" +
                    "<b> Vagas Disponiveis </b>: " + dados["ser_lugares"] + "<br />" +
                    "<b> Descricao </b>: " + dados["ser_descricao"] + "<br />" +
                    "</div>" +
                "</div>" +

                "<div class='serviceBox'>" +
                    "<div class='title w3'>Motorista</div>" +
                    "<div class='padding'>" +
                    "<b> Nome </b>: " + dados["pes_nome"] + "<br />" +
                    "<b> CNPJ </b>: " + dados["mot_cnpj"] + "<br />" +
                    "<b> Contato </b>: " + dados["tpc_descricao"] + " " + dados["mxc_descricao"] + "<br />" +

                "</div>" +
                "</div>" +

                "<div class='serviceBox'>" +
                    "<div class='title'>Veículo</div>" +
                    "<div class='padding'>" +
                        "<b> Tipo do Veiculo </b>: " + dados["tve_descricao"] + "<br />" +
                        "<b> Modelo </b>: " + dados["tra_modelo"] + "<br />" +
                        "<b> Placa </b>: " + dados["tra_placa"] + "<br />" +

                    "<b> Recursos </b>: " + dados["rec_descricao"] + "<br />" +

                    "</div>" +
                    "<p>Lugares Disponíveis: " + dados["tra_lugares"] + "</p>" +
                "</div>" +
                "</div>" +


                "<div class='col-lg-4'>" +
                "<div class='title'>Fotos do Veículo</div>" +
                "<div class='photoGallery mainPhoto'><img id='myImg' src='../pg/uploads/" + dados["img_foto"] + "' alt='Trolltunga, Norway' width='380px' height = '200px'>" +
                "</div>" +
                //"<div class='photoGallery mainPhoto'><img width='350px' src = '../pg/uploads/" + dados["img_foto"] + "'/></div>" +
                //"<div class='galleryField'>" +
                //    "<div class='photoGallery'></div>" +
                //    "<div class='photoGallery'></div>" +
                //    "<div class='photoGallery'></div>" +
                //"</div>" +
                "</div>" +
                "</div>";
            }
        }
    }
}