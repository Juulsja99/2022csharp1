using System;

namespace ArrayOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak een array van 10 enemies het onderstaande code blok gaat werken
            string[] enemies = new string[] { "David", "Marlene", "James", "Hunter", "Sniper", "Abby", "Nora", "Manny", "Jordan", "Isac" };


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemy(i);
            }

        }
    
    }

}