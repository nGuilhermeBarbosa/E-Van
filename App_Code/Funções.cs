using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Descrição resumida de Funções
/// </summary>

public class Funções
{
    public int Quantidaderegistros(DataSet ds)
    {
        return ds.Tables[0].Rows.Count;
    }

    public static string CodificaBase64(string texto)
    {
        byte[] stringBase64 = new byte[texto.Length];
        stringBase64 = Encoding.UTF8.GetBytes(texto);
        string codifica = Convert.ToBase64String(stringBase64);
        return codifica;
    }

    public static string DecodificaBase64(string texto)
    {
        var encode = new UTF8Encoding();

        var utf8Decode = encode.GetDecoder();
        byte[] stringValor = Convert.FromBase64String(texto);
        int contador = utf8Decode.GetCharCount(stringValor, 0, stringValor.Length);
        char[] decodeChar = new char[contador];
        utf8Decode.GetChars(stringValor, 0, stringValor.Length, decodeChar, 0);
        string retorno = new string(decodeChar);
        return retorno;
    }

    public static string Hash(string texto, string hash)
    {
        HashAlgorithm algoritmo = HashAlgorithm.Create(hash);
        if (algoritmo == null)
            throw new ArgumentException("Nome da hash inválida");

        byte[] vetorHash = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(vetorHash);
    }
}