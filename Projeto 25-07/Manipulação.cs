using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Projeto_25_07
{
    public class Manipulacao : Produtos
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public void CadastroProd(string nome, string marca, double pre)
        {
            cmd.CommandText = "insert into Produtos(NomeProd,Preco, Marca) values (@nome, @preco, @marca)" +
                               "SELECT CAST(scope_identity() AS int)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@preco", pre);
            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteScalar();
                conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void AlterN(string nome,string nomenovo, string marca) //alterar nome
        {
            cmd.CommandText = "update Produtos set nomeprod = @nomenovo where nomeprod = @nome and marca = @marca";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@nomenovo", nomenovo);
            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void AlterP(string nome, string marca, double pre,double prenovo) //alterar preço
        {
            cmd.CommandText = "update Produtos set preco = @prenovo where nomeprod = @nome and marca = @marca";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@preco", pre);
            cmd.Parameters.AddWithValue("@prenovo", prenovo);
            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void AlterM(string nome, string marca, string marcanova) //alterar marca
        {
            cmd.CommandText = "update Produtos set marca = @marcanova where nomeprod = @nome and marca = @marca";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@marcanova", marcanova);
            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        public void Delete(string nome,string marca)
        {
            cmd.CommandText = "Delete from Produtos where nomeprod = @nome and marca = @marca";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@marca", marca);

            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }
        }
        public void Select()
        {
            string sSql = "select * from Produtos";
            cmd.CommandText = sSql;

            try
            {
                cmd.Connection = conexao.Conectar();
                var i = cmd.ExecuteReader();


                while (i.Read())
                {
                    Console.WriteLine(string.Format("Nome: {0}; Preço: {1}; Marca: {2}", i[1], i[2], i[3]));
                }
                conexao.Desconectar();            
            }
            catch (SqlException es)
            {
                Console.WriteLine(es.Message);
            }

        }
    }
}
    

