using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai
            //Kui kasutaja sai A, konsool kuvab suurepärane
            //kui tulemus on b siis konsool kuvab väga hea
            //kui kasutaja saab c siis konsool kuvab hea
            // d konsool kuvab rahuldav
            // e konsool kuvab kasin
            // f konsool kuvab puudulik
            // kui kasutaja sisestab midagi muud konsool sisestab vale väärtus


            Console.WriteLine("Sisesta oma tulemus: ");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale Väärtus!");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
