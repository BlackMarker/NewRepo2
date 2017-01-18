/* Luo Vehicle-luokka seuraavien tietojen mukaisesti:

ominaisuudet

Name:string
Speed:int
Tyres:int
toiminnot

PrintData(), tulostaa Vehiclen ominaisuudet näytölle
ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona
Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. Muuta olion arvoja ja tulosta olion arvoja konsolille.
*/

using System;

namespace T2V4
{
    class Program
    {
        static void Main(string[] args){
            Vechile auto = new Vechile();
            auto.PrintData();

        }

        
    }


}
