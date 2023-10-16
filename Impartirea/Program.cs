namespace Impartirea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
           
            x = int.Parse(Console.ReadLine());
           
            y = int.Parse(Console.ReadLine());
            
            if (x % y != 0)
                
                Console.WriteLine("Nu se poate efectua impartirea exacta");
            else
                Console.WriteLine(x / y);
        }
    }
}