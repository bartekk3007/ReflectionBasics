namespace ReflectionBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialise t as typeof string 
            Type t = typeof(string);

            // Use Reflection to find about any sort of data related to t 
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);

            foreach(var property in t.GetProperties())
            {
                Console.WriteLine(property.Name);
            }

            foreach(var field in t.GetFields())
            {
                Console.WriteLine($"{field.Name}");
            }

            foreach(var method in t.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
