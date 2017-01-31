/* Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
 * Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi mahdolliset poikkeukset, 
 * joita tiedoston käsittely voi aiheuttaa.
 * #######################################################################################################################################
 * # (mahdollisuus kokeilla try catchia joko antamalla ekalle valinnalle muuta kuin haluttua tai vaihtamalla tiedosto-osoitetta vääräksi #
 * #######################################################################################################################################
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
			while (true) {
				//Valinta, tallennetaanko tideoston perään vai päälle
				int haluttu = Valinta();
				Console.WriteLine("Valitsit: " + haluttu);
				//Kysely mitä tallennetaan tiedostoon
				string viesti = Kysely(haluttu);
				Tallennus(haluttu, viesti);
			}
		}

		static string Kysely(int haluttu) {
			if (haluttu != 3) {
				Console.WriteLine("Mita tallennetaan tiedostoon: ");
				string asia = Console.ReadLine();
				return (asia);
			}
			else {
				return ("3");
			}
			

		}

		static int Valinta() {
			//switch case jotta syöte ei riko ohjelmaa (voisi tehdä myös pelkällä syötteen tarkistuksella
			Console.WriteLine("1 -Tallenna tiedoston peraan \n2 -Tallenna tiedoston paalle\n3 -Luetaan tiedosto:\n");
			switch (Console.ReadLine()) {
				case "1":
					return (1);
					break;
				case "2":
					return (2);
					break;
				case "3":
					return (3);
					break;
				default:
					Console.WriteLine("Syote ei kelpaa");
					return (5);
					break;
			}
		}

		static int Tallennus(int haluttu, string viesti) {
			switch (haluttu) {
				case 1:
					try {
						//käytetään streamwriteriä jotta voidaaan tallentaa tietoa perään, pyyhkimättä sitä
						using (StreamWriter harpake = File.AppendText("Kirje.txt")) {
							harpake.WriteLine(viesti);
						}
						Console.WriteLine("Tallennettiin peraan onnistuneesti");
						return 0;
					}
					catch (Exception) {
						Virhe();
						return (1);
					}
					break;
				//Tiedoston päälle kirjoitus
				case 2:
					try {
						File.WriteAllText("Kirje.txt", viesti);
						Console.WriteLine("Tallennettiin paalle onnistuneesti");
						return 0;
					}
					//Jos homma kaatui heitä virheilmotus
					catch (Exception) {
						Virhe();
						return (1);
					}
					break;
				//Tiedoston luku
				case 3:
					try {
						string teksti = File.ReadAllText("Kirje.txt");
						Console.WriteLine("teksti:\n######################\n" + teksti + "\n######################\n");
						return 0;
					}
					catch (Exception) {
						Virhe();
						return (1);
					}
					break;
				default:
					Console.WriteLine("Jotain tapahtui");
					return 9;
					break;
			}
		}
		//virheilmotus
		static void Virhe() {
			Console.WriteLine("Jotain tapahtui :(\n\n:'DDDD\n   <Heh heh heh!\n");
		}


	}
}
