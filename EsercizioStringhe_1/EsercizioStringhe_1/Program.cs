using System;

namespace EsercizioStringhe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int N;
                Console.WriteLine("Quante parole vuoi inserire? ");
                N = Convert.ToInt32(Console.ReadLine());

                int ContaVocali = 0;
                int ContaConsonanti = 0;
                int i = 0;
    
                string parola;
                
                while (i < N)
                {
                    Console.WriteLine("Inserisci una parola: ");
                    parola = Console.ReadLine();
                    
                    char primoCarattere = parola[0];
                    
                    if (primoCarattere == 'a')
                    {
                        ContaVocali++;
                    }
                    else if (primoCarattere == 'e')
                    {
                        ContaVocali++;
                    }
                    else if (primoCarattere == 'i')
                    {
                        ContaVocali++;
                    }
                    else if (primoCarattere == 'o')
                    {
                        ContaVocali++;
                    }
                    else if (primoCarattere == 'u')
                    {
                        ContaVocali++;
                    }
                    else
                    {
                        ContaConsonanti++;
                    }
                }
                Console.WriteLine($"Le parole che iniziano per vocale sono: {ContaVocali}");
                Console.WriteLine($"Le parole che iniziano per consonante sono: {ContaConsonanti}");
        }
    }
}
