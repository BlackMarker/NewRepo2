using System;


namespace T3V3 {
	class Henkilo {
		public string Nimi { get; set; }
		public string Ammatti { get; set; }
		public int Palkka { get; set; }
	}

	class Tyontekija : Henkilo {
		
	}
	class Pomo : Henkilo {
		public int Bonus { get; set; }
		public string Auto { get; set; }
	}
}
