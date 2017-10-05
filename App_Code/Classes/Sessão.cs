using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Sessão
/// </summary>
public class Sessão
{
    public int id { get; set; }

    public string email { get; set; }

    public string nome { get; set; }

    public Sessão()
    {

    }

    public Sessão(int id, string email, string nome)
    {
        this.id = id;
        this.email = email;
        this.nome = nome;
        
    }

}