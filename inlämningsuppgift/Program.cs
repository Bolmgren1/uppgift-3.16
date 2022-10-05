using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv hur lång din låt är, först i minuter, skriv då 3 om din låt är 3 minter");
            Console.Write("Skriv här:  ");
            int minuter = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Skriv nu in hur många sekunder din låt är, alltså 50 om den är t ex 2 minuter och 50 sekunder");
            Console.Write("Skriv här:  ");
            int sekunder = int.Parse(Console.ReadLine());

            int summa = 60 * minuter + sekunder;

            if (summa >= 165 && summa <= 260) 
            {
               Console.WriteLine("Vi kan spela din låt");

            }
            else

            
            {
                Console.WriteLine("Vi kan tyvärr inte spela denna låten");

            }
        }
    }
}
