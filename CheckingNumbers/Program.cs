using System.Reflection.PortableExecutable;
using System.Windows.Markup;

namespace CheckingNumbers
{
    internal class Program
    {
        // 3 numbers are accepted, we check if all numbers are equal to each other
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 3 digits");
                string? input = Console.ReadLine();
                int values = 0;
                if (!int.TryParse(input, out values))
                {
                    Console.WriteLine("You must enter 3 digits");
                    continue;
                }
                if (values.ToString().Length != 3)
                {
                    Console.WriteLine("The number must have 3 digits");
                    continue;
                }
                int[] value = new int[3];
                bool check= true;
                for (int i = 0; i < 3 && check; i++)
                {
                    value[i] = values % 10;
                    values = values / 10;
                    if (i != 0 && value[i - 1] != value[i])
                    {
                        check = false;
 
                    }
                }

                switch (check)
                {
                    case true:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Numbers are equal");
                        break;
                        case false:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Numbera aren't equal");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
           
        }
    }
}
   