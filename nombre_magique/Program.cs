using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DemanderNombre()
        {
            int nombre_num = 0;
            while (nombre_num == 0)
            {
                Console.Write("entrez un nombre: ");
                string nombre_str = Console.ReadLine();

                try
                {
                    nombre_num = int.Parse(nombre_str);
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
            int nombre = DemanderNombre();
            Console.WriteLine("votre nombre est: " + nombre);
        }
    }
}