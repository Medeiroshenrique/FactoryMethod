using System;

namespace FactoryMethod
{
    public class LiuKang:ICharacter
    {
        public void Chosen()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Liu Kang");
            Console.ResetColor();
        }
    }
}