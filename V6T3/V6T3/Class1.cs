using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v6t3 {
	/// <summary>
	/// Pelikorttien ominaisuudet
	/// </summary>
	class Kortit {
		public string Maa { get; set; }
		public int Arvo { get; set; }
		public override string ToString() {
			return Maa + Arvo;
		}
	}

	///This class holds person information in a collection
	///
	class Pakka {
		//Luodaan lista johonka tehdään korttipakka
		//luodaan lista "pakka" Kortit ominaisuuksilla ja aliohjelma nimeltä Kortit() joka tekee sen
		private List<Kortit> pakka;
		public Pakka() {
			pakka = new List<Kortit>();
		}
		//Aliohjelma joka lisää aina kortin pakkaan
		public void TeePakka(Kortit kortti) {
			pakka.Add(kortti);
		}
		//Palauttaa pakasta kortin indexin mukaan (mikäli indexi on 1-52)
		public Kortit AnnaPakka(int index) {
			if (index < 53 && index > 0) {
				return (pakka[index]);
			}
			else {
				return null;
			}
		}
	}
}
