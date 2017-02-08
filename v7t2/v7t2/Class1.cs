using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v7t2 {
	class Class1 {
		public void LuoTiedosto() {
			File.WriteAllText("nimet.txt", "Matias Eino Kyosti Tarja Jonna Leevi Matias Juuso Tare Jalmari Kyosti Matias Fredrick Kalle Eino Tarja Mikko Eetu");
		}
		public string[] LueNimet() {
			string polku = "nimet.txt";
			if (OnkoTiedosto(polku) == true) {
				string teksti = File.ReadAllText(polku);
				string[] nimet = teksti.Split(' ');
				
				return (nimet);
			}
			//jos jokin meni mönkään tiedostoa luettaessa
			else {
				string[] virhe = new string[] { "Virhe! tiedostoa ei loytynyt" }; 
				return (virhe);
			}
		}
		//taulun lyhentaminen (verrataan jokaista taulun paikkaa keskenaan)
		public string[] Lyhenna(string[] taulu, int pituus) {
			string[] taulu2 = new string[pituus];
			//for looppi täyttämään taulu
			for (int i = 0; i < pituus; i++) {
				taulu2[i] = "0";
			}
			//Luodaan taulu sanojen esiintymisen lukumaaran tallentamiseen
			int[] taulu3 = new int[pituus];
			//Heitetaan taulun nimet listaan ellei sita ole jo

			//j on toisen taulun indexi
			int j = 0;
			for (int i = 0; i < pituus; i++) {
				string nimi = taulu[i];
				//onko "taulu":ssa jo taulu2 nimi --> jos on numero lisää esiintyviin sanoihin
				if (taulu[i] == taulu2[i]) {
					taulu3[i]++;
				}
				else {
					//jos ei ole onko taulu "tyhjä" eli 0
					if (taulu2[i] == "0") {
						//lisää nimi tauluun 2
						taulu2[i] = taulu[i];
					}
				}
			}
			return (taulu);
		}
		//onko nimi listassa
		public bool OnkoListassa(string nimi, List<string> lista) {
			foreach (string sana in lista) {
				int i = 0;
				if (lista[i].Contains(nimi)) {
					return (true);
				}
				else {
					return (false);
				}
			}
			//tätä ei koskaan käydä, ellei foreach kaadu
			return (false);
		}
		//Loytyykö kyseinen tiedosto
		public bool OnkoTiedosto(string polku) {
			bool loytyy = File.Exists(polku);
			return (loytyy);
		}
	}
}
