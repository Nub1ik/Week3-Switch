using System;

namespace GradingSwitch
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

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }



            Console.WriteLine("Kena päeva!");
        }
    }
}
