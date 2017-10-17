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
    private DateTime sol_datainicio;
    private DateTime sol_datafim;
    private int sol_qtdpessoas;
    private string sol_descricao;
    private string sol_private;
    private pas_passageiro pas_id;

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

    public int Sol_qtdpessoas
    {
        get { return sol_qtdpessoas; }
        set { sol_qtdpessoas = value; }
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

    public DateTime Sol_datainicio
    {
        get
        {
            return sol_datainicio;
        }

        set
        {
            sol_datainicio = value;
        }
    }

    public DateTime Sol_datafim
    {
        get
        {
            return sol_datafim;
        }

        set
        {
            sol_datafim = value;
        }
    }

    public string Sol_descricao
    {
        get
        {
            return sol_descricao;
        }

        set
        {
            sol_descricao = value;
        }
    }

    public string Sol_private
    {
        get
        {
            return sol_private;
        }

        set
        {
            sol_private = value;
        }
    }
}