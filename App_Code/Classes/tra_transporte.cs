using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tra_transporte
/// </summary>
public class tra_transporte
{
    private int tra_id;
    private int tra_lugares;
    private string tra_modelo;
    private int tra_ano;
    private string tra_placa;
    private tve_tipoveiculo tve_id;
    

    public global:: tve_tipoveiculo Tve_id
    {
        get { return tve_id; }
        set { tve_id = value; }
    }

    public int Tra_lugares
    {
        get { return tra_lugares; }
        set { tra_lugares = value; }
    }

    public int Tra_id
    {
        get { return tra_id; }
        set { tra_id = value; }
    }

    public string Tra_modelo
    {
        get
        {
            return tra_modelo;
        }

        set
        {
            tra_modelo = value;
        }
    }

    public int Tra_ano
    {
        get
        {
            return tra_ano;
        }

        set
        {
            tra_ano = value;
        }
    }

    public string Tra_placa
    {
        get
        {
            return tra_placa;
        }

        set
        {
            tra_placa = value;
        }
    }
}