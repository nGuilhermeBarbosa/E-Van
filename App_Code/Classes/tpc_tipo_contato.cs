using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tpc_tipo_contato
/// </summary>
public class tpc_tipo_contato
{
    private int tpc_id;
    private string tpc_descricao;

    public string Tpc_descricao
    {
        get { return tpc_descricao; }
        set { tpc_descricao = value; }
    }

    public int Tpc_id
    {
        get { return tpc_id; }
        set { tpc_id = value; }
    }
    
}