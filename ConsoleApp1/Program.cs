// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ClassLibraryProject;
class Program
{
    public static void Main(String[] args)
    {



        //Assigment 1 execution
        Console.WriteLine("\n Assignment -1 \n");
        LenghtHelper obj = new LenghtHelper();
        Console.WriteLine("Enter Word");
        Console.WriteLine();
        string? word = Console.ReadLine();
        Console.WriteLine(obj.findlenght(word));

        //Assignment 2 execution
        Console.WriteLine("\n Assignment -2 \n");

        Demo obj1 = new Demo();
        obj1.Message();


        //Assignement 3 execution 
        Console.WriteLine("\n Assignment -3 \n");
        Counter counter = Counter.GetInstance();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        counter.Decrement();
        Console.WriteLine("Current Counter ---->" + "  " + counter.getCounter.ToString()+'\n');// 2 is expected.

        //Assigment 4 execution 
        Console.WriteLine("\n Assignment -4 \n");

        Console.WriteLine("Enter Amount");
        Console.WriteLine();
        string? amount = Console.ReadLine(); 
        Console.WriteLine($"{amount.ToCurrency()}\n");

        //Assigment 5 execution
        Console.WriteLine("\n Assignment -5 \n");

        ConsoleParser parser = new ConsoleParser(
            onWord : word => Console.WriteLine($" this is a word->{word}"),
            onNumber : number => Console.WriteLine($"this is a number{number}"),
            onJunk : junk => Console.WriteLine($"these are special characters {junk}")
            );
        parser.Run();
    }
}