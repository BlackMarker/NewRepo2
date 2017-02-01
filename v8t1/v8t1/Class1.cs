using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v8t2 {
	class Luokka1 {
		public float LaskeKa(float heittoja) {
			Console.WriteLine("Saatiin {0}", heittoja);
			Random luvut1 = new Random();
			Thread.Sleep(1000);
			int summa = 0;
			for (int i = 0; i < heittoja; i++) {
				int luku = luvut1.Next(2, 6);
				summa = summa + luku;
				Console.WriteLine("Arvottiin luku {0}", luku);
			}
			float summa2 = (float)summa;
			float heittoja2 = (float)heittoja;
			float ka = summa2 / heittoja2;
			Console.WriteLine("heittoja {0} summa {1}", heittoja2, summa2);
			return (ka);
		}
	}
}
