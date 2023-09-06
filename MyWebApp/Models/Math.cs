namespace MyWebApp.Models
{
    public interface IMath
    {
        public int Add(int x, int y);
        public int Substract(int x, int y);
        public int Multiply(int x, int y);
        public int Divide(int x, int y);

    } 
    public class Math : IMath
    {
        public int Add(int x, int y) => x + y;
        public int Substract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;
        public int Divide(int x, int y) => x / y;
    }
}
