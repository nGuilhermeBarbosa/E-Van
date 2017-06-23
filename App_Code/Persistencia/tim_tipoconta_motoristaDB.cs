using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class tim_tipoconta_motoristaDB
{
    public static int Insert(tim_tipoconta_motorista tim)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into tim_tipoconta_motorista";
            sql += "(mot_id, tip_id, tim_datainicio, tim_fim)";
            sql += "values ";
            sql += "(?mot_id, ?tip_id, ?tim_datainicio, ?tim_fim)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tim_datainicio", tim.Tim_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?doc_datafim", tim.Tim_datafim));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", tim.Mot_id.Mot_id));
            objCommand.Parameters.Add(Mapped.Parameter("?tip_id", tim.Tip_id.Tip_id));

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
        string sql = "select * from tim_tipoconta_motorista";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
    public static int Update(tim_tipoconta_motorista tim)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update tim_tipoconta_motorista set tim_datainicio = ?tim_datafim, tim_datainicio = ?tim_datainicio";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("tim_datainicio", tim.Tim_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("tim_datafim", tim.Tim_datafim));

            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", tim.Mot_id.Mot_id));
            objCommand.Parameters.Add(Mapped.Parameter("?tip_id", tim.Tip_id.Tip_id));

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