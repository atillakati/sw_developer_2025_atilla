using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorenGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetische Operatoren
            // + - * /    %  => RestWertDivision

            //Zusammengesetzte Operatoren oder Incremente/Decrement
            int zahl = 5;

            zahl = zahl + 3;
            zahl += 3;
            zahl -= 2;
            zahl *= 5;
            zahl /= 3;

            zahl += 1;
            zahl++;  //inkrementieren (nur mit ganzen Zahlen)
            zahl--;

            zahl++;  //==> POST Inkrement
            ++zahl;  //==> PRE Inkrement

            zahl = 3;
            Console.WriteLine("Zahl: " + zahl++);
            Console.WriteLine("Zahl: " + ++zahl);

            //Vergleichs Operatoren
            // ==  !=  < >  <=  >=

            //Logische Operatoren
            // & => AND  (&&)
            // | => OR   (||)
            // ! => NOT

            if (datensatz != null && datensatz.Count > 10)
            {

            }

            
        }
    }
}
