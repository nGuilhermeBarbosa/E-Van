using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de cli_clienteDB
/// </summary>
public class cli_clienteDB
{
    public static int Insert(cli_cliente cli)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into cli_cliente ";
            sql += "(cli_nome, cli_sexo, cli_datanascimento, cli_cidade, cli_estado, cli_cpf, cli_idade, usu_id)";
            sql += "values ";
            sql += "(?cli_nome, ?cli_sexo, ?cli_datanascimento, ?cli_cidade, ?cli_estado, ?cli_cpf, ?cli_idade, ?usu_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?cli_nome", cli.Cli_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", cli.Cli_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_cidade", cli.Cli_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_estado", cli.Cli_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_nome", cli.Cli_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", cli.Cli_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_cidade", cli.Cli_idade));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", cli.Usu_id.Usu_id));

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
        string sql = "select * from cli_cliente";

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
            string sql = "delete from cli_cliente where cli_id = ?cli_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", id));

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
    public static int Update(cli_cliente cli)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update cli_cliente set cli_nome = ?cli_nome, cli_cpf = ?cli_cpf, cli_sexo = ?cli_sexo, cli_datanascimento = ?cli_datanascimento, cli_cidade = ?cli_cidade, cli_estado = ?cli_estado, cli_idade = ?cli_idade where cli_id = ?cli_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?cli_nome", cli.Cli_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", cli.Cli_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_cidade", cli.Cli_datanascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_estado", cli.Cli_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_nome", cli.Cli_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", cli.Cli_cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_cidade", cli.Cli_idade));

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