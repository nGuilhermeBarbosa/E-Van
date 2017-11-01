using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de con_condutor
/// </summary>
public class con_condutor
{
    private int con_id;
    private string con_nome;
    private string con_cpf;
    private mot_motorista mot_id;

    public int Con_id
    {
        get
        {
            return con_id;
        }

        set
        {
            con_id = value;
        }
    }

    public string Con_nome
    {
        get
        {
            return con_nome;
        }

        set
        {
            con_nome = value;
        }
    }

    public string Con_cpf
    {
        get
        {
            return con_cpf;
        }

        set
        {
            con_cpf = value;
        }
    }

    public global::mot_motorista Mot_id
    {
        get
        {
            return mot_id;
        }

        set
        {
            mot_id = value;
        }
    }
}