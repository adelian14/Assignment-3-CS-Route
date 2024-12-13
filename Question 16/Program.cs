namespace Question_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert: ");
            int x = int.Parse(Console.ReadLine());
            int n = x;
            string s = "";
            do
            {
                if (x % 2 == 0)
                {
                    s = "0" + s;
                }
                else
                {
                    s = "1" + s;
                }
                x /= 2;
            } while (x > 0);
            Console.WriteLine($"The Binary of {n} is {s}");
        }
    }
}
