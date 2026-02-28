// Console.WriteLine("Escreva um numero:");
// String num = Console.ReadLine();
// int num1 = int.Parse(num);

// if(num1 % 2 == 0 ){
//         Console.WriteLine($"seu numero é par" );
// }else{Console.Write("Seu numero é impar");}


System.Console.WriteLine("escreva um numero:");
String num1 = Console.ReadLine();

System.Console.WriteLine("escreva qual operaçao voce quer: ");
String op = Console.ReadLine();
System.Console.WriteLine("Escreva um segundo numero: ");
String num2 = Console.ReadLine();
int numeroConver = int.Parse(num1);
int numeroConver2 = int.Parse(num2);

switch (op)
{
    case "+" : 
    System.Console.WriteLine($"sua soma é {numeroConver + numeroConver2}"); 
    break;
    case "-":
    System.Console.WriteLine($"sua subtraçao é: {numeroConver - numeroConver2}"); 
    break;
    case "*": 
    System.Console.WriteLine($"sua multiplicaçao é: {numeroConver * numeroConver2}");
    break;
    case "/":
     System.Console.WriteLine($"sua divisão é: {numeroConver / numeroConver2}");
    break;
    default:
    System.Console.WriteLine("operaçao invalida");
    break;
}

