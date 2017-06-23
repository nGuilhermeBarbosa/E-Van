using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class doc_documento
{
    private mot_motorista mot_id;
    private tdo_tipodocumento tdo_id;
    private string doc_image;

    public string Doc_image
    {
        get
        {
            return doc_image;
        }

        set
        {
            doc_image = value;
        }
    }

    public global::tdo_tipodocumento Tdo_id
    {
        get
        {
            return tdo_id;
        }

        set
        {
            tdo_id = value;
        }
    }

    public global::mot_motorista Mot_id
    {
        get
        {
            return mot_id;
        }

        set
        {
            mot_id = value;
        }
    }
}