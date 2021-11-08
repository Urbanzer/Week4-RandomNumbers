using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        //programm küsib kasutajal sisestades PIN-koodi;
        //programm võrdleb sisestatud PIN-koodi arvuga 1234;
        //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
        //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovige uuesti";
        //kasutajal on kolm katset
        static void Main(string[] args)
        {

            int i = 0; //i -iteration

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale Number. Proovi uuesti.");
                }

            }

            Console.WriteLine("Kena päeva!");
        }
    }           
}
