using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurtigTest
{
    public class Cykel
    {
        

        public int StelNr { get; set; }
        public string Model { get; set; }
        public int År { get; set; }

        public Cykel(int stelNr, string model, int år)
        {
            StelNr = stelNr;
            Model = model;
            År = år;
            
        }


        public override string ToString()
        {
            return $"StelNr: {StelNr}, Model: {Model}, År: {År}";
        }

    }
}
