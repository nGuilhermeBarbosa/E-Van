using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ctp_condutor_tipo_contato
/// </summary>
public class ctp_condutor_tipo_contatoDB
{
    public static int Insert(ctp_condutor_tipo_contato ctp)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into  ctp_condutor_tipo_contato";
            sql += "(con_id, tpc_id, ctp_descricao)";
            sql += "values ";
            sql += "(?con_id, ?tpc_id, ?ctp_descricao)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?ctp_descricao", ctp.Ctp_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?con_id", ctp.Con_id.Con_id));
            objCommand.Parameters.Add(Mapped.Parameter("?tpc_id", ctp.Tpc_id.Tpc_id));

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
}