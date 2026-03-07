namespace PrimeiroProjeto.Entity;
public class PessoaJuridica : Pessoa
{
    
    public string cnpj {get; set;}

    public override void ExibirDados(){
        System.Console.WriteLine("Pessoa Jurídica:");
       System.Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nCNPJ: {cnpj}\n");
    }
}