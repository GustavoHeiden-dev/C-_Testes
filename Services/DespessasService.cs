namespace PrimeiroProjeto.Services;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PrimeiroProjeto.Model;



public class DespessasService
{   
    private Pessoa pessoa; 
    private List<Despessas> despesas = new List<Despessas>();
    public void AdicionarDespesa(Despessas despesa)
    {
        despesas.Add(despesa);
    }
     public DespessasService(Pessoa pessoa)
    {
        this.pessoa = pessoa;
    }
    public void ListarDespesas()
    {
        foreach (var desp in despesas)
        {
            System.Console.WriteLine($"{desp.descricao} - R${desp.valor}");
        }
    }
    public void CalcularTotalDespesa()
    {   

        double total = 0;
        foreach (var desp in despesas)
        {
            total+=desp.valor;
        } 
       System.Console.WriteLine($"Total das despesas:{total}\nSalrio com desconto:{pessoa.salario - total}");
    }
}
