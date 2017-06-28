using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de adm_administradorDB
/// </summary>
public class adm_administradorDB
{
    public static int Insert(Adm_Administrador adm)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into adm_administrador ";
            sql += "(adm_nome, adm_sexo, adm_nascimento, adm_estado, adm_cidade, usu_id)";
            sql += "values ";
            sql += "(?adm_nome, ?adm_sexo, ?adm_nascimento, ?adm_estado, ?adm_cidade, ?usu_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?adm_nome", adm.Adm_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?adm_sexo", adm.Adm_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?adm_nascimento", adm.Adm_nascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?adm_estado", adm.Adm_estado));
            objCommand.Parameters.Add(Mapped.Parameter("?adm_cidade", adm.Adm_cidade));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", adm.Usu_id.Usu_id));

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
        string sql = "select * from adm_administrador";

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
            string sql = "delete from adm_administrador where adm_id = ?adm_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?adm_id", id));

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
    public static int Update(Adm_Administrador adm)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update adm_administrador set adm_nome = ?adm_nome, adm_sexo = ?adm_sexo, adm_datanascimento = ?adm_datanascimento, adm_cidade = ?adm_cidade, adm_estado = ?adm_estado, adm_cpf = ?adm_cpf where adm_id = ?adm_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?adm_nome", adm.Adm_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_sexo", adm.Adm_sexo));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_estado", adm.Adm_cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_nome", adm.Adm_estado));
            

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