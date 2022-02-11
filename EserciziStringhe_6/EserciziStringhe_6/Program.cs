using System;

namespace EserciziStringhe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una lettera: ");
            string lettera;
            lettera = Console.ReadLine();
            int ContaFinale = 0;
            string parola = "";

            while (parola != "fine")
            {
                Console.WriteLine("Inserisci una parola: ");
                parola = Console.ReadLine();

                int lungh = parola.Length;

                if (lungh == lettera)
                {
                    ContaFinale++;
                }
            }

            Console.WriteLine($"Le parole che finiscono con la lettera {lettera} sono {ContaFinale}");
        }
    }
}
