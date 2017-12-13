using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for sol_solicitacaoDB
/// </summary>
public class sol_solicitacaoDB
{
    public static int Insert(sol_solicitacao sol)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into sol_solicitacao ";
            sql += "(sol_origem, sol_destino, sol_datainicio, sol_datafim, sol_qtdpessoas, sol_descricao, sol_private, pas_id)";
            sql += "values ";
            sql += "(?sol_origem, ?sol_destino, ?sol_datainicio, ?sol_datafim, ?sol_qtdpessoas, ?sol_descricao, ?sol_private, ?pas_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?sol_origem", sol.Sol_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_destino", sol.Sol_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_datainicio", sol.Sol_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_datafim", sol.Sol_datafim));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_qtdpessoas", sol.Sol_qtdpessoas));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_descricao", sol.Sol_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_private", sol.Sol_private));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?pas_id", sol.Pas_id.Pas_id));

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

    public static DataSet SelectDados(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select * from sol_solicitacao where sol_id = ?id;";
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
        string query = "select * from pes_pessoa pes inner join usu_usuario usu on usu.pes_id = pes.pes_id inner join mot_motorista mot on mot.usu_id = usu.usu_id inner join som_solicitacao_motorista som on mot.mot_id = som.mot_id inner join sol_solicitacao sol on sol.sol_id = som.sol_id inner join pas_passageiro pas on pas.pas_id = sol.pas_id where pas.pas_id = ?id; ";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }

    public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select * from sol_solicitacao";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static DataSet SelectModal(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select * from sol_solicitacao where sol_id = ?id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?sol_id", id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }


    public static DataSet Select()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select sol_id, pes_nome, sol_origem, sol_destino, sol_datainicio, sol_datafim from pes_pessoa pes inner join usu_usuario usu on pes.pes_id = usu.pes_id inner join pas_passageiro pas on pas.usu_id = usu.usu_id inner join sol_solicitacao sol on sol.pas_id = pas.pas_id";

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
            string sql = "delete from sol_solicitacao where sol_id = ?sol_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?sol_id", id));

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
    public static DataSet SelectByEmail(string email)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select usu_id from usu_usuario where usu_email = ?usu_email";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?usu_email", email));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
}