using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //genereerib juhus numbr 1 - 10;
            //peab ära arvama
            //kui suutis WINNER
            //katsete arv on 3, kui ei suuda arvata sellega voidab arvuti
            //programm genereerib juhuslikku numbrit 1 kord
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;



            while (cpuNumber <= 11)
            {
                Console.WriteLine("Arva number:");
                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == cpuNumber)
                {
                    Console.WriteLine("Oige number! Proovi veel kas joppab!");
                    cpuNumber = rnd.Next(1, 11);
                }
                else
                {
                    i++;

                    Console.WriteLine("Vale Number! Proovi uuesti!");

                }


                if (i >= 3)
                {
                    Console.WriteLine("Vale Number! Katsete arv labi. Arvuti WIN!");
                    break;
                }

            }
        }
    }
    }
