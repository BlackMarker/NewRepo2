/* Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
 * Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. Tulosta lopuksi kokoelman sisältö.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8t2 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("	OstosKarry \n      **************");
			Class1 Luokka = new Class1();
			Luokka.HaeTuotehinnat();
			Luokka.HaeSisalto();
			Tuote t1 = new v8t2.Tuote { Nimi = "maito", Hinta = 1.9 }
		}
	}
}
