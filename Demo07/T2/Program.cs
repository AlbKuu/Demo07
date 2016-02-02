/*
* Created: 2.2.2016 
* Authors: Albert Kuusjärvi
*
Tehtävä 2 - luvut tiedostoihinhome Kotitehtävä

Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. 
Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla. 
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number;
            double real;
           // StreamWriter KokoFile = new StreamWriter(@"d:\K2021\Olio\Demo07\kokonais.txt");
            //StreamWriter RealiFile = new StreamWriter(@"d:\K2021\Olio\Demo07\reali.txt");
            do
            {
                Console.WriteLine("Give a number(enter ends)");
                line = Console.ReadLine();

                bool result = int.TryParse(line, out number);
                if (result)
                {
                    StreamWriter KokoFile = new StreamWriter(@"d:\K2021\Olio\Demo07\kokonais.txt");
                    KokoFile.WriteLine(number); //kirjoitetaan levylle!
                    KokoFile.Close(); //suljetaan tiedosto
                }

                bool result2 = double.TryParse(line, out real);
                if (result2)
                {
                    StreamWriter RealiFile = new StreamWriter(@"d:\K2021\Olio\Demo07\reali.txt");
                    RealiFile.WriteLine(number); //kirjoitetaan levylle!
                    RealiFile.Close(); //suljetaan tiedosto
                }
            } while (line.Length != 0);
            //KokoFile.Close(); //suljetaan tiedosto
            //RealiFile.Close;

            
        }
    }
}
