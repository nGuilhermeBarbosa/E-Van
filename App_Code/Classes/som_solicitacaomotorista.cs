using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class som_solicitacaomotorista
{

    private sol_solicitacao sol_id;
    private mot_motorista mot_id;
    private Double som_proposta;

    public sol_solicitacao Sol_id
    {
        get
        {
            return sol_id;
        }

        set
        {
            sol_id = value;
        }
    }

    public mot_motorista Mot_id
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

    public double Som_proposta
    {
        get
        {
            return som_proposta;
        }

        set
        {
            som_proposta = value;
        }
    }
}