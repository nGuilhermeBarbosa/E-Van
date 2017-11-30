using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de img_imagemveiculo
/// </summary>
public class img_imagemveiculo
{
    private int img_id;
    private string img_foto;
    private tra_transporte tra_id;

    public int Img_id
    {
        get
        {
            return img_id;
        }

        set
        {
            img_id = value;
        }
    }

    public string Img_foto
    {
        get
        {
            return img_foto;
        }

        set
        {
            img_foto = value;
        }
    }

    public global::tra_transporte Tra_id
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
}