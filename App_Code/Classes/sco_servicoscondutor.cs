using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de sco_servicoscondutor
/// </summary>
public class sco_servicoscondutor
{
    private int sco_id;
    private ser_servicos ser_id;
    private con_condutor con_id;

    public ser_servicos Ser_id
    {
        get
        {
            return ser_id;
        }

        set
        {
            ser_id = value;
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

    public int Sco_id
    {
        get
        {
            return sco_id;
        }

        set
        {
            sco_id = value;
        }
    }
}