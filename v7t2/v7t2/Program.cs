/* Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja kertoo montako nimeä löytyy ja 
 * montako kertaa kukin nimi esiintyy. Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan 
 * onko em.hakemistossa tiedostoa.Käytä File.Exist-metodia.	Huomioi myös muut mahdolliset poikkeukset, joita tiedoston käsittely 
 * voi aiheuttaa.
 * Eli etunimiä spacella tai enterillä eroteltuna, tulosta kaikki, jos halutaan lajitella, lajittele tulostus
 * */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v7t2 {
	class Program {
		static void Main(string[] args) {
			Class1 Luokka1 = new Class1();
			Lajittelu Luokka2 = new Lajittelu();
			Luokka1.LuoTiedosto();
			//Luetaan palautus jos tapahtui virheitä ja jotta saadaan "nimet" taulu
			string[] nimet = Luokka1.LueNimet();
			//Haetaan taulun pituus
			string[] tulos = Luokka2.HaePituus(nimet);
			//string[] lyhennetty = Luokka1.Lyhenna(nimet);
			foreach (string nimi in nimet) {
				Console.WriteLine(nimi);
			}

			//Taulun lajitttelu
			
			string[] lajiteltu = Luokka2.Lajittele(nimet);
			Console.WriteLine(lajiteltu);
		}
	}
}
