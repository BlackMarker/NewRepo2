/* Tehtävä 1
Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla 
(nimi, malli) ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. 
taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). Tee pääohjelma, 
jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.
*/

using System;
using System.Collections.Generic;

namespace v5t1 {
	class Program {
		static void Main(string[] args) {
			TestCarWithFourWheelsV2();
		}

		static void TestCarWithFourWheelsV2() {
			// create tyre
			Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", Rengaskoko = "205R16" };
			// create a car
			Auto kaara = new Auto { Nimi = "Porsche", Malli = "911" };
			Console.WriteLine("Luotu uusi pirssi {0} {1}", kaara.Nimi, kaara.Malli);
			kaara.LisääRengas(tyre1);
			kaara.LisääRengas(tyre1);
			kaara.LisääRengas(tyre1);
			kaara.LisääRengas(tyre1);
			kaara.LisääRengas(tyre1);
			Console.WriteLine(kaara.ToString());
		}

	}
}
