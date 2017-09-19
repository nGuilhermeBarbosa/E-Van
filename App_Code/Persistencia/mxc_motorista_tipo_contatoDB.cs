using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class mxc_motorista_tipo_contatoDB
{
    public static int Insert(mxc_motorista_tipo_contato mxc)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into  mxc_motorista_tipo_contato";
            sql += "(mot_id, tpc_id, mxc_descricao)";
            sql += "values ";
            sql += "(?mot_id, ?tpc_id, ?mxc_descricao)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?mxc_descricao", mxc.Mxc_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", mxc.Mot_id.Mot_id));
            objCommand.Parameters.Add(Mapped.Parameter("?tpc_id", mxc.Tpc_id.Tpc_id));

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
        string sql = "select * from mxc_motorista_tipo_contato";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
    public static int Update(mxc_motorista_tipo_contato mxc)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update mxc_motorista set mxc_descricao where usu_id = ?usu_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?mxc_descricao", mxc.Mxc_descricao));
            //objCommand.Parameters.Add(Mapped.Parameter("?usu_tipo", usu.Usu_tipo));
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