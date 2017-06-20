using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de mxc_motorista_tipo_contato
/// </summary>
public class mxc_motorista_tipo_contato
{
    private mot_motorista mot_id;
    private tpc_tipo_contato tpc_id;

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

    public global::tpc_tipo_contato Tpc_id
    {
        get
        {
            return tpc_id;
        }

        set
        {
            tpc_id = value;
        }
    }
}