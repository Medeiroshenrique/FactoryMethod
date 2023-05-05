using System;

namespace FactoryMethod
{
    public class JonnyCage:ICharacter
    {
        public void Chosen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Johnny Cage");
            Console.ResetColor();
        }
    }
}