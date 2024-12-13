namespace Question_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month number: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Month {num} has 31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Month {num} has 30 days");
                    break;
                case 2:
                    Console.WriteLine($"Month {num} has 28 days");
                    break;
                default:
                    Console.WriteLine($"Invalid month number");
                    break;
            }
        }
    }
}
