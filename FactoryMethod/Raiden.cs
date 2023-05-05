using System;

namespace FactoryMethod
{
    public class Raiden:ICharacter
    {
        public void Chosen()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Raiden");
            Console.ResetColor();
        }
    }
}