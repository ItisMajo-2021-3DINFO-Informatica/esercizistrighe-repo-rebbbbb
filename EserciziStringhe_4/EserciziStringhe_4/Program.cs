using System;

namespace EserciziStringhe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ContaCorte = 0;
            int ContaMedie = 0;
            int ContaLunghe = 0;
            string parola = "";

            while (parola != "fine")
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();
                int lungh = parola.Length;

                if (lungh < 4)
                {
                    ContaCorte++;
                }
                else if (lungh <= 7)
                {
                    ContaMedie++;
                }
                else
                {
                    ContaLunghe++;
                }
            }

            Console.WriteLine($"Le parole più corte di 4 lettere sono {ContaCorte}");
            Console.WriteLine($"Le parole tra 4 e 7 lettere sono {ContaMedie}");
            Console.WriteLine($"Le parole più lunghe di 7 lettere sono {ContaLunghe}");
        }
    }
}
