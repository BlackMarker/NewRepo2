using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.IT {
	/// <summary>
	/// This class contains person properties
	/// </summary>
	/// Henkilöiden ominaisuudet
	class Henkilo {
		public string Enimi { get; set; }
		public string Snimi { get; set; }
		public string Hetu { get; set; }
		public override string ToString() {
			return Enimi + " " + Snimi + " " + Hetu;
		}
	}

	///This class holds person information in a collection
	///
	class Henkilot {
		//luodaan lista "Henkilo" ominaisuuksilla ja aliohjelma nimeltä Henkilot() joka tekee sen
		private List<Henkilo> henkilot;
		public Henkilot() {
			henkilot = new List<Henkilo>();
		}

		//Palauttaa henkilot listan
		public List<Henkilo> Henkilolista {
			get { return henkilot; }
		}

		//Lisää henkilön listaan (saa henkilön parametrina)
		public void LisaaHenkilo(Henkilo hlo) {
			henkilot.Add(hlo);
		}

		//Hakee henkilön listasta ja palauttaa indexinumeron
		public Henkilo HaeHenkilo(int index) {
			if (index < henkilot.Count) {
				return henkilot.ElementAt(index);
			}
			else {
				return null;
			}
		}

		//Hakee listasta foreachilla hetun mukaan ja palauttaa sen
		public Henkilo HaeHenkiloHetulla(string hetu) {
			foreach (Henkilo hlo in henkilot) {
				if (hlo.Hetu == hetu) {
					return hlo;
				}

			}
			return null;
		}
	}
}
