namespace Question_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------Simple Calculator---------------------");
            int x,y;
            char op;
            Console.Write("First number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Operation (+, -, *, /): ");
            op = (char)Console.Read();
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {x+y}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {x * y}");
                    break;
                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("Can't divide by 0");
                    }
                    else
                    {
                        Console.WriteLine($"{x} / {y} = {(float)x / y}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
