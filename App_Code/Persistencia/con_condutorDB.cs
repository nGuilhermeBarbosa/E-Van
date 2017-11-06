using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de con_condutorDB
/// </summary>
public class con_condutorDB
{
    public static int Insert(con_condutor con)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into con_condutor ";
            sql += "(con_nome, con_cpf, mot_id)";
            sql += "values ";
            sql += "(?con_nome, ?con_cpf, ?mot_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?con_nome", con.Con_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?con_cpf", con.Con_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", con.Mot_id.Mot_id));

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