using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenha
{
    public  class Conexao
    {
        public MySqlConnection conecta = new MySqlConnection();

        public void Conectar()
        {
            if (conecta.State == ConnectionState.Closed)
            {
                conecta.ConnectionString = "Server=localhost;Database=bd_senha;User=root;Pwd=cursoads";
                conecta.Open();
            }
        }
        public void Desconectar()
        {
            if (conecta.State == ConnectionState.Open)
            {
                conecta.Close();
            }
        }
        public int ExecSql(string sql)
        {
            int nlinhas;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;
                nlinhas = comando.ExecuteNonQuery();
            } catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                nlinhas = 0;
            }
            return nlinhas;
        }
        public int ExecEscalar(string sql)
        {
            int conta= 0;
            try
            {
                MySqlCommand mySqlCommand= new MySqlCommand();
                mySqlCommand.CommandText= sql;
                mySqlCommand.Connection= conecta;
                conta=(int)mySqlCommand.ExecuteScalar();
            } catch(Exception ex)
            {
                Console.WriteLine("Erro:"+ ex);
            }
            return conta;
        }
    }
}
