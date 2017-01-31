/* Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) 
 * valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön. Bonustehtävä: kuinka voisit toteuttaa korttipakan sekoittamisen?
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v6t3 {
	class Program {
		static void Main(string[] args) {
			TestaaHenkiloRekisteri();
		}

		static void TestaaHenkiloRekisteri() {
			//Luodaan taulu joka sisältää maat
			string[] maat = new string[] { "Pata", "Hertta", "Risti", "Ruutu" };
			// luodaan kortti olio
			Pakka korttipakka = new Pakka();
			korttipakka.pakka
			//For looppi joka lisää kaikki kortit pakkaan
			for (int j = 0; j < 3; j++) {
				for (int i = 0; i < 14; i++) {
					Kortit pelikortti = new Kortit { Arvo = i, Maa = maat[j]};
					korttipakka.TeePakka(pelikortti);
				}
			}

			int index = 2;
			//string kortti = String.Format("",korttipakka.AnnaPakka(index));
			Console.WriteLine(pelikortti[1].ToString());

			/*
			Henkilo hlo = new Henkilo { Enimi = "Jack", Snimi = "Russel", Hetu = "312213-123B" };
			Henkilo hlo1 = new Henkilo { Enimi = "Tero", Snimi = "Mursumkaki", Hetu = "442211-123C" };
			Henkilo hlo2 = new Henkilo { Enimi = "Jack", Snimi = "Russel", Hetu = "312213-123B" };
			//Lisätään henkilöt poppooseen
			poppoo.LisaaHenkilo(hlo);
			poppoo.LisaaHenkilo(hlo1);
			poppoo.LisaaHenkilo(hlo2);
			//Tulostetaan poppoo näytölle
			foreach (Henkilo h in poppoo.Henkilolista) {
				Console.WriteLine("{0}", h.ToString());
			}
			//TODO kysy käyttäjältä hetu ja haetaan vastaava henkilö näytölle, jos ei löydy, ei löydy
			Console.WriteLine("Etsi henkilo sotun perusteella: ");
			string syote = Console.ReadLine();
			string tulos = string.Format("" + poppoo.HaeHenkiloHetulla(syote));
			Console.WriteLine(tulos);  */
		}

	}
}
