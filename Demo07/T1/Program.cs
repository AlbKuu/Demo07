/*
* Created: 2.2.2016 
* Authors: Albert Kuusjärvi
*
*Tehtävä 1 - Tiedostoon kirjoittaminen ja lukeminen
*Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
*Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin.
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            StreamWriter outputFile = new StreamWriter(@"d:\K2021\Olio\Demo07\text.txt");
            //käyttäjältä kysytään rivejä
            do
            {
                Console.Write("Give a text line (enter stops) : ");
                line = Console.ReadLine();
                outputFile.WriteLine(line); //kirjoitetaan levylle!
            } while (line.Length!=0);
            //suljetaan tiedosto
            outputFile.Close();

            try{
                //avaa tiedosto
                string[] lines = File.ReadAllLines(@"d:\K2021\Olio\Demo07\text.txt");
                //näytä sisältö
                foreach (string line2 in lines)
                {
                    Console.WriteLine(line2);
                }
            }catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
