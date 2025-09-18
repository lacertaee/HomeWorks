namespace ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        // 1
        
        Console.WriteLine("შეიყვანე რიცხვი: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        
        // 2
        
        Console.WriteLine("X: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Y: ");
        int y = int.Parse(Console.ReadLine());
        int sum = x + y;
        int substraction;
        int multiplication = x * y;
        if (x > y)
        {
            substraction = x - y;
            
        }
        else
        {
            substraction = y - x;
           
        }
        Console.WriteLine($"X + Y: {sum}");
        Console.WriteLine($"X - Y: {substraction}");
        Console.WriteLine($"X * Y: {multiplication}");
        if (x > y && y != 0)
        {
            Console.WriteLine($"X / Y: {x / y}");
        }
        else if (x < y && x != 0)
        {
            Console.WriteLine($"X / Y: {y / x}");
        }
        else
        {

            Console.WriteLine("Not Allowed To Divide By Zero");
        }  



        // 3

        Console.WriteLine("Z: ");
        int Z = int.Parse(Console.ReadLine());
        Console.WriteLine("E: ");
        int E = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{Z} {E}");
        int temp = Z;
        Z = E;
        E = temp;
        Console.WriteLine($"{Z} {E}");

        // 4

        Console.WriteLine("number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }

        // 5

        Console.WriteLine("number: ");
        int num2 = int.Parse(Console.ReadLine());
        for (int i = 1; i < num2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i*i);
            }
        }

    }
}