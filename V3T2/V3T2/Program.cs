/* Tehtävä 2
Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. Toteuta Vahvistin-luokka 
ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. 
Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
*/

using System;


namespace V3T2 {
	class Program {
		static void Main(string[] args) {
			while (true) {
				Vahvistin volyymi = new Vahvistin();

				Console.WriteLine("Saada aanenvoimakkuutta: ");
				int haluttu = int.Parse(Console.ReadLine());
				volyymi.Volyymi = haluttu;
				Console.WriteLine("Aanenvoimakkuus on: {0}", volyymi.Volyymi);
			}
		}
	}
}
