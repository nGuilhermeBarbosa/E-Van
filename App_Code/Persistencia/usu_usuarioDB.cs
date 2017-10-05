using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de usu_usuarioDB
/// </summary>
public class usu_usuarioDB
{
    public static int Insert(usu_usuario usu)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into usu_usuario ";
            sql += "(usu_email, usu_senha, usu_tipo, pes_id)";
            sql += "values ";
            sql += "(?usu_email, ?usu_senha, ?usu_tipo, ?pes_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", usu.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", usu.Usu_senha));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_tipo", usu.Usu_tipo));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?pes_id", usu.Pes_id.Pes_id));

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
        string sql = "select * from usu_usuario";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static DataSet SelectAdm()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select pes_nome, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_tipo from pes_pessoa pes inner join usu_usuario usu on usu.pes_id = pes.pes_id where usu_tipo = 'Administrador'";

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
            string sql = "delete from usu_usuario where pes_id = ?pes_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?pes_id", id));

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

    public static DataSet SelectLOGIN(usu_usuario usu)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select usu_id, usu_email, usu_senha, usu_tipo, pes_nome from usu_usuario usu inner join pes_pessoa pes on pes.pes_id = usu.pes_id where usu_email = ?usu_email and usu_senha = ?usu_senha";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?usu_email", usu.Usu_email));
        objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", usu.Usu_senha));

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static void Update(usu_usuario usu)
    {
        
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update usu_usuario set usu_email = ?usu_email, usu_senha = " +
                "?usu_senha where usu_id = ?usu_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", usu.Usu_id));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_email", usu.Usu_email));
            objCommand.Parameters.Add(Mapped.Parameter("?usu_senha", usu.Usu_senha));
            //objCommand.Parameters.Add(Mapped.Parameter("?usu_tipo", usu.Usu_tipo));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
    }
   /* public static DataSet SelectByEmailMoto(string email)
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
    }*/

    public static DataSet SelectLast(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select cli_id, cli_nome, cli_cnpj, cli_sexo, cli_cidade, usu_email, cli_cidade, cli_estado from usu_usuario usu inner join cli_cliente cli on usu.usu_id = cli.cli_id where mot_id = ?id;";
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