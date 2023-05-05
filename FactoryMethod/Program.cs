using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MORTAL KOMBAT");
            Console.ResetColor();
            
            Console.WriteLine("Choose your character:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" 1-Liu Kang\n 2-Raiden\n 3-Johnny Cage\n");
            Console.ResetColor();
            
            string choice = Console.ReadLine();
            ICharacter character = factoryMethod.ChooseCharacter(choice);
            Console.WriteLine();
            Console.WriteLine("Chosen character:");
            character.Chosen();
        }
    }
}