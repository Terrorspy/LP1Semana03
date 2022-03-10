using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("String: ");
         string text = Console.ReadLine();

         Console.Write("Carácter: ");
         string userinput = Console.ReadLine();
         string newText = text.Replace(userinput, "");

         Console.WriteLine(newText);
         Console.ReadLine();
        }
    }
}
