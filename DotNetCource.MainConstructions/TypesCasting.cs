namespace DotNetCource.MainConstructions
{
    using System;

    public static class TypesCasting
    {
        public static void ShowShortCasting()
        {
            short numbl = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numbl, numb2, Add(numbl, numb2));
        }

        public static void ShowShortCastingError()
        {
            short numbl = 30000, numb2 = 30000;
            //short answer = Add(numbl, numb2);
            // short answer = (short)Add(numbl, numb2);
            Console.WriteLine("{0} + {1} = {2}", numbl, numb2, Add(numbl, numb2));
        }

        public static void ShowByteCastingError()
        {
            byte myByte = 0;
            int mylnt = 200;
            //myByte = mylnt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        public static void ShowCheckedUncheckedWork()
        {
            byte bl = 100;
            byte b2 = 250;
            byte sum = (byte)Add(bl, b2);
            Console.WriteLine("sum = {0}", sum);
        }

        private static int Add(int x, int y) => x + y;
    }
}