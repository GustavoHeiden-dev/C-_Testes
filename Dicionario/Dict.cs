using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Dicionario.Dict
{
    public class Dict
    {
        Dictionary<String , float> mercadoRepo = new Dictionary<string, float>();
        public void AdiconarProd()
        {   
            System.Console.WriteLine("Digite o nome do produto e preço: ");
            string nome = Console.ReadLine() ?? "Sem nome";
            float preco = float.Parse(Console.ReadLine()) ;
            mercadoRepo.Add(nome , preco);

            System.Console.WriteLine("Produto adicionado com sucesso");
        }
        public void listarProd()
        {
            foreach (var item in mercadoRepo)
            {
                System.Console.WriteLine($"Produto: {item.Key} , Preco: {item.Value:F2}\n");
            }
        }
    }
}