using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kaksi eri pesu vaihtoehtoa + custom --> kolme eri aliohjelmaa

namespace vat2 {
	class PesukoneLuokka {
		
		public bool TarvitseeHuolto = false;
		public bool Paalla = false;
		public float Lampo { get; set; }
		public string[] pesu = new string[] { "HienoPesu", "KarvaLakkiPesu" };
		/* public float Kosteus{
			get{
				return kosteus;
			}
			set{
				kosteus = value;
				if (kosteus < 0 || kosteus > 100) {
					kosteus = 0;
				}
			}
		} */

	}

	class HienoPesu{

		public bool TarvitseeHuolto = false;
		public bool Paalla = false;
		public float Lampo = 0;


		public string[] pesu = new string[] { "HienoPesu", "KarvaLakkiPesu" };

	}

	class KarvalakkiPesu
	{

		public bool TarvitseeHuolto = false;
		public bool Paalla = false;
		public float Lampo = 0;


		public string[] pesu = new string[] { "HienoPesu", "KarvaLakkiPesu" };

	}
}
