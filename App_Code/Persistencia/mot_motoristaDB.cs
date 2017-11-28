using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for mot_motorista
/// </summary>
public class mot_motoristaDB
{
    public static int Insert(mot_motorista mot)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into mot_motorista ";
            sql += "(mot_cnpj, mot_publicacoes, usu_id, tip_id)";
            sql += "values ";
            sql += "(?mot_cnpj, ?mot_publicacoes, ?usu_id, ?tip_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);



            objCommand.Parameters.Add(Mapped.Parameter("?mot_cnpj", mot.Mot_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_publicacoes", mot.Mot_publicacoes));

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?usu_id", mot.Usu_id.Usu_id));
            objCommand.Parameters.Add(Mapped.Parameter("?tip_id", mot.Tip_id.Tip_id));



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
        string sql = "select mot_publicacoes, pes_nome, pes_sexo, pes_cidade, usu_email from usu_usuario usu inner join mot_motorista mot on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id";

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
            string sql = "delete from mot_motorista where mot_id = ?mot_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", id));

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
    public static void Update(mot_motorista mot)
    {
        
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update mot_motorista set mot_cnpj = ?mot_cnpj where mot_id = ?mot_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?mot_cnpj", mot.Mot_cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?mot_id", mot.Mot_id));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objConexao.Dispose();
            objCommand.Dispose();
        
    }

    public static void UpdatePublicacoes(mot_motorista mot)
    {

        //Correto
        IDbConnection objConexao; //Abrir a conexão
        IDbCommand objCommand; // Criar e executar os comandos
        string sql = "update mot_motorista set mot_publicacoes = ?mot_publicacoes where mot_id = ?mot_id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?mot_publicacoes", mot.Mot_publicacoes));
        objCommand.Parameters.Add(Mapped.Parameter("?mot_id", mot.Mot_id));


        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

    }

    public static void UpdatePremium(mot_motorista mot)
    {

        //Correto
        IDbConnection objConexao; //Abrir a conexão
        IDbCommand objCommand; // Criar e executar os comandos
        string sql = "update mot_motorista set tip_id = ?tip_id where mot_id = ?mot_id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objCommand.Parameters.Add(Mapped.Parameter("?mot_id", mot.Mot_id));
        objCommand.Parameters.Add(Mapped.Parameter("?tip_id", mot.Tip_id.Tip_id));

        objCommand.ExecuteNonQuery();
        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

    }

    public static DataSet SelectDados(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select pes.pes_id, pes_nome, mot_cnpj, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_email, mxc_descricao, tpc_descricao from usu_usuario usu inner join    mot_motorista mot on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id inner join mxc_motorista_tipo_contato mxc on mxc.mot_id = mot.mot_id inner join tpc_tipo_contato tpc on mxc.tpc_id = tpc.tpc_id where pes.pes_id =  ?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }

    public static DataSet Select(mot_motorista mot)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select mot_nome, mot_cnpj, mot_sexo, mot_cidade, mot_estado, usu_email from mot_motorista inner join usu_usuario where mot_id = ?mot_id";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);
        objCommand.Parameters.Add(Mapped.Parameter("?mot_id", mot.Mot_id));
        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }

    public static DataSet SelectID(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select mot_id from mot_motorista mot inner join usu_usuario usu on mot.usu_id = usu.usu_id where usu.usu_id = ?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
    public static DataSet SelectCon(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select * from mot_motorista mot inner join con_condutor con on mot.mot_id = con.mot_id where mot.mot_id=?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }

    public static DataSet SelectPublicacoes(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select mot_publicacoes from mot_motorista where mot_id=?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
    public static DataSet SelectPETC(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select * from mot_motorista mot inner join tip_tipoconta tip on mot.tip_id = tip.tip_id where mot.mot_id=?id";
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