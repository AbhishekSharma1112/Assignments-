// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
class Program
{
    public static void Main(String[] args)
    {
        LenghtHelper obj = new LenghtHelper();
        string? word = Console.ReadLine();
        Console.WriteLine(obj.findlenght(word));

        ;
    }
}