﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Descrição resumida de doc_documento
/// </summary>
public class tdo_tipodocumentoDB
{
    public static int Insert(tdo_tipodocumento tdo)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into  tdo_tipodocumento";
            sql += "(tdo_obrigatorio, tdo_descricao)";
            sql += "values ";
            sql += "(?tdo_obrigatorio, ?tdo_descricao)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?tdo_obrigatorio", tdo.Tdo_obrigatorio));
            objCommand.Parameters.Add(Mapped.Parameter("?tdo_descricao", tdo.Tdo_descricao));

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
        string sql = "select * from tdo_tipodocumento";

        objConexao = Mapped.Connection();
        objCommand = Mapped.Command(sql, objConexao);

        objDataAdapter = Mapped.Adapter(objCommand);
        objDataAdapter.Fill(ds);

        objConexao.Close();
        objConexao.Dispose();
        objCommand.Dispose();

        return ds;
    }
}