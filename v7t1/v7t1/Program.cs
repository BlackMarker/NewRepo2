/* Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
 * Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi mahdolliset poikkeukset, 
 * joita tiedoston käsittely voi aiheuttaa.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v7t1 {
	class Program {
		static void Main(string[] args) {
			//Valinta, tallennetaanko tideoston perään vai päälle
			int haluttu = Valinta();
			Console.WriteLine("Valitsit: " + haluttu);
			//Kysely mitä tallennetaan
			Kysely();
		}

		static string Kysely() {
			Console.WriteLine("Mita tallennetaan tiedostoon: ");
			string asia = Console.ReadLine();
			return ("0");
			

		}

		static int Valinta() {
			Console.WriteLine("Tallennetaanko: \n1 -Tiedoston peraan \n2 -Tiedoston paalle");
			switch (Console.ReadLine()) {
				case "1":
					return (1);
					break;
				case "2":
					return (2);
					break;
				default:
					Console.WriteLine("Syote ei kelpaa");
					return (0);
					break;
			}
		}


	}
}
