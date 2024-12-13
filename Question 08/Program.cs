namespace Question_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i+=2)
            {
                if(i > 2)
                    Console.Write(", ");
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
