using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herjoittelua
{
    class Program
    {
        static void Main(string[] args){
			string moi = ". . .";
			string jee = Muokkaa(moi);
			string pala = "Toimii 1";
			Tulosta(pala, jee);

        }

        static void Tulosta(string pala, string jee){
			
			Luokka teksti = new Luokka();
			Console.WriteLine("Paaohjelmasta teksti: {0}\nAliohjelmasta teksti {1}", pala, jee);


        }
		static string Muokkaa(string moi) {
			Luokka teksti = new Luokka();
			moi = "Juuso Osaa aliohjelmat";
			return (moi);
		}
    }
}
