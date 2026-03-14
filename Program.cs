using System.Collections;
using System.Data;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using PrimeiroProjeto.Dicionario.Data;
using PrimeiroProjeto.Dicionario.Repository;
using PrimeiroProjeto.Dicionario.Service;
using PrimeiroProjeto.Dicionario.Model;
using MySql.Data.MySqlClient;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService service1 = new UserService();
            ProdutoService service = new ProdutoService();

            Users usuario = service1.Login();
            if(usuario == null)
            {
                Console.WriteLine("usuario nao encontrado");
                return;
            }
            else if (usuario.Cargo.ToLower() == "admin")
            {
                Console.WriteLine("Login como ADMIN");
                 Boolean rodar = true;
            
            
            while (rodar)
            {
                System.Console.WriteLine(@"digite o numero para oq voce quer:
1 - Adicionar Produto
2 - Listar Produtos
3 - Filtrar Produto
4 - Deletar Produto
5 - Adicionar Usuario
6 - Sair
                ");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                       
                        service.adicionarProduto();
                        break;
                    case 2:
                        service.listarProd();
                        break;
                    case 3:
                        service.FiltrarProduto();
                        break;
                    case 4:
                        service.DeletarProduto();
                        break;
                    case 5:
                        service1.AdicionarUsuario();
                        break;
                    case 6:
                        System.Console.WriteLine("Saindo...");
                        rodar = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção invalida");
                        break;

                }
            }
            }
            else
            {
                System.Console.WriteLine($"Usuario {usuario.Nome} nao tem permisao");
            }

           
        }
    }
}