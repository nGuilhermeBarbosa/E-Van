using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de txm_transporte_motorista
/// </summary>
public class txm_transporte_motorista
{
    private mot_motorista mot_id;
    private tra_transporte tra_id;

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