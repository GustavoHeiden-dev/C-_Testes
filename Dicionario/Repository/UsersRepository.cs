using System;
using System.Collections.Generic;
using System.Linq;
using PrimeiroProjeto.Dicionario.Data;
using PrimeiroProjeto.Dicionario.Model;
using MySql.Data.MySqlClient;

namespace PrimeiroProjeto.Dicionario.Repository
{
    public class UsersRepository
    {
        Conexao conexao = new Conexao();

        public void AdicionarUser(Users user)
        {
            using var conn = conexao.Conectar();
            conn.Open();

            string sql = "INSERT INTO mercandoDB.users (nome,cargo) VALUES (@nome,@cargo)";
            var cmd = new MySqlCommand(sql , conn);
            cmd.Parameters.AddWithValue("@nome", user.Nome);
            cmd.Parameters.AddWithValue("@cargo",user.Cargo);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Usuario adicionado com sucesso!");
        }
        public Users BuscarUsers(string nome)
        {
            using var conn = conexao.Conectar();
            conn.Open();
            string sql = "SELECT * FROM mercandoDB.users WHERE nome = @nome";
            var cmd = new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@nome",nome);
            var reader = cmd.ExecuteReader();
             if (reader.Read())
    {
        return new Users
        {
            Nome = reader["nome"].ToString(),
            Cargo = reader["cargo"].ToString()
        };
    }

    return null;

        }
    }
    
}