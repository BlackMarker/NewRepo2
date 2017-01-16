/* Tehtävä 1
Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois, sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään 
(arvoja ei ole rajattu).

Ohjelmointi

Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta. Säädä kiuas-oliota erilaisilla arvoilla, 
jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta kiuas-olion käyttäminen jää näkyville.
*/

using System;


namespace v2t1{


	class Program{
		static void Main(string[] args){
			TestaaKiuas();
		}

		//t1 luokan kiuas testaus
		static void TestaaKiuas(){
			//luodaan kiuas olio
			Kiuas kiuas = new Kiuas();
			//Kiuas tulille ja lämp/kost
			kiuas.Paalla = true;
			kiuas.Lampo = 90;
			kiuas.Kosteus = 50;
			Console.WriteLine("Kiuas on paalla {0}", kiuas.Paalla);
			Console.WriteLine("Kiukaan lampotila {0}*C\nKiukaan kosteus {1}%", kiuas.Lampo, kiuas.Kosteus);
			kiuas.Kosteus = 5000; 
			Console.WriteLine(kiuas.Kosteus);
		}
	}
}
