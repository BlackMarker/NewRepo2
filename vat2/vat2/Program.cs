/* Tehtävä 2
Tehtävänäsi on ohjelmoida pesukoneen toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?

UML

Suunnittele Pesukone-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Ohjelmointi

Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma, jolla luot olion Pesukone-luokasta. Säädä pesukone-oliota erilaisilla arvoilla, 
jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta pesukone-olion käyttäminen jää näkyville. 
Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
*/
using System;


namespace vat2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***Pesukone***");
			Console.WriteLine("Valitse Pesutavat:");
			Console.WriteLine("0 -Lopeta\n1 -HienoPesu\n2 -Ei niin hieno pesu\n3 -Custom pesu");
			int paatos = int.Parse(Console.ReadLine());

			switch (paatos) {
				case 0:
					Console.WriteLine("Case 0");
					break;
				case 1:
					Console.WriteLine("Case 2");

					break;
				case 2:
					Console.WriteLine("Case 2");
					break;
				case 3:
					Console.WriteLine("Case 3");
					break;
				default:
					Console.WriteLine("Syote ei kelpaa");
					break;
			}

		}
		static void Hienopesu(){
			PesukoneLuokka.Lampo = 50;
		}
	}
}
