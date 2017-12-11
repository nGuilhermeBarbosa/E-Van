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
            sql += "(ser_datacadastro, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, mot_id, tra_id)";
            sql += "values ";
            sql += "(?ser_datacadastro, ?ser_datainicio, ?ser_datafim, ?ser_origem, ?ser_destino, ?ser_descricao, ?ser_lugares, ?mot_id, ?tra_id)";

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
            objCommand.Parameters.Add(Mapped.Parameter("?tra_id", ser.Tra_id.Tra_id));




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

    public static DataSet SelectInfoService(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select pes_nome, pes_cidade, pes_estado, mot_cnpj, tdo_image, mxc_descricao, ser_datacadastro, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, con_nome, con_cpf, ctp_descricao, tp.tpc_descricao, tpc.tpc_descricao, tra_modelo, tra_placa, tra_lugares, tve_descricao, rec_descricao, img_foto from pes_pessoa pes inner join usu_usuario usu on pes.pes_id = usu.pes_id inner join mot_motorista mot on usu.usu_id = mot.usu_id inner join doc_documento doc on mot.mot_id = doc.mot_id inner join tdo_tipodocumento tdo on tdo.tdo_id = doc.tdo_id inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id inner join ser_servicos ser on mot.mot_id = ser.mot_id inner join sco_servicocondutor sco on ser.ser_id = sco.ser_id inner join con_condutor con on con.con_id = sco.con_id inner join ctp_condutor_tipo_contato ctp on con.con_id = ctp.con_id inner join tpc_tipo_contato tpc on tpc.tpc_id = ctp.tpc_id inner join tra_transporte tra on tra.tra_id = ser.tra_id inner join tpc_tipo_contato tp on tp.tpc_id = mxc.tpc_id inner join tve_tipoveiculo tve on tve.tve_id = tra.tve_id inner join img_imagemveiculo img on tra.tra_id = img.tra_id inner join txr_transporte_recursos txr on tra.tra_id = txr.tra_id inner join rec_recursos rec on rec.rec_id = txr.rec_id where ser.ser_id = ?id";

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

    public static DataSet SelectInfoCon(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select pes_nome, pes_cidade, pes_estado, mot_cnpj, tdo_image, mxc_descricao, ser_datacadastro, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, tp.tpc_descricao, tra_modelo, tve_descricao, rec_descricao, tra_placa, tra_lugares, img_foto from pes_pessoa pes inner join usu_usuario usu on pes.pes_id = usu.pes_id inner join mot_motorista mot on usu.usu_id = mot.usu_id inner join doc_documento doc on mot.mot_id = doc.mot_id inner join tdo_tipodocumento tdo on tdo.tdo_id = doc.tdo_id inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id inner join ser_servicos ser on mot.mot_id = ser.mot_id inner join tra_transporte tra on tra.tra_id = ser.tra_id inner join tpc_tipo_contato tp on tp.tpc_id = mxc.tpc_id inner join tve_tipoveiculo tve on tve.tve_id = tra.tve_id inner join img_imagemveiculo img on tra.tra_id = img.tra_id inner join txr_transporte_recursos txr on tra.tra_id = txr.tra_id inner join rec_recursos rec on rec.rec_id = txr.rec_id where ser.ser_id = ?id; ";

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

    public static DataSet SelectI(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objCommand;

        IDataAdapter objDataAdapter;
        //string sql = "select emp_nome as NOME, emp_rua as RUA from emp_empresa order by emp_nome";
        //string sql = "select emp_nome, emp_rua from emp_empresa order by emp_nome";
        string sql = "select * from sco_servicocondutor sco inner join ser_servicos ser on ser.ser_id = sco.ser_id inner join con_condutor con on con.con_id = sco.con_id where ser.ser_id = ?id ";

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

    public static DataSet SelectService()
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
            string sql = "update ser_servicos set ser_datafim = ?ser_datafim, ser_origem = ?ser_origem, ser_datainicio = ?ser_datainicio, ser_destino = ?ser_destino, ser_descricao = ?ser_descricao, ser_lugares = ?ser_lugares, tra_id = ?tra_id where ser_id = ?ser_id";

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
            objCommand.Parameters.Add(Mapped.Parameter("?tra_id", ser.Tra_id.Tra_id));

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

    public static DataSet SelectInfo(int id)
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
        string query = "select ser.ser_id, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, con.con_id, tra.tra_id from ser_servicos ser  inner join sco_servicocondutor sco on ser.ser_id = sco.ser_id inner join con_condutor con on con.con_id = sco.con_id inner join tra_transporte tra on ser.tra_id = tra.tra_id where ser.ser_id = ?id ";
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
        string query = "select sco.con_id from sco_servicocondutor sco inner join con_condutor con on con.con_id = sco.con_id inner join ser_servicos ser on ser.ser_id = sco.ser_id where ser.ser_id = ?id";
        objComando = Mapped.Command(query, objConexao);
        objComando.Parameters.Add(Mapped.Parameter("?id", id));
        objDataAdapter = Mapped.Adapter(objComando);
        objDataAdapter.Fill(ds);
        objConexao.Close();
        objConexao.Dispose();
        objComando.Dispose();
        return ds;
    }
    public static DataSet SelectDadosCon(int id)
    {
        DataSet ds = new DataSet();
        IDbConnection objConexao;
        IDbCommand objComando;
        IDataAdapter objDataAdapter;
        objConexao = Mapped.Connection();
        string query = "select ser.ser_id, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, tra.tra_id from ser_servicos ser inner join tra_transporte tra on ser.tra_id = tra.tra_id where ser.ser_id = ?id";
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