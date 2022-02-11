using System;

namespace EserciziStringhe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una lettera: ");
            string lettera = Console.ReadLine();
            int ContaIniziali = 0;
            string parola = "";

            while (parola != "fine") ;
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();

                char primaLettera = parola[0];
                if (primaLettera == lettera[0])
                {
                    ContaIniziali++;
                }
            }

            Console.WriteLine($"Le parole che iniziano con la lettera {lettera} sono {ContaIniziali}");
        }
    }
}
