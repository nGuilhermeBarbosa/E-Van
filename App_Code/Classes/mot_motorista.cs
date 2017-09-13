using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for mot_motorista
/// </summary>
public class mot_motorista
{
    private int mot_id;
    private string mot_cnpj;
    private usu_usuario usu_id;



    public string Mot_cnpj
    {
        get { return mot_cnpj; }
        set { mot_cnpj = value; }
    }

    public int Mot_id
    {
        get { return mot_id; }
        set { mot_id = value; }
    }
    public global::usu_usuario Usu_id
    {
        get
        {
            return usu_id;
        }

        set
        {
            usu_id = value;
        }
    }
}

