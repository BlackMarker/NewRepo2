using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.IT {
	class Program {
		static void Main(string[] args) {
			TestaaHenkiloRekisteri();
		}

		static void TestaaHenkiloRekisteri() {
			// luodaan muutama testi henkilo 
			Henkilot poppoo = new Henkilot();
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
			Console.WriteLine(tulos);
		}
		
	}
}
