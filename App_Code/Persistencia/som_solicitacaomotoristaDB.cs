using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de som_solicitacaomotoristaDB
/// </summary>
public class som_solicitacaomotoristaDB
{

    public static int Insert(som_solicitacaomotorista som)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into som_solicitacao_motorista ";
            sql += "(sol_id, mot_id, som_proposta)";
            sql += "values ";
            sql += "(?sol_id, ?mot_id, ?som_proposta)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?sol_id", som.Sol_id.Sol_id));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", som.Mot_id.Mot_id));
            objCommand.Parameters.Add(Mapped.Parameter("?som_proposta", som.Som_proposta));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        }
        catch (Exception)
        {
            //erro
            retorno = -2;
        }
        return retorno;
    }

    public static DataSet SelectProposta(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select som_proposta from som_solicitacao_motorista som inner join sol_solicitacao sol on sol.sol_id = som.sol_id inner join pas_passageiro pas on pas.pas_id = sol.sol_id where pas.pas_id = ?id; ";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }

    public static DataSet Select(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select * from pes_pessoa pes inner join usu_usuario usu on usu.pes_id = pes.pes_id inner join mot_motorista mot on mot.usu_id = usu.usu_id inner join som_solicitacao_motorista som on mot.mot_id = som.mot_id inner join sol_solicitacao sol on sol.sol_id = som.sol_id inner join pas_passageiro pas on pas.pas_id = sol.pas_id inner join mxc_motorista_tipo_contato mxc on mxc.mot_id = mot.mot_id inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id where pas.pas_id = 1; ";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
}