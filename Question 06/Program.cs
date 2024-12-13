namespace Question_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i < n)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }

        }
    }
}
