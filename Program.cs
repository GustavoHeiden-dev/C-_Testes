using System.Collections.Specialized;

int[] vetor = new int[5];  

for(int i = 0 ; i< vetor.Length ; i++)
{
    System.Console.WriteLine("escreva um numero para colocar na posiçao: "+i);
    String s = Console.ReadLine();
    int n = int.Parse(s);
    vetor[i] =  n;
}
System.Console.WriteLine("seu array de menor para maior:  ");
Array.Sort(vetor);
foreach( int v in vetor){
    System.Console.WriteLine(v);
}
System.Console.WriteLine("\nde maior para menor: ");
Array.Reverse(vetor);
foreach( int v in vetor){
    System.Console.WriteLine(v);
}