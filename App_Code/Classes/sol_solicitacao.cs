using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for sol_solicitacao
/// </summary>
public class sol_solicitacao
{
    private int sol_id;
    private string sol_origem;
    private string sol_destino;
    private string sol_data;
    private int sol_qtdpessoas;
    private cli_cliente cli_id;

    public global:: cli_cliente Cli_id
    {
        get { return cli_id; }
        set { cli_id = value; }
    }

    public int Sol_qtdpessoas
    {
        get { return sol_qtdpessoas; }
        set { sol_qtdpessoas = value; }
    }

    public string Sol_data
    {
        get { return sol_data; }
        set { sol_data = value; }
    }

    public string Sol_destino
    {
        get { return sol_destino; }
        set { sol_destino = value; }
    }
    

    public string Sol_origem
    {
        get { return sol_origem; }
        set { sol_origem = value; }
    }

    public int Sol_id
    {
        get { return sol_id; }
        set { sol_id = value; }
    }
}