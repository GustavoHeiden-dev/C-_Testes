System.Console.WriteLine("escreva um numero de 1 a 20 , e o programa\nvai adivinhar");



int min = 0;
int max = 20;
int tentativas = 0;

Console.WriteLine("Pressione ENTER quando estiver pronto.");
Console.ReadLine();

while (true)
{
    int meio = (min + max) /2;
    tentativas++;
    System.Console.WriteLine($"seu numero é {meio}?");
    System.Console.WriteLine("digite:\n[ 1 ]maior\n[ 2 ]menor\n[ 3 ]acertou");
    String resposta = Console.ReadLine();

    if(resposta ==  "1")
    {
        min = meio + 1;
    }
    else if (resposta == "2")
    {
      max = meio-1;  
    }
    else if(resposta == "3")
    {
        System.Console.WriteLine($"Acertei em {tentativas} tentativas!");
        break;
    }
    else
    {
        System.Console.WriteLine("resposta invalida ");
    }
    
}