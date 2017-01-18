/* Tehtävä 3
Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: 
-työntekijän nimi (Name), 
-työntekijän ammatti (Profession) 
-palkka (Salary). 
Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).

Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.

Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)
    Employee:
    - Name:Kirsi Kernel Profession:Teacher Salary:1200
    
    Boss:
    - Name:Jussi Jurkka Profession:Head of Institute Salary:9000 Car:Audi Bonus:5000
    
    Employee:
    - Name:Kirsi Kernel Profession:Principal Teacher Salary:2200
							       ################
								   ##  -WARNING- ##
	###############################################################################
	# Laksy: lue https://msdn.microsoft.com/en-us/library/ms229006(v=vs.110).aspx #
	###############################################################################
*/
using System;


namespace T3V3 {
	class Program {
		static void Main(string[] args) {
			while (true) {
				Console.WriteLine("Mita Haluat tehda: \n1 -Katsoa Henkilotietoja \n2 -Muokata Henkilotietoja");
				int valinta = int.Parse(Console.ReadLine());
				switch (valinta) {
					case 1:
						Nayta();
						break;
					case 2:
						int haluttu = MuokkaaKysely();
						Muokkaa(haluttu);
						break;
					default:
						Console.WriteLine("Syote ei kelpaa");
						break;
				}
			}
			
		}

		static void Nayta() {
			Pomo henkilo1 = new Pomo();
			Tyontekija henkilo2 = new Tyontekija();

			Console.WriteLine("Tyontekijat: \n{0}\n{1}\n", henkilo1.Nimi, henkilo2.Nimi);
		}

		static int MuokkaaKysely() {
			Console.Write("Keta haluat muokata? \n1 -Tyontekija \n2 -Pomo\n");
			int valinta = int.Parse(Console.ReadLine());
			switch (valinta) {
				case 1:
					Console.WriteLine("Mita tietoa haluat muokata: \n1 -Nimi\n2 -Ammatti \n3 -Palkka");
					int valinta2 = int.Parse(Console.ReadLine());
					return (valinta2);

				default:
					Console.Write("Syote ei kelpaa");
					return (0);
					break;
			}
		}

		static int Muokkaa(int syote) {
			Tyontekija henkilo2 = new Tyontekija();

			switch (syote) {
				case 1:
					Console.WriteLine("Anna uusi nimi: ");
					string nimi = Console.ReadLine();
					henkilo2.Nimi = nimi;
					break;

				default:
					break;
			}
			return (0);
		}
	}
}
