using System.Text;

namespace DotNetCource.MainConstructions
{
    using System;

    public static class StringFunctionality
    {
        public static void Show()
        {
            Console.WriteLine("=> Basic String functionality:");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower ());
            Console.WriteLine("firstName contains the letter у?:{0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("dy", ""));

            //concatenation
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2; Console.WriteLine(s3);
            //or use String.Concat()

            //managable sequences \', \", \\, \a, \n, \r, \t
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves V'Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            Console.WriteLine("All finished.\n\n\n\a ");

            //using @
            string myLongString = @"This is 
a very very very
long string";
            Console.WriteLine(myLongString);

            //equality
            Console.WriteLine("=> String equality:");
            string st1 = "Hello!";
            string st2 = "Yo!";
            Console.WriteLine("si = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            Console.WriteLine("st1 == st2: {0}", st1 == st2);
            Console.WriteLine("st1 == Hello!: {0}", st1 == "Hello!");
            Console.WriteLine("st1 == HELLO!: {0}", st1 == "HELLO!");
            Console.WriteLine("st1 == hello!: {0}", st1 == "hello!");
            Console.WriteLine("st1.Equals(st2): {0}", st1.Equals(st2));
            Console.WriteLine("Yo.Equals(st2): {0}", "Yo!".Equals(st2));

            //comparing
            string str1 = "Hello!";
            string str2 = "HELLO!";

            Console.WriteLine("Default rules: sl ={0}, str2 ={l} str1.Equals(str2) : {2}", str1, str2, str1.Equals(str2));
            Console.WriteLine("Ignore case: str1.Equals(str2, StringComparison.OrdinallgnoreCase) : {0}", str1.Equals(str2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invarariant Culture: str1.Equals(str2, StringComparison.InvanantCulturelgnoreCase) : {0}", str1.Equals(str2, StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("Default rules: sl={0},str2={1} str1.IndexOf(\"E\"): {2}", str1, str2, str1.IndexOf("E"));
            Console.WriteLine("Ignore case: str1.IndexOf(\"E\", StringCompanson. OrdinallgnoreCase) : {0}", str1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invarariant Culture: str1.IndexOf(\"E\", StringComparison. InvanantCulturelgnoreCase) : {0}", str1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine();
        }

        public static void StringsAreImmutable()
        {
            string si = "This is my string.";
            Console.WriteLine("si = {0}", si);
            string upperstring = si.ToUpper();
            Console.WriteLine("upperString = {0}", upperstring);
            Console.WriteLine ("si = {0}", si);

            //use StringBuilder
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
        }
    }
}