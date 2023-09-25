using Hashtable.Hashtable;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable_class hashtable_Class = new Hashtable_class(15);
            hashtable_Class.Set("Ahmad", "Ahmad");
            hashtable_Class.Set("Omar", "Omar");
            hashtable_Class.Set("Mohsen", "Mohsen");
            hashtable_Class.Set("Haaani", "Haaani");
            hashtable_Class.Set("Ahmad", "Ahmad");

            foreach (var item in hashtable_Class.Keys())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("end of run");
        }
    }
}