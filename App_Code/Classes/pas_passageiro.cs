using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for pas_pasente
/// </summary>
public class pas_passageiro
{
    private int pas_id;
    private string pas_cpf;
    private usu_usuario usu_id;

    public global::usu_usuario Usu_id
    {
        get { return usu_id; }
        set { usu_id = value; }
    }



    public string Pas_cpf
    {
        get { return pas_cpf; }
        set { pas_cpf = value; }
    }

    public int Pas_id
    {
        get { return pas_id; }
        set { pas_id = value; }
    }
    
}