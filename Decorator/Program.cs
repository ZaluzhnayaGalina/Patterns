using Decorator.Clothes;
using System;
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garment garment = new Dress();
            Garment totalLook = new Scarf(garment);
            totalLook = new Stockings(totalLook);
            Console.WriteLine(totalLook.PutOn());
            Console.ReadKey();
        }
    }
}
