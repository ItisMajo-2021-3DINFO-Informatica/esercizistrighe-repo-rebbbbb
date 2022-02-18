using System;

namespace EsercizioStringhe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivi un programma che, inserita una sequenza di parole, calcoli quante, fra le parole
            //inserite, iniziano e terminano con la stessa lettera;

            string parola = "";
            int InizioFineUguale = 0;

            while (parola != "fine")
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();

                int lungh = parola.Length;
                InizioFineUguale = Convert.ToInt32(Console.ReadLine());

                if (lungh == InizioFineUguale)
                {
                    InizioFineUguale++;
                }
            }
            Console.WriteLine($"Le parole che iniziano e finiscono con la stessa lettera sono: {InizioFineUguale}");
        }
    }
}
