using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ser_servicos
/// </summary>
public class ser_servicos
{
	private int ser_id;
    private DateTime ser_datacadastro;
    //private string ser_nome;
    private DateTime ser_datafim;
    private string ser_origem;
    private DateTime ser_datainicio;
    private string ser_destino;
    private string ser_descricao;
    private int ser_lugares;
    private mot_motorista mot_id;
    private tra_transporte tra_id;
    private con_condutor con_id;
    

    public string Ser_descricao
    {
        get { return ser_descricao; }
        set { ser_descricao = value; }
    }
   

    public int Ser_lugares
    {
        get { return ser_lugares; }
        set { ser_lugares = value; }
    }
    

    public global:: mot_motorista Mot_id
    {
        get { return mot_id; }
        set { mot_id = value; }
    }

    public string Ser_destino
    {
        get { return ser_destino; }
        set { ser_destino = value; }
    }

    public DateTime Ser_datacadastro
    {
        get { return ser_datacadastro; }
        set { ser_datacadastro = value; }
    }
    

    //public string Ser_nome
    //{
    //    get { return ser_nome; }
    //    set { ser_nome = value; }
    //}
    

    public DateTime Ser_datainicio
    {
        get { return ser_datainicio; }
        set { ser_datainicio = value; }
    }
    

    public DateTime Ser_datafim
    {
        get { return ser_datafim; }
        set { ser_datafim = value; }
    }
    

    public string Ser_origem
    {
        get { return ser_origem; }
        set { ser_origem = value; }
    }


    public int Ser_id
    {
        get { return ser_id; }
        set { ser_id = value; }
    }

    public tra_transporte Tra_id
    {
        get
        {
            return tra_id;
        }

        set
        {
            tra_id = value;
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
}