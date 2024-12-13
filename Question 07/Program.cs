namespace Question_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
