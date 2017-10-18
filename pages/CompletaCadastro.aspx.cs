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
                //lblSessao.Text = usu.email;
                hdf.Value = usu.id.ToString();
                CarregarDDL();
            }
        }
    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        DataSet ds = mot_motoristaDB.SelectID(Convert.ToInt32(hdf.Value));

        mot_motorista mot = new mot_motorista();
        mot.Mot_id = Convert.ToInt32(ds.Tables[0].Rows[0]["mot_id"]);

        tpc_tipo_contato tpc = new tpc_tipo_contato();
        tpc.Tpc_id = Convert.ToInt32(ddl.SelectedValue);
        //tpc.Tpc_descricao = ddl.SelectedItem.Text;
        //tpc_tipo_contatoDB.Insert(tpc);

        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        mxc.Mxc_descricao = txtTelefone.Text;
        mxc.Mot_id = mot;
        mxc.Tpc_id = tpc;
        mxc_motorista_tipo_contatoDB.Insert(mxc);
        //switch (mxc_motorista_tipo_contatoDB.Insert(mxc))
        //{
        //    case 0:
        //        Response.Write("<script>alert('Cadastrado com Sucesso');</script>");
        //        break;
        //    case -2:
        //        Response.Write("<script>alert('ERRO');</script>");
        //        break;
        //}

        string dir = Request.PhysicalApplicationPath + "pg\\uploads\\";

        if (!Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

        foreach (HttpPostedFile flp in fup.PostedFiles)
        {

            try
            {
                double mp = 2000;

                if (fup.HasFile)
                {

                    string arq = Path.GetFileName(flp.FileName); string ext = Path.GetExtension(flp.FileName);
                    ext = ext.ToLower(); double ta = flp.ContentLength / 1024;

                    if (ext == ".jpg" || ext == ".png" || ext == ".gif")
                    {
                        if (ta <= mp)
                        {
                            arq = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ext; if (!File.Exists(dir + arq))
                            {
                                flp.SaveAs(dir + arq);

                                System.Drawing.Image imgOriginal = System.Drawing.Image.FromFile(Server.MapPath("~/pg/up loads/" + arq), true);

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

                                //nova imagem gerada string novo_nome = arq.Substring(0, arq.Length - 4) + "-mini.png"; 

                                //salve a miniatura em um formato imgRedimensionada.Save(dir + novo_nome, System.Drawing.Imaging.ImageFormat.Png); 

                                imgRedimensionada.Dispose();

                                imgOriginal.Dispose();

                                //visualize a original e a redimensionada                             //File.Delete(Server.MapPath("~/Uploads/" +       Path.GetFileName(flp.FileName))); 
                                Response.Write("<script>alert('Imagem gravada com sucesso');</script>");
                            }
                            else
                            {
                                Response.Write("<script>alert('Arquivo ja existe');</script>");

                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Tamanho maximo excedido - 500KB');</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Extensão invalida');</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Selecione um arquivo');</script>");
                }

            }
            catch
            {
                Response.Write("<script>alert('Erro no upload');</script>");
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
}