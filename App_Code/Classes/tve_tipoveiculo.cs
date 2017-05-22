using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tve_tipoveiculo
/// </summary>
public class tve_tipoveiculo
{
    private int tve_id;
    private string tve_descricao;

    public string Tve_descricao
    {
        get { return tve_descricao; }
        set { tve_descricao = value; }
    }

    public int Tve_id
    {
        get { return tve_id; }
        set { tve_id = value; }
    }
    
}