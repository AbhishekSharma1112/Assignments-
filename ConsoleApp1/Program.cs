// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ClassLibraryProject;
class Program
{
    public static void Main(String[] args)
    {
        //Assignment 2 execution
        Demo obj1 = new Demo();
        obj1.Message();

        //Assigment 1 execution
        LenghtHelper obj = new LenghtHelper();
        Console.WriteLine("Enter Word");
        Console.WriteLine();
        string? word = Console.ReadLine();
        Console.WriteLine(obj.findlenght(word));


    }
}