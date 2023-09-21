﻿
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Controllers

{
    public class TamanhoPizza
    {
        public int IdTamanho { get; set; }
        public string Tamanho { get; set; }

        public int QtdSabores { get; set; }

        List<TamanhoPizza> tamanhosPizzas = new List<TamanhoPizza>();
    }
    

    public class Conexao
    {
        

        // atributos da conexao
        static private string servidor = "us-cdbr-east-06.cleardb.net";
        static private string db = "heroku_e56db92fefe024d";
        static private string usuario = "b18f10f8ad9d79";
        static private string senha = "eabbaedc";
        static private string StrConn = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection conexao = null; // minha conexão



        //metodo de obter a conexao com o mySql




        public MySqlConnection getConexao()
        {
            // define a variavel conexao instanciando uma nova conexao
            conexao = new MySqlConnection(StrConn);
            return conexao; // retorno o valor da conexao

        }

        public DbSet<TamanhoPizza> TamanhosPizzas { get; set; }

        public List<TamanhoPizza> ObterTamanhosPizzas(string sql)
        {
            return TamanhosPizzas.ToList();
        }

        public string getMD5Hash(string senha)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inmpuBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(inmpuBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public int cadastrar(int codigo, string[] campos, object[] valores, string sql)
        {
            int registro = 0;
            try // testar o cadastro
            {
                conexao = getConexao();// chamo obter conexao
                conexao.Open();// abro a minha conexao
                // preparo o comando sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                // monto paramentros do sql

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue("id", codigo);
                }
                registro = cmd.ExecuteNonQuery();
                conexao.Close();

            } // se houver erro
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;

        }


        public int atualizar(string[] campos, object[] valores, string sql)
        {
            int registro = 0;


            return registro;
        }

        public DataTable ObterDados(string sql)
        {
            // crio uma nova tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conexao = getConexao();
            conexao.Open(); // abre banco de dados
            // preparo o commando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conexao);
            //tipo de instrução de texto
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt);// montar a tabela de dados
            conexao.Close();
            return dt;// retorna a tabela de dados
        }

       
    }
}
