namespace Question_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            int total = 0;
            float avg, per;
            for (int i = 1; i <= 5; i++) {
                Console.Write($"Subject #{i}: ");
                int s = int.Parse(Console.ReadLine());
                total += s;
            }
            avg = (float)total / 5;
            per = ((float)total / 500) * 100;
            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average marks = {avg}");
            Console.WriteLine($"Percentage = {per}%");
        }
    }
}
