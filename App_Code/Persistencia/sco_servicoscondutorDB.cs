using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de sco_servicoscondutorDB
/// </summary>
public class sco_servicoscondutorDB
{
    public static int Insert(sco_servicoscondutor sco)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into sco_servicoscondutor ";
            sql += "(ser_id, con_id)";
            sql += "values ";
            sql += "(?ser_id, ?con_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", sco.Ser_id.Ser_id));
            objCommand.Parameters.Add(Mapped.Parameter("?con_id", sco.Con_id.Con_id));

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