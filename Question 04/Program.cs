namespace Question_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n%2 == 0){
                Console.WriteLine($"{n} is even");
            }
            else{
                Console.WriteLine($"{n} is odd");
            }
        }
    }
}
