using System;
using System.Collections.Generic;
using System.Linq;
using PrimeiroProjeto.Dicionario.Repository;
using PrimeiroProjeto.Dicionario.Model;
using System.Linq.Expressions;

namespace PrimeiroProjeto.Dicionario.Service
{
    public class UserService
    {
        UsersRepository repo = new UsersRepository();

        public void AdicionarUsuario()
        {
            System.Console.WriteLine("Digite o nome e cargo do usuario:");
            string nome = Console.ReadLine();
            string cargo = Console.ReadLine();
            Users user = new Users()
            {
                Nome = nome,
                Cargo = cargo
            };
            repo.AdicionarUser(user);
           
        }
        public Users Login()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            return repo.BuscarUsers(nome);
        }
        
    }
}