﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for usu_usuario
/// </summary>
public class usu_usuario
{
    private int usu_id;
    private string usu_email;
    private string usu_senha;
    private string usu_tipo;
    private Boolean usu_status;
    private pes_pessoa pes_id;

    public int Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }
    

    public string Usu_email
    {
        get { return usu_email; }
        set { usu_email = value; }
    }
    

    public string Usu_senha
    {
        get { return usu_senha; }
        set { usu_senha = value; }
    }

    public string Usu_tipo
    {
        get
        {
            return usu_tipo;
        }

        set
        {
            usu_tipo = value;
        }
    }

    public global::pes_pessoa Pes_id
    {
        get
        {
            return pes_id;
        }

        set
        {
            pes_id = value;
        }
    }

    public bool Usu_status
    {
        get
        {
            return usu_status;
        }

        set
        {
            usu_status = value;
        }
    }
}