using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimeiroProjeto.Dicionario.Repository;
using PrimeiroProjeto.Dicionario.Model;
using System.Diagnostics.Tracing;
namespace PrimeiroProjeto.Dicionario.Service
{
    public class ProdutoService
    {
        ProdutoRepository repo = new ProdutoRepository();
        public void listarProd()
        {
            repo.ListarProd();
        }
        public void adicionarProduto()
        {
             System.Console.WriteLine("Digite o nome do produto:");
                        string nome = Console.ReadLine();
                        System.Console.WriteLine("Digite o preço do produto:");
                        float preco = float.Parse(Console.ReadLine());
                        Produto produto = new Produto()
                        {
                            Nome = nome,
                            Preco = preco
                        };
                        repo.adicionarProd(produto);
        }
        public void FiltrarProduto()
        {
            System.Console.WriteLine("escreva o nome do produto para filtrar:");
            string nome = Console.ReadLine();
            repo.FiltrarProd(nome);
        }
    }
}