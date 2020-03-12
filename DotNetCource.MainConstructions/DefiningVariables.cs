namespace DotNetCource.MainConstructions
{
    using System;

    public static class DefiningVariables
    {
        public static void DefineVariables()
        {
            Console.WriteLine("=> Data Declarations:");

            int mylnt = 0;
            string myStrmg = null;
            bool b1 = true, b2 = false, b3 = b1;

            Console.WriteLine($"{mylnt}, {myStrmg}, {b1}, {b2}, {b3}");
        }
    }
}