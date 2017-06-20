using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de int_interesse
/// </summary>
public class int_interesse
{
    private cli_cliente cli_id;
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

    public global::cli_cliente Cli_id
    {
        get
        {
            return cli_id;
        }

        set
        {
            cli_id = value;
        }
    }
}