using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for tdo_tipodocumento
/// </summary>
public class tdo_tipodocumento
{
    private int tdo_id;
    private int tdo_obrigatorio;
    private string tdo_image;

    public string Tdo_image
    {
        get { return tdo_image; }
        set { tdo_image = value; }
    }


    public int Tdo_id
    {
        get { return tdo_id; }
        set { tdo_id = value; }
    }
}