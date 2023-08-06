// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ClassLibraryProject;
class Program
{
    public static void Main(String[] args)
    {
        //Assignement 3 execution 
        Counter counter = Counter.GetInstance();
        counter.Increment();
        counter.Increment();
        counter.Increment();
        counter.Decrement();
        Console.WriteLine("Current Counter ---->"+"  "+counter.getCounter.ToString());// 2 is expected.

        //Assignment 2 execution
        Demo obj1 = new Demo();
        obj1.Message();

        //Assigment 1 execution
        LenghtHelper obj = new LenghtHelper();
        Console.WriteLine("Enter Word");
        Console.WriteLine();
        string? word = Console.ReadLine();
        Console.WriteLine(obj.findlenght(word));

        //Assigment 4 execution 
        Console.WriteLine("Enter Amount");
        Console.WriteLine();
        string? amount = Console.ReadLine(); 
        Console.WriteLine(amount.ToCurrency());

    }
}