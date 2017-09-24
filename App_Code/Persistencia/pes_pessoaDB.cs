using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de usu_usuarioDB
/// </summary>
public class pes_pessoaDB
{
    public static int Insert(pes_pessoa pes)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into pes_pessoa ";
            sql += "(pes_nome, pes_sexo, pes_nascimento, pes_cidade, pes_estado)";
            sql += "values ";
            sql += "(?pes_nome, ?pes_sexo, ?pes_nascimento, ?pes_cidade, ?pes_estado)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?pes_nome", pes.Pes_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_sexo", pes.Pes_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_nascimento", pes.Pes_nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_cidade", pes.Pes_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_estado", pes.Pes_estado));
            // Chave estrangeira


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

    public static DataSet SelectToDDL()
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select pes.pes_id, pes.pes_nome from pes_pessoa pes join usu_usuario usu on pes.pes_id = usu.pes_id where usu.usu_tipo = 'Administrador'";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

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
        string sql = "select * from pes_pessoa";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static void Delete(int id)
    {
        
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "delete from pes_pessoa where pes_id = ?pes_id";
            
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?pes_id", id));
            //retorno = Convert.ToInt32(objCommand.ExecuteScalar());
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        
    }

    public static int Update(pes_pessoa pes)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update pes_pessoa set pes_nome = ?pes_nome, pes_sexo = ?pes_sexo, pes_nascimento = ?pes_nascimento, pes_cidade = ?pes_cidade, pes_estado = ?pes_estado where pes_id = ?pes_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?pes_id", pes.Pes_id));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_nome", pes.Pes_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_sexo", pes.Pes_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_nascimento", pes.Pes_nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_cidade", pes.Pes_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?pes_estado", pes.Pes_estado));

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

    public static DataSet SelectByEmail(string nome)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select pes_id from pes_pessoa where pes_nome = ?pes_nome";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?pes_nome", nome));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
    public static DataSet SelectDados(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select pes.pes_id, pes.pes_nome, pes.pes_sexo, usu.usu_email, pes.pes_nascimento, pes.pes_estado, pes.pes_cidade from pes_pessoa pes inner join usu_usuario usu on usu.pes_id = pes.pes_id where pes.pes_id = ?id";
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