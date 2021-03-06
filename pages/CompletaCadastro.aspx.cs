﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_CompletaCadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["nome"] != null)
            {
                Sessão usu = (Sessão)Session["nome"];
                hdf.Value = usu.id.ToString();
                DataSet ds = mxc_motorista_tipo_contatoDB.SelectAll(Convert.ToInt32(hdf.Value));
                int qtd = ds.Tables[0].Rows.Count;

                if (qtd != 0)
                {
                    pBefore.Visible = false;
                    pAfter.Visible = true;
                }
                else
                {
                    pBefore.Visible = true;
                    pAfter.Visible = false;
                }
                CarregarDDL();
            }
        }
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        hdf.Value = Session["value"].ToString();

        DataSet ds = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = Convert.ToInt32(ds.Tables[0].Rows[0]["mot_id"]);

        tpc_tipo_contato tpc = new tpc_tipo_contato();
        tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);


        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        if(ddl.SelectedIndex == 1)
        {
            mxc.Mxc_descricao = txtTelefone.Text;
        }else if(ddl.SelectedIndex == 2)
        {
            mxc.Mxc_descricao = txtCelular.Text;
        }else if(ddl.SelectedIndex == 3)
        {
            mxc.Mxc_descricao = txtWhatsapp.Text;
        }else if(ddl.SelectedIndex == 4)
        {
            mxc.Mxc_descricao = txtEmailAlt.Text;
        }
        
        mxc.Mot_id = mot;
        mxc.Tpc_id = tpc;
        mxc_motorista_tipo_contatoDB.Insert(mxc);

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

                            //Atualizar tipo de conta
                            if (rbMensal.Checked)
                            {
                                string kindOfPremium = "Premium M";
                                DataSet dsp = new DataSet();
                                tip_tipoconta tip = new tip_tipoconta();

                                dsp = tip_tipocontaDB.SelectID(kindOfPremium);
                                tip.Tip_id = Convert.ToInt32(dsp.Tables[0].Rows[0][0]);
                                mot.Tip_id = tip;
                                mot_motoristaDB.UpdatePremium(mot);
                            }
                            else if (rbAnual.Checked)
                            {
                                string kindOfPremium = "Premium A";
                                DataSet dsp = new DataSet();
                                tip_tipoconta tip = new tip_tipoconta();

                                dsp = tip_tipocontaDB.SelectID(kindOfPremium);
                                tip.Tip_id = Convert.ToInt32(dsp.Tables[0].Rows[0][0]);
                                mot.Tip_id = tip;
                                mot_motoristaDB.UpdatePremium(mot);
                            }

                            //Response.Write("<script>alert('Cadastrado com sucesso');</script>");
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalS();", true);
                            tdo_tipodocumento tdo = new tdo_tipodocumento();
                            tdo.Tdo_image = arq;
                            tdo_tipodocumentoDB.Insert(tdo);

                            string img = arq;
                            DataSet id = new DataSet();
                            id = tdo_tipodocumentoDB.SelectImage(img);
                            tdo.Tdo_id = Convert.ToInt32(id.Tables[0].Rows[0][0]);

                            doc_documento doc = new doc_documento();
                            doc.Mot_id = mot;
                            doc.Tdo_id = tdo;
                            doc_documentoDB.Insert(doc);

                            pBefore.Visible = false;
                            pAfter.Visible = true;
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
        DataSet ds = tpc_tipo_contatoDB.SelectAll();
        ddl.DataSource = ds;
        ddl.DataTextField = "tpc_descricao";
        ddl.DataValueField = "tpc_id";
        ddl.DataBind();
        ddl.Items.Insert(0, "Selecione");
    }



    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl.SelectedValue == 1.ToString())
        {
            txtTelefone.Visible = true;
            txtCelular.Visible = false;
            txtWhatsapp.Visible = false;
            txtEmailAlt.Visible = false;

            txtTelefone.Text = null;
            txtCelular.Text = null;
            txtWhatsapp.Text = null;
            txtEmailAlt.Text = null;
        }
        else if (ddl.SelectedValue == 2.ToString())
        {
            txtTelefone.Visible = false;
            txtCelular.Visible = true;
            txtWhatsapp.Visible = false;
            txtEmailAlt.Visible = false;

            txtTelefone.Text = null;
            txtCelular.Text = null;
            txtWhatsapp.Text = null;
            txtEmailAlt.Text = null;
        }
        else if(ddl.SelectedValue == 3.ToString())
        {
            txtTelefone.Visible = false;
            txtCelular.Visible = false;
            txtWhatsapp.Visible = true;
            txtEmailAlt.Visible = false;

            txtTelefone.Text = null;
            txtCelular.Text = null;
            txtWhatsapp.Text = null;
            txtEmailAlt.Text = null;
        }
        else if(ddl.SelectedValue == 4.ToString())
        {
            txtTelefone.Visible = false;
            txtCelular.Visible = false;
            txtWhatsapp.Visible = false;
            txtEmailAlt.Visible = true;

            txtTelefone.Text = null;
            txtCelular.Text = null;
            txtWhatsapp.Text = null;
            txtEmailAlt.Text = null;
        }
    }

    protected void cbFree_CheckedChanged(object sender, EventArgs e)
    {
        if (cbFree.Checked)
        {
            cbPremium.Checked = false;
            panelPremium.Visible = false;
            panelFree.Visible = true;
        }
    }

    protected void cbPremium_CheckedChanged(object sender, EventArgs e)
    {
        if (cbPremium.Checked)
        {
            cbFree.Checked = false;
            panelPremium.Visible = true;
            panelFree.Visible = false;
        }
    }

    protected void rbMensal_CheckedChanged(object sender, EventArgs e)
    {
        if (rbMensal.Checked)
        {
            rbAnual.Checked = false;
        }
    }

    protected void rbAnual_CheckedChanged(object sender, EventArgs e)
    {
        if (rbAnual.Checked)
        {
            rbMensal.Checked = false;
        }
    }
}