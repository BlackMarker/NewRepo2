using System;

namespace V3T1 {
	class Hissi {
		public bool Paalla { get; set; }
		public float Lampo { get; set; }
		int kerros;

		//property
		public int Kerros {
			get {
				return kerros;
			}
			set {
				kerros = value;
				if (kerros < 1 || kerros > 5) {
					kerros = 0;

				}
			}
		}
	}
}

