using System.Globalization;

namespace Methods_Exercise_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string marda = "Marda";
            string mali = "Mali";
            string kozman = "Kozman";

            Greetfriend(marda);
            Greetfriend(mali);
            Greetfriend(kozman);
            Console.Read();
        }
        public static void Greetfriend(string name)
        {
            Console.WriteLine("Hi {0}, My friend", name);
        }
    }
}