using System;

namespace NumbersGame_version_1
{
    class Program
    {
        public static int RandomNumberGenerator(int randomNumber)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 20);

            return randomNumber;
            
        }


        static void Main(string[] args)
        {
        
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Gissa vilket? Du får fem försök ");

            RandomNumberGenerator();

            

            


        }

    }
}
