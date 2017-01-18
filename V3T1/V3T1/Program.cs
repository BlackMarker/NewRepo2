/* Tehtävä 1
Tehtävänäsi on ohjelmoida Dynamon hissin kerroksen ohjaukseen liittyvä säädin. Toteutetun ohjelman tulee pystyä kysymään käyttäjältä haluttu kerros 
ja siirtämään hissi haluttuun kerrokseen (tässä tapauksessa ohjelma kertoo käyttäjälle missä kerroksessa hissi on). 
Muista, että Dynamon hissi voi olla vain kerroksissa 1-5. Käytä Hissi-luokassa get- ja set-aksessoreita suojamaan olion tila.
*/
using System;

namespace V3T1 {
	class Program {
		static void Main(string[] args) {
			TestaaKiuas();
		}

		
		static void TestaaKiuas() {
			//luodaan hissi olio
			Hissi hissi = new Hissi();
			hissi.Kerros = 5;
			while (true) {
				Console.WriteLine("Mihinka kerrokseen haluat: ");
				int haluttu = int.Parse(Console.ReadLine());
				hissi.Kerros = haluttu;
				if (hissi.Kerros == 0) {
					Console.WriteLine("Sellaista kerrosta ei ole");
				}
				else {
					Console.WriteLine("Hissi on nyt {0}:ssa kerroksessa", hissi.Kerros);
				}
			}

		}
	}
}
