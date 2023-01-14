using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nombre_num = 0;
            while ((nombre_num < min) || (nombre_num > max))
            {
                Console.Write("entrez un nombre: ");
                string nombre_str = Console.ReadLine();

                try
                {
                    nombre_num = int.Parse(nombre_str);
                    
                    if((nombre_num < min) || (nombre_num > max))
                    {
                        Console.WriteLine("Erreur: Veillez entrez un nombre compris entre " + min + " et " + max);
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur: Ce nombre n'est pas valide.");
                }
            }
            return nombre_num;
        }

        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;

            Random rand = new Random();
            int nombreMagique = rand.Next(1, 11);

            int nombre = 0;

            while (nombre != nombreMagique)
            {
                nombre = DemanderNombre(min, max); 
                if (nombre < nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else if (nombre > nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
            }
        }
    }
}