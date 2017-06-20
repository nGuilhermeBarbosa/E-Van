using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de txr_transporte_recursos
/// </summary>
public class txr_transporte_recursos
{
    private tra_transporte tra_id;
    private rec_recursos rec_id;

    public global::rec_recursos Rec_id
    {
        get
        {
            return rec_id;
        }

        set
        {
            rec_id = value;
        }
    }

    public global::tra_transporte Tra_id
    {
        get
        {
            return tra_id;
        }

        set
        {
            tra_id = value;
        }
    }
}