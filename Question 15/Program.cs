namespace Question_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            Console.Write("Input starting number of range: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime number between 1 and 50 are:");
            for(int n = start; n <= end; n++)
            {
                bool isPrime = true;
                for(int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && n!=1)
                {
                    Console.Write($"{n} ");
                }
            }
            Console.WriteLine();
        }
    }
}
