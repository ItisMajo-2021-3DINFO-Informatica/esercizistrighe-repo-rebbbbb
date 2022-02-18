using System;

namespace EsercizioStringhe_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivi un programma che, inserita una sequenza di parole, calcoli quante, fra le parole
            //inserite, hanno un numero pari di lettere e quante un numero dispari;

            string parola = "";
            int dispari = 0;
            int pari = 0;

            while (parola != "fine");
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();

                int lungh = parola.Length;

                if ((lungh % 2) != 0)
                {
                    parola = parola + pari;
                }
                else
                {
                    parola = parola + dispari;
                }
            }
            Console.WriteLine($"Le parole che hanno un numero pari di lettere sono: {pari}");
            Console.WriteLine($"Le parole che hanno un numero dispari di lettere sono: {dispari}");
        }
    }
}
