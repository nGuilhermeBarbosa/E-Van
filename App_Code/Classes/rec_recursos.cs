using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for rec_recursos
/// </summary>
public class rec_recursos
{
    private int rec_id;
    private string rec_descricao;

    public string Rec_descricao
    {
        get { return rec_descricao; }
        set { rec_descricao = value; }
    }

    public int Rec_id
    {
        get { return rec_id; }
        set { rec_id = value; }
    }
    
}