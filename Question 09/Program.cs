namespace Question_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, p, ans = 1;
            Console.Write("Enter bsae: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter power: ");
            p = int.Parse(Console.ReadLine());
            for(int i = 0; i < p; i++)
            {
                ans *= x;
            }
            Console.WriteLine($"{x} ^ {p} = {ans}");
        }
    }
}
