using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de int_interesse
/// </summary>
public class int_interesse
{
    private pas_passageiro pas_id;
    private ser_servicos ser_id;

    public global::ser_servicos Ser_id
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

    public global::pas_passageiro Pas_id
    {
        get
        {
            return pas_id;
        }

        set
        {
            pas_id = value;
        }
    }
}