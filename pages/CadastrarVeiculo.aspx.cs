using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_CadastrarVeiculo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                CarregarDDL();
                
            }
        }
    }



    protected void btnCadastrar_Click(object sender, EventArgs e)
    {

        hdf.Value = Session["value"].ToString();

        string dir = Request.PhysicalApplicationPath + "pg\\uploads\\";

        if (!Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

        foreach (HttpPostedFile flp in fup.PostedFiles)
        {


            double mp = 2000;

            if (fup.HasFile)
            {

                string arq = Path.GetFileName(flp.FileName);
                string ext = Path.GetExtension(flp.FileName);
                ext = ext.ToLower();
                double ta = flp.ContentLength / 1024;

                if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                {
                    if (ta <= mp)
                    {
                        arq = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ext;
                        if (!File.Exists(dir + arq))
                        {
                            flp.SaveAs(dir + arq);

                            System.Drawing.Image imgOriginal = System.Drawing.Image.FromFile(Server.MapPath("~/pg/uploads/" + arq), true);

                            System.Drawing.Image.GetThumbnailImageAbort miniatura = new System.Drawing.Image.GetThumbnailImageAbort(erro);

                            System.Drawing.Image imgRedimensionada;

                            int width, height;

                            if (imgOriginal.Width > 200)
                            {

                                width = 200; height = (int)(width * imgOriginal.Height) / imgOriginal.Width;

                            }
                            else
                            {

                                width = imgOriginal.Width; height = imgOriginal.Height;
                            }

                            imgRedimensionada = imgOriginal.GetThumbnailImage(width, height, miniatura, IntPtr.Zero);


                            imgRedimensionada.Dispose();

                            imgOriginal.Dispose();

                            
                            tve_tipoveiculo tve = new tve_tipoveiculo();
                            tve.Tve_id = Convert.ToInt32(ddlVeiculo.SelectedValue);

                            tra_transporte tra = new tra_transporte();
                            tra.Tra_lugares = Convert.ToInt32(txtLugar.Text);
                            tra.Tra_modelo = txtModelo.Text;
                            tra.Tra_ano = Convert.ToInt32(txtAno.Text);
                            tra.Tra_placa = txtPlaca.Text;
                            tra.Tve_id = tve;
                            string placa = txtPlaca.Text;
                            tra_transporteDB.Insert(tra);


                            DataSet codigo = new DataSet();
                            codigo = tra_transporteDB.SelectLugar(placa);
                            tra.Tra_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                            img_imagemveiculo img = new img_imagemveiculo();
                            img.Img_foto = arq;
                            img.Tra_id = tra;
                            img_imagemveiculoDB.Insert(img);

                            DataSet idMot = new DataSet();
                            idMot = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

                            mot_motorista mot = new mot_motorista();
                            mot.Mot_id = Convert.ToInt32(idMot.Tables[0].Rows[0][0]);

                            txm_transporte_motorista txm = new txm_transporte_motorista();
                            txm.Mot_id = mot;
                            txm.Tra_id = tra;

                            txm_transporte_motoristaDB.Insert(txm);

                            if (cb1.Checked)
                            {

                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 1;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                            if (cb2.Checked)
                            {
                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 2;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                            if (cb3.Checked)
                            {
                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 3;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                            if (cb4.Checked)
                            {
                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 4;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                            if (cb5.Checked)
                            {
                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 5;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                            if (cb6.Checked)
                            {
                                rec_recursos rec = new rec_recursos();
                                rec.Rec_id = 6;

                                txr_transporte_recursos txr = new txr_transporte_recursos();
                                txr.Tra_id = tra;
                                txr.Rec_id = rec;

                                txr_transporte_recursosDB.Insert(txr);
                            }
                        }
                        else
                        {
                            //Response.Write("<script>alert('Arquivo ja existe');</script>");
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalF();", true);

                        }
                    }
                    else
                    {
                        //Response.Write("<script>alert('Tamanho maximo excedido - 500KB');</script>");
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalMS();", true);
                    }
                }
                else
                {
                    //Response.Write("<script>alert('Extensão invalida');</script>");
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalEI();", true);
                }

            }
            else
            {
                //Response.Write("<script>alert('Selecione um arquivo');</script>");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSl();", true);
            }


        }



    }



    public bool erro() { return false; }

    public void CarregarDDL()
    {
        DataSet ds = tve_tveoveiculoDB.SelectAll();
        ddlVeiculo.DataSource = ds;
        ddlVeiculo.DataTextField = "tve_descricao";
        ddlVeiculo.DataValueField = "tve_id";
        ddlVeiculo.DataBind();
        ddlVeiculo.Items.Insert(0, "Selecione");
    }
    
}
