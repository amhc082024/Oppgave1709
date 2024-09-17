namespace Oppgave1709;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Add(9,11));
    Console.WriteLine(calculator.Subtract(20,11));
    Console.WriteLine(calculator.Multiply(5,4));
    Console.WriteLine(calculator.Divide(40,2));
    }


}
