
namespace PrimeiroProjeto.Entity;
public class Pessoa{
    public string nome {get; set;}
    public int idade {get; set;}

    public virtual void ExibirDados(){
        System.Console.WriteLine($"Nome: {nome}\nIdade: {idade}");
    }



}