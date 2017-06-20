using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de con_conta
/// </summary>
public class con_conta
{
    private int con_id;
    private string con_tipo;

    public string Con_tipo
    {
        get
        {
            return con_tipo;
        }

        set
        {
            con_tipo = value;
        }
    }

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
}