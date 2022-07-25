using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_25_07
{
    public class Conexao
    {
        SqlConnection connection = new SqlConnection();
        public Conexao()
        {
            connection.ConnectionString = @"User ID=aluno15;Password=aluno_3522;Data Source=localhost\SQLEXPRESS;Initial Catalog=Eproc_aluno15; Persist Security Info=True;Timeout=120";
        }

        public SqlConnection Conectar()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void Desconectar()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
