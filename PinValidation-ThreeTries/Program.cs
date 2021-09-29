using System;

namespace PinValidation_ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else if (i < 3)
                {
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    i = i + 1;                   
                }


            }
        }
    }
}
