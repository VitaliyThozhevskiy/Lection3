namespace DotNetCource.MainConstructions.Dynamic
{
    using System;

    public class Person : DynamicObject
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void MessUp()
        {
            Console.WriteLine("Messed up!");
        }
    }
}