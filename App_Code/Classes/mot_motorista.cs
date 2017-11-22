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
    private int mot_publicacoes;
    private usu_usuario usu_id;
    private tip_tipoconta tip_id;



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

    public int Mot_publicacoes
    {
        get
        {
            return mot_publicacoes;
        }

        set
        {
            mot_publicacoes = value;
        }
    }

    public tip_tipoconta Tip_id
    {
        get
        {
            return tip_id;
        }

        set
        {
            tip_id = value;
        }
    }
}

