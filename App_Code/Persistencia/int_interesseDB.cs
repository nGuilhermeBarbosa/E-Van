using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class int_interesseDB
{
    public static int Insert(int_interesse inter)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into int_interesse ";
            sql += "(cli_id, ser_id)";
            sql += "values ";
            sql += "(?cli_id, ?ser_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?pas_id", inter.Pas_id.Pas_id));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", inter.Ser_id.Ser_id));

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

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select * from int_interesse";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
}