using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de utp_usuario_tipoconta
/// </summary>
public class tim_tipoconta_motorista
{
    private mot_motorista mot_id;
    private tip_tipoconta tip_id;
    private string tim_datainicio;
    private string tim_datafim;

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

    public global::tip_tipoconta Tip_id
    {
        get
        {
            return tip_id;
        }

        set
        {
            tip_id = value;
        }
    }

    public string Tim_datainicio
    {
        get
        {
            return tim_datainicio;
        }

        set
        {
            tim_datainicio = value;
        }
    }

    public string Tim_datafim
    {
        get
        {
            return tim_datafim;
        }

        set
        {
            tim_datafim = value;
        }
    }
}