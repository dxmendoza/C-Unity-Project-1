namespace Exercise8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Console.Write("Enter number: ");
              int m = int.Parse(Console.ReadLine());
              for (int i = 0; i <= m / 2; i++)
              {
                  Console.WriteLine(i * 2);
              } 

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
            } 

            Console.Write("Enter width: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter rows: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } */

            Console.WriteLine("***");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 – New Game");
            Console.WriteLine("2 – Load Game");
            Console.WriteLine("3 – Options");
            Console.WriteLine("4 – Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            // prompt for and get choice
            Console.Write("Enter your choice (1, 2, 3 or 4): ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid");
                Console.Write("Enter your choice (1, 2, 3 or 4): ");
                choice = int.Parse(Console.ReadLine());
            }

            // print message using if statement
            if (choice == 1)
            {
                Console.WriteLine("Creating new game ...");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Loading game ...");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Setting options ...");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Quitting ...");
            }
            else
            {
                Console.WriteLine("That's not a valid menu choice!");
            }
        }
    }
}