/* Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
 * Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi mahdolliset poikkeukset, 
 * joita tiedoston käsittely voi aiheuttaa.
 * #######################################################################################################################################
 * # (mahdollisuus kokeilla try catchia joko antamalla ekalle valinnalle muuta kuin haluttua tai vaihtamalla tiedosto-osoitetta vääräksi #
 * #######################################################################################################################################
 */

using System;
namespace v7t1 {
	public class program {
		static void Main(string[] args) {
			Class1 Luokka = new Class1(); 
			while (true) {
				//Valinta, tallennetaanko tideoston perään vai päälle 
				int haluttu = Luokka.Valinta();
				Console.WriteLine("Valitsit: " + haluttu);
				//Kysely mitä tallennetaan tiedostoon
				string viesti = Luokka.Kysely(haluttu);
				Luokka.Tallennus(haluttu, viesti);
			}
		}

	}
}
