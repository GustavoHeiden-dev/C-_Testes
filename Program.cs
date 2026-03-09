using System.Collections;
using System.Data;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Xml;
using PrimeiroProjeto.Dicionario.Dict;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Dict dict = new Dict();
            Boolean rodar = true;
            while (rodar)
            {
                System.Console.WriteLine(@"digite o numero para oq voce quer:
1 - Adicionar Produto
2 - Listar Produtos
3 - Sair
                ");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        dict.AdiconarProd();
                        break;
                    case 2:
                        dict.listarProd();
                        break;
                    case 3:
                        System.Console.WriteLine("Saindo...");
                        rodar = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção invalida");
                        break;

                }
            }
        }
    }
}