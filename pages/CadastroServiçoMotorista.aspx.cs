using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

public partial class pages_CadastroServiço : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                CarregarDDLT();
                CarregarDDL();
                CarregarDDLM();
            }
        }
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        hdf.Value = Session["value"].ToString();
        mot_motorista mot1 = new mot_motorista();

        DataSet codigo1 = new DataSet();

        codigo1 = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot1.Mot_id = Convert.ToInt32(codigo1.Tables[0].Rows[0][0]);

        int a1 = Convert.ToInt32(codigo1.Tables[0].Rows[0][0]);
        DataSet ds1 = mot_motoristaDB.SelectPETC(a1);
        foreach (DataRow dados1 in ds1.Tables[0].Rows)
            if (Convert.ToInt32(dados1["mot_publicacoes"]) >= 5 && Convert.ToString(dados1["tip_descricao"]) == "Free")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalLimite();", true);
            }
            else{

                if (Convert.ToDateTime(txtDataInicio.Text + " " + txtHoraPartida.Text) > Convert.ToDateTime(txtDataFim.Text + " " + txtHoraRetorno.Text))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSET();", true);
                }
                else if (Convert.ToDateTime(txtDataFim.Text + " " + txtHoraRetorno.Text) < DateTime.Now)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSETN();", true);
                }
                else
                {
                    DateTime data = DateTime.Now;

                    hdf.Value = Session["value"].ToString();

                    mot_motorista mot = new mot_motorista();

                    DataSet codigo = new DataSet();

                    codigo = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

                    mot.Mot_id = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                    int a = Convert.ToInt32(codigo.Tables[0].Rows[0][0]);

                    DataSet ds = mot_motoristaDB.SelectCon(a);
                    DataSet dsp = mot_motoristaDB.SelectPublicacoes(mot.Mot_id);

                    foreach (DataRow dados in dsp.Tables[0].Rows)
                    {
                        int publicacoes = Convert.ToInt32(dados["mot_publicacoes"]);
                        publicacoes++;
                        mot.Mot_publicacoes = publicacoes;
                        mot_motoristaDB.UpdatePublicacoes(mot);
                    }

                    int qtd = ds.Tables[0].Rows.Count;

                    ser_servicos serv = new ser_servicos();
                    con_condutor con = new con_condutor();
                    tra_transporte tra = new tra_transporte();
                    if (ddlTransporte.SelectedIndex != 0)
                    {
                        tra.Tra_id = Convert.ToInt32(ddlTransporte.SelectedValue);
                        serv.Tra_id = tra;
                        serv.Ser_datacadastro = data;
                        serv.Ser_origem = txtOrigem.Text;
                        serv.Ser_destino = txtDestino.Text;
                        serv.Ser_descricao = txtDescricao.Text;
                        serv.Ser_datafim = Convert.ToDateTime(txtDataFim.Text + " " + txtHoraRetorno.Text);
                        serv.Ser_datainicio = Convert.ToDateTime(txtDataInicio.Text + " " + txtHoraPartida.Text);
                        serv.Ser_lugares = Convert.ToInt32(txtLugares.Text);

                        serv.Mot_id = mot;
                        switch (ser_servicosDB.Insert(serv))
                        {
                            case 0:
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSS();", true);
                                //lblMsg.Text = "Cadastrado com sucesso";
                                break;
                            case -2:
                                //lblMsg.Text = "ERRO";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalSE();", true);
                                break;
                        }
                        string descricao = txtDescricao.Text;

                        DataSet id = new DataSet();

                        id = ser_servicosDB.SelectID(descricao);

                        serv.Ser_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                        sco_servicoscondutor sco = new sco_servicoscondutor();
                        if (ddlCondutor.SelectedIndex != 0)
                        {
                            con.Con_id = Convert.ToInt32(ddlCondutor.SelectedValue);
                            sco.Con_id = con;
                            sco.Ser_id = serv;
                            sco_servicoscondutorDB.Insert(sco);
                        }



                        txtOrigem.Text = "";
                        txtDestino.Text = "";
                        txtDataFim.Text = "";
                        txtDescricao.Text = "";
                        txtDataInicio.Text = "";
                        txtLugares.Text = "";
                        txtHoraPartida.Text = "";
                        txtHoraRetorno.Text = "";
                    }
                    else
                    {
                        Label3.Visible = true;
                    }

                }

            }

    }

        

    public void CarregarDDL()
    {
        DataSet ds = con_condutorDB.SelectAll();
        ddlCondutor.DataSource = ds;
        ddlCondutor.DataTextField = "con_nome";
        ddlCondutor.DataValueField = "con_id";
        ddlCondutor.DataBind();
        ddlCondutor.Items.Insert(0, "Selecione");
    }
    public void CarregarDDLT()
    {
        DataSet ds = tra_transporteDB.SelectAll();
        ddlTransporte.DataSource = ds;
        ddlTransporte.DataTextField = "tra_modelo";
        ddlTransporte.DataValueField = "tra_id";
        ddlTransporte.DataBind();
        ddlTransporte.Items.Insert(0, "Selecione");
    }
    public void CarregarDDLM()
    {
        DataSet ds = tve_tveoveiculoDB.SelectAll();
        ddlVeiculo.DataSource = ds;
        ddlVeiculo.DataTextField = "tve_descricao";
        ddlVeiculo.DataValueField = "tve_id";
        ddlVeiculo.DataBind();
        ddlVeiculo.Items.Insert(0, "Selecione");
    }


    protected void lbCadastrarVeiculo_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalCA();", true);
    }

    protected void btnCadastarModal_Click(object sender, EventArgs e)
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

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                            //Response.Write("<script>alert('Cadastrado com sucesso');</script>");
                            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                            

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

                            txtModelo.Text = "";
                            txtAno.Text = "";
                            txtLugar.Text = "";
                            txtPlaca.Text = "";
                            cb1.Checked = false;
                            cb2.Checked = false;
                            cb3.Checked = false;
                            cb4.Checked = false;
                            cb5.Checked = false;
                            cb6.Checked = false;

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
                            txtLugar.Text = "";
                            txtModelo.Text = "";

                            //pBefore.Visible = false;
                            //pAfter.Visible = true;
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

            CarregarDDLT();
        }
    }

    public bool erro() { return false; }
}