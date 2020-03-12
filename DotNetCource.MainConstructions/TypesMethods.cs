namespace DotNetCource.MainConstructions
{
    using System;

    public static class TypesMethods
    {
        public static void ShowDetails()
        {
            //int
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            int i = int.Parse("8");
            Console.WriteLine("Value of l: {0}", i);

            //double
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity : {0}", double.NegativeInfinity);

            double d = double.Parse("99. 884");
            Console.WriteLine("Value of d: {0} ", d);
            string value = "Hello";

            if (double.TryParse(value, out double d1))
                Console.WriteLine("Value of d: {0}", d1);
            else
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);

            //bool
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0} ", b);

            if (bool.TryParse("True", out bool b1))
                Console.WriteLine("Value of b1: {0}", b1);

            //char
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ( 'a ’ ) : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            char c = char.Parse("w");
            Console.WriteLine("Value of c: {о}", c);

            //datetime, timespan
            Console.WriteLine("=> Dates and Times:");
            DateTime dt = new DateTime (2020, 3, 12);
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            dt = dt.AddMonths(3);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

            //big integer for homework(say a few words about)
        }

        public static void UseDigitSeparators()
        {
            Console.WriteLine(123_456);
            Console.WriteLine(123_456_789L);
            Console.WriteLine(123_456.1234F);
            Console.WriteLine(123_456.12);
            Console.WriteLine(123_456.12M);
        }
    }
}