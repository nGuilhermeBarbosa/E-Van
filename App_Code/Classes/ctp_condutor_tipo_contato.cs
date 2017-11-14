using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ctp_condutor_tipo_contato
/// </summary>
public class ctp_condutor_tipo_contato
{

    private int ctp_id;
    private con_condutor con_id;
    private tpc_tipo_contato tpc_id;
    private string ctp_descricao;

    public int Ctp_id
    {
        get
        {
            return ctp_id;
        }

        set
        {
            ctp_id = value;
        }
    }

    public con_condutor Con_id
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

    public tpc_tipo_contato Tpc_id
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

    public string Ctp_descricao
    {
        get
        {
            return ctp_descricao;
        }

        set
        {
            ctp_descricao = value;
        }
    }
}