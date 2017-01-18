using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3T2 {
	class Vahvistin {
		int volyymi;

		public int Volyymi {
			get {
				return volyymi;
			}
			set {
				volyymi = value;
				if ( volyymi > 100) {
					volyymi = 100;
				}
				if (volyymi < 0 ) {
					volyymi = 0;
				}
			}
		}

	}
}
