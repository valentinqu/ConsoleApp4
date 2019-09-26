using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //         int Jahr;
        //      Console.WriteLine("Schaltjahre sollen bestimmt werden.");
        //     Console.WriteLine("Ein Jahr eingeben:");
        //     Jahr = Convert.ToInt32(Console.ReadLine());
        //
        //         //Vergleich gleich == ; ungleich != ; größer> ;
        //         //Kleiner < ;größer gleich >= ; kleiner gleich <=
        //
        //         //Bedingungen verknüpfen:
        //         //and &&;or||;
        //        //(a==1 && b==2)
        //         //(a==1 || b==2)
        //         if (Jahr % 4 == 0 && (Jahr % 100 != 0 || Jahr % 400 == 0))
        //    {
        //    Console.WriteLine("Das Jahr " + Jahr + " ist ein Schaltjahr");
        // Console.WriteLine("Das Jahr {0} ist ein Schaltjahr",Jahr);
        // }
        //      else
        //  {
        //  Console.WriteLine("Das Jahr" + Jahr + "ist kein Schaltjahr");
        //  }
        // }




        static void Main(string[] args)
        {

            double AnzahlReiskörner, Feld, Masse, MasseReiskorn, Wahremasse;
            Console.WriteLine("Masse der Reiskörner auf dem Feld erraten");
            Console.WriteLine("Feld angeben");
            Feld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masse schätzen");
            Masse = Convert.ToDouble(Console.ReadLine());
            MasseReiskorn = 0.00005;
            AnzahlReiskörner = Math.Pow(2.0, Feld - 1.0);
            Wahremasse = MasseReiskorn * AnzahlReiskörner;

            if(Masse==Wahremasse)
            {
                Console.WriteLine("Zuviel geschätzt...");
                Console.WriteLine("Die Wahrmasse ist " + Wahremasse);
            }
            else if(Masse < Wahremasse)
            {
                Console.WriteLine("Zuwenig geschätzt");
                Console.WriteLine("Die Wahrmasse ist " + Wahremasse);
            }
            else
            {
                Console.WriteLine("Zuviel geschätzt");
                Console.WriteLine("Die Wahrmasse ist " + Wahremasse);
            }

        }
}
    }