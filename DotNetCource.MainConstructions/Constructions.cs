namespace DotNetCource.MainConstructions
{
    using System;

    public static class Constructions
    {
        public static void ShowFor()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
        }

        public static void ShowForeach()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
                Console.WriteLine(i);
        }

        public static void ShowWhile()
        {
            string userlsDone = "";
            while (userlsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userlsDone = Console.ReadLine();
            }

            userlsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userlsDone = Console.ReadLine();
            } while (userlsDone.ToLower() != "yes");
        }

        public static void IfElseExample()
        {
            string stringData = "Му textual data";

            if (stringData.Length > 0)
            {
                Console.WriteLine("string is greater than 0 characters");
            }
            else
            {
                Console.WriteLine("string is not greater than 0 characters");
            }

            Console.WriteLine();

            //ternary operation
            Console.WriteLine(stringData.Length > 0
                ? "string is greater than 0 characters"
                : "string is not greater than 0 characters");

            //logical operations
            if (stringData.Length > 0 && stringData == "Fred")
                return;
        }

        public static void SwitchExample()
        {
            Console.WriteLine("1 [C#]z 2 [VB]");
            Console.Write("Please pick your language preference: ");
            string langChoice = Console.ReadLine();
            int n = int.Parse(langChoice);

            //casting and constraints
            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well... good luck with that!");
                    break;

            }
        }
    }
}