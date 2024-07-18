namespace Password_Genrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("========================\n   Password Generator\n========================\n");
                Console.WriteLine("1] Generate Small Password\n2] Generate Medium Password\n3] Generate Large Password\n4] Exit ");
                int choice = 0;
                while (true)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    if (choice > 4 || choice < 1)
                    {
                        Console.WriteLine("Unknown Choice");
                        continue;
                    }
                    else break;
                }
                String[] pass = { "", "" };
                if(choice == 1)
                {
                    Console.Clear();

                    pass = Generator.SmallPassword();

                    Console.WriteLine($"Normal Password : {pass[0]}\n");
                    Console.WriteLine($"Hard Password : {pass[1]}\n");

                    Console.WriteLine("< Click enter to back >");
                    String back = Console.ReadLine();

                    Console.Clear();
                }
                else if(choice == 2)
                {
                    Console.Clear();

                    pass = Generator.MediumPassword();

                    Console.WriteLine($"Normal Password : {pass[0]}\n");
                    Console.WriteLine($"Hard Password : {pass[1]}\n");

                    Console.WriteLine("< Click enter to back >");
                    String back = Console.ReadLine();

                    Console.Clear();

                }
                else if (choice == 3)
                {
                    Console.Clear();

                    pass = Generator.HardPassword();

                    Console.WriteLine($"Normal Password : {pass[0]}\n");
                    Console.WriteLine($"Hard Password : {pass[1]}\n");

                    Console.WriteLine("< Click enter to back >");
                    String back = Console.ReadLine();

                    Console.Clear();

                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
