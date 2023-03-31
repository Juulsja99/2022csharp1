using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (value < Leeftijd) 
                {
                    leeftijd = value;
                    Console.WriteLine("Geen probleem even iets ouder");
                }
                else
                {
                    Console.WriteLine("Dat kan niet");
                }
            }
        }
        
        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}