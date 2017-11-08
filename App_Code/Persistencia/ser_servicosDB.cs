using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de adm_administradorDB
/// </summary>
public class ser_servicosDB
{
    public static int Insert(ser_servicos ser)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into ser_servicos ";
            sql += "(ser_datacadastro, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, mot_id)";
            sql += "values ";
            sql += "(?ser_datacadastro, ?ser_datainicio, ?ser_datafim, ?ser_origem, ?ser_destino, ?ser_descricao, ?ser_lugares, ?mot_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?ser_datacadastro", ser.Ser_datacadastro));
            //objCommand.Parameters.Add(Mapped.Parameter("?ser_nome", ser.Ser_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datainicio", ser.Ser_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datafim", ser.Ser_datafim));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_origem", ser.Ser_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_destino", ser.Ser_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_descricao", ser.Ser_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_lugares", ser.Ser_lugares));

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", ser.Mot_id.Mot_id));


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
        string sql = "select ser_id, ser_origem, pes_nome, ser_datainicio, ser_lugares, ser_datafim, ser_destino, ser_descricao from ser_servicos ser inner join mot_motorista mot on mot.mot_id = ser.mot_id inner join usu_usuario usu on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id";

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
            string sql = "delete from ser_servicos where ser_id = ?id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?id", id));

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
    public static int Update(ser_servicos ser)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update ser_servicos set ser_datacadastro = ?ser_datacadastro, ser_datafim = ?ser_datafim, ser_origem = ?ser_origem, ser_datainicio = ?ser_datainicio, ser_destino = ?ser_destino, ser_descricao = ?ser_descricao, ser_lugares = ?ser_lugares where ser_id = ?ser_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", ser.Ser_id));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datacadastro", ser.Ser_datacadastro));
            //objCommand.Parameters.Add(Mapped.Parameter("?ser_nome", ser.Ser_nome));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datafim", ser.Ser_datafim));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_origem", ser.Ser_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_datainicio", ser.Ser_datainicio));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_destino", ser.Ser_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_descricao", ser.Ser_descricao));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_lugares", ser.Ser_lugares));

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

    public static DataSet SelectServicos(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select ser_id, pes_nome, ser_origem, ser_datainicio, ser_datafim, ser_destino, ser_descricao from ser_servicos ser inner join mot_motorista mot on mot.mot_id = ser.mot_id inner join usu_usuario usu on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id where ser.mot_id = ?id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?id", id));

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
    public static DataSet SelectSer(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select ser_id from ser_servicos ser inner join mot_motorista mot on mot.mot_id = ser.mot_id inner join usu_usuario usu on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id where ser.mot_id = ?id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?id", id));

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
        string query = "select * from ser_servicos where ser_id = ?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
    public static DataSet SelectID(string descricao)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        string sql = "select ser_id from ser_servicos where ser_descricao = ?descricao";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?descricao", descricao));

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
}