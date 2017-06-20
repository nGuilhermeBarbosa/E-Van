using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de utp_usuario_tipoconta
/// </summary>
public class utp_usuario_tipoconta
{
    private usu_usuario usu_id;
    private tip_tipoconta tip_id;
    private string utp_datainicio;
    private string utp_datafim;

    public string Utp_datafim
    {
        get
        {
            return utp_datafim;
        }

        set
        {
            utp_datafim = value;
        }
    }

    public string Utp_datainicio
    {
        get
        {
            return utp_datainicio;
        }

        set
        {
            utp_datainicio = value;
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

    public global::usu_usuario Usu_id
    {
        get
        {
            return usu_id;
        }

        set
        {
            usu_id = value;
        }
    }
}