using System;
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


        mxc_motorista_tipo_contato mxc = new mxc_motorista_tipo_contato();
        mxc.Mxc_descricao = txtTelefone.Text;
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


}