using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using PrimeiroProjeto.Dicionario.Data;
using PrimeiroProjeto.Dicionario.Model;
using MySql.Data.MySqlClient;
namespace PrimeiroProjeto.Dicionario.Repository
{
    public class ProdutoRepository
    {
        private Conexao conexao = new Conexao();

        public void ListarProd()
        {
            using var conn = conexao.Conectar(); 
            conn.Open();

            string sql = "SELECT * FROM mercandoDB.produtos";
            var cmd = new MySqlCommand(sql,conn);
            var reader = cmd.ExecuteReader();


            while(reader.Read())
            {
            Console.WriteLine($"Nome:{reader["nome"]} / Preço:{reader["preco"]}");
            }
        }
        public void adicionarProd(Produto produto)
        {
            using var conn = conexao.Conectar();
            conn.Open();

            string sql = "INSERT INTO mercandoDB.produtos (nome,preco) VALUES (@nome,@preco)";

            var cmd  = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@nome",produto.Nome);
            cmd.Parameters.AddWithValue("@preco",produto.Preco);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Produto adicionado com sucesso!");
        }
        public void FiltrarProd(string nome)
        {
            using var conn = conexao.Conectar();
            conn.Open();
            string sql = "SELECT * FROM mercandoDB.produtos WHERE nome LIKE @nome";
            var cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                System.Console.WriteLine($"Nome: {reader["nome"]} / Preco{reader["preco"]}");
            }
        }
        
        
    }
}