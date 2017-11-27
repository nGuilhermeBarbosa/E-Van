using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de sco_servicoscondutorDB
/// </summary>
public class sco_servicoscondutorDB
{
    public static int Insert(sco_servicoscondutor sco)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "insert into sco_servicocondutor ";
            sql += "(con_id, ser_id)";
            sql += "values ";
            sql += "(?con_id, ?ser_id)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);



            // Chave estrangeira
            objCommand.Parameters.Add(Mapped.Parameter("?con_id", sco.Con_id.Con_id));
            objCommand.Parameters.Add(Mapped.Parameter("?ser_id", sco.Ser_id.Ser_id));
            

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
    public static DataSet SelectID(int con_id, int ser_id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select sco_id from sco_servicocondutor sco where sco.con_id = ?con_id and sco.ser_id = ?ser_id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?con_id", con_id));
        objComando.Parameters.Add(Mapped.Parameter("?ser_id", ser_id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
    public static int Update(sco_servicoscondutor sco)
    {
        int retorno = 0;

        try
        {
            //Correto
            IDbConnection objConexao; //Abrir a conexão
            IDbCommand objCommand; // Criar e executar os comandos
            string sql = "update sco_servicocondutor set con_id = ?con_id where sco_id = ?sco_id";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?sco_id", sco.Sco_id));

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