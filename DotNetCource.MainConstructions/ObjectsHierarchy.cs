namespace DotNetCource.MainConstructions
{
    using System;

    public static class ObjectsHierarchy
    {
        public static void ObjectHierarchy()
        {
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals (23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString () = {0}", 12.ToString());
            Console.WriteLine("12.GetType () = {0}", 12.GetType());
        }
    }
}