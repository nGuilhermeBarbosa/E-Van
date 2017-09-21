using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class tpc_tipo_contatoDB
{
    public static int Insert(tpc_tipo_contato tpc)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into tpc_tipo_contato ";
            sql += "(tpc_descricao)";
            sql += "values ";
            sql += "(?tpc_descricao)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tpc_descricao", tpc.Tpc_descricao));


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
        string sql = "select * from tpc_tipo_contato";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static int Delete(int id)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "delete from tpc_tipo_contato where tpc_id = ?tpc_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?tpc_id", id));


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
    public static void Update(tpc_tipo_contato tpc)
    {

        //Correto
        IDbConnection objConexao; //Abrir a conexão
        IDbCommand objCommand; // Criar e executar os comandos
        string sql = "update tpc_tipo_contato set tpc_descricao = ?tpc_descricao where tpc_id = ?tpc_id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("tpc_id", tpc.Tpc_id));
        objCommand.Parameters.Add(Mapped.Parameter("tpc_descricao", tpc.Tpc_descricao));

        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

    }
}