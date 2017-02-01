/* Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
 * Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, 
 * että kysyt käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen keskiarvo.
 * */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8t2 {
	class Program {
		static void Main(string[] args) { 
			Luokka1 Lk = new Luokka1();
			float tulos = Lk.LaskeKa(int.Parse(Console.ReadLine()));
			Console.WriteLine("Keskiarvo heitoille oli: {0}", tulos);
		}
	}
}
