namespace Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers: ");
            int x, y, z;
            Console.Write("integer #1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("integer #2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("integer #3: ");
            z = int.Parse(Console.ReadLine());
            int mx, mn;
            if(x >= y && x >= z){
                mx = x;
            }
            else if (y >= z && y >= x){
                mx = y;
            }
            else{
                mx = z; 
            }
            if(x <= y && x <= z){
                mn = x;
            }
            else if(y <= x && y <= z){
                mn = y;
            }
            else{
                mn = z;
            }
            Console.WriteLine($"Max element = {mx}");
            Console.WriteLine($"Min element = {mn}");
        }
    }
}
