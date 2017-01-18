using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2V4
{
    class Vechile{
        public string nimi { get; set; }
        public int nopeus { get; set; }

        public int rengas { get; set; }

        public void PrintData(){
            Console.Write(nimi + "\n" + nopeus + "\n" + rengas);

        }



    }
}
