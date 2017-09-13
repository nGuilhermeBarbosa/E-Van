using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de pes_pessoa
/// </summary>
public class pes_pessoa
{
    private int pes_id;
    private string pes_nome;
    private string pes_sexo;
    private DateTime pes_nascimento;
    private string pes_cidade;
    private string pes_estado;


    public int Pes_id
    {
        get
        {
            return pes_id;
        }

        set
        {
            pes_id = value;
        }
    }

    public string Pes_nome
    {
        get
        {
            return pes_nome;
        }

        set
        {
            pes_nome = value;
        }
    }

    public string Pes_sexo
    {
        get
        {
            return pes_sexo;
        }

        set
        {
            pes_sexo = value;
        }
    }

    public DateTime Pes_nascimento
    {
        get
        {
            return pes_nascimento;
        }

        set
        {
            pes_nascimento = value;
        }
    }

    public string Pes_cidade
    {
        get
        {
            return pes_cidade;
        }

        set
        {
            pes_cidade = value;
        }
    }

    public string Pes_estado
    {
        get
        {
            return pes_estado;
        }

        set
        {
            pes_estado = value;
        }
    }
}