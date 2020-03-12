namespace DotNetCource.MainConstructions
{
    using System;

    public static class HandlingProgramInputArguments
    {
        public static void HandleArguments(string[] args)
        {
            if (args.Length == 0)
                return;

            foreach (string argument in args)
                Console.WriteLine("Arg: {0}", argument);
            //or
            //for(int i=0; i<args.Length; i++)
            //Console .WriteLine ( "Arg: {0}", args[i]);
        }

        public static void HandleArguments()
        {
            string[] args = Environment.GetCommandLineArgs();

            foreach (string argument in args)
                Console.WriteLine("Arg: {0}", argument);
        }
    }
}