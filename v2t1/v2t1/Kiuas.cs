using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2t1{
	class Kiuas{
		public bool Paalla { get; set; }
		public float Lampo { get; set; }
		float kosteus;
		
		public float Kosteus{
			get{
				return kosteus;
			}
			set{
				kosteus = value;
				if (kosteus < 0 || kosteus > 100) {
					kosteus = 0;
				}
			}
		}
	}
}
