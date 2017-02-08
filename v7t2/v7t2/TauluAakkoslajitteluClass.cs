using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v7t2 {
	class Lajittelu {
		public string[] HaePituus(string[] taulu) {
			//haetaan taulun pituus try avulla
			int pituus = 0;
			while (true) {
				try {
					string toimii = taulu[pituus];
					pituus++;
				}
				catch (Exception) {
					pituus--; 
					break;
				}
			}
			//tallennetaan pituus taulu 0, paikkaan
			string[] tulos = new string[] { String.Format("" + pituus) };
			return (tulos);
		}
	}
}
