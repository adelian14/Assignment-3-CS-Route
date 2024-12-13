namespace Question_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, t = "";
            Console.Write("Enter a string: ");
            s = Console.ReadLine();
            for(int i = s.Length-1; i > -1; i--)
            {
                t += s[i];
            }
            Console.WriteLine(t);
        }
    }
}
