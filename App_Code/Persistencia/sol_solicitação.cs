﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
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
            sql += "(sol_origem, sol_destino, sol_data, sol_qtdpessoas, cli_id)";
            sql += "values ";
            sql += "(?sol_origem, ?sol_destino, ?sol_data, ?sol_qtdpessoas, ?cli_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?sol_origem", sol.Sol_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_destino", sol.Sol_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_data", sol.Sol_data));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_qtdpessoas", sol.Sol_qtdpessoas));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", sol.Cli_id.Cli_id));
            

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
    public static int Update(sol_solicitacao sol)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update sol set sol_origem = ?sol_origem, sol_destino = ?sol_destino, sol_data = ?sol_data, sol_qtdpessoas = ?sol_qtdpessoas where sol_id = ?sol_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?sol_origem", sol.Sol_origem));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_destino", sol.Sol_destino));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_data", sol.Sol_data));
            objCommand.Parameters.Add(Mapped.Parameter("?sol_qtdpessoas", sol.Sol_qtdpessoas));
            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?cli_id", sol.Cli_id.Cli_id));


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