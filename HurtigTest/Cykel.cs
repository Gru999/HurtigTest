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

        public int Pris { get; set; }

        public Cykel(int stelNr, string model, int år, int pris)
        {
            StelNr = stelNr;
            Model = model;
            År = år;
            Pris = pris;
        }


        public override string ToString()
        {
            return $"StelNr: {StelNr}, Model: {Model}, År: {År}";
        }

        public static int EvertonRabatPris(List<Cykel> list) {
            int discount = 0;
            list.ForEach(x =>
            {
                if (x.År < 2020 && x.Model.Equals("Everton"))
                {
                    discount = x.Pris - 250;
                }
            });
            return discount;
        }

    }
}
