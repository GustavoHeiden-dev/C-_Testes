namespace PrimeiroProjeto.Entity;
public class PessoaFisica : Pessoa
{
    public int cpf {get; set;}

    public override void ExibirDados()
    {
        System.Console.WriteLine("Pessoa Física:");
         System.Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCPF: {cpf}\n");
    }
}