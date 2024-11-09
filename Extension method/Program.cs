using System.Runtime.CompilerServices;

namespace Extension_method
{
    static class Program            //Ask about why this didnt work as an internal class but worked for a static -- whats the difference when working with extensions within the same class
    {
        static void Main(string[] args)
        {
            int result = 23.By2Less1();
            Console.WriteLine(result);

            string text = "Hello World";

            Console.WriteLine("The number of works in \"{0}\" is {1}", text, text.WordCount());


            Console.ReadLine();

        }
        public static int By2Less1(this int num)
        {

            return num * 2 - 1;
        }
        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
