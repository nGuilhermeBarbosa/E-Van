using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for adm_administrador
/// </summary>
public class Adm_Administrador
{
    private int adm_id;
    private string adm_nome;
    private string adm_sexo;
    private string adm_nascimento;
    private string adm_cidade;
    private string adm_estado;
    private usu_usuario usu_id;

    public global:: usu_usuario Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }


    public string Adm_estado
    {
        get { return adm_estado; }
        set { adm_estado = value; }
    }

    public string Adm_cidade
    {
        get { return adm_cidade; }
        set { adm_cidade = value; }
    }

    public string Adm_nascimento
    {
        get { return adm_nascimento; }
        set { adm_nascimento = value; }
    }

    public string Adm_sexo
    {
        get { return adm_sexo; }
        set { adm_sexo = value; }
    }
     
    public string Adm_nome
    {
        get { return adm_nome; }
        set { adm_nome = value; }
    }

    public int Adm_id
    {
        get { return adm_id; }
        set { adm_id = value; }
    }
}