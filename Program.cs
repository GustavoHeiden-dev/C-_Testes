using System.Collections.Specialized;

int[] vetor = new int[5];  

for(int i = 0 ; i< vetor.Length ; i++)
{
    System.Console.WriteLine("escreva um numero para colocar na posiçao: "+i);
    String s = Console.ReadLine();
    int n = int.Parse(s);
    vetor[i] =  n;
}
MenorParaMaior();
MaiorParaMenor();


void MenorParaMaior()
{
    //swap
    for(int i=0; i < vetor.Length - 1 ; i++)
    {
        for(int j=0; j<vetor.Length - 1 ; j++)
        {
            if(vetor[j] > vetor[j + 1])
            {
                int a = vetor[j];
                vetor[j] = vetor[j + 1];
                vetor[j + 1 ] = a;
            }
        }
    }
    System.Console.WriteLine("de menor para maior: ");
    foreach(int v in vetor)
    {
        System.Console.WriteLine(v);
    }
    
}

void MaiorParaMenor()
{
    System.Console.WriteLine("\nde maior para menor: ");
Array.Reverse(vetor);
foreach( int v in vetor){
    System.Console.WriteLine(v);
}   
    
}