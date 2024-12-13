namespace Question_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());
            while(x > 0)
            {
                y = y * 10 + x % 10;
                x /= 10;
            }
            Console.WriteLine(y);
        }
    }
}
