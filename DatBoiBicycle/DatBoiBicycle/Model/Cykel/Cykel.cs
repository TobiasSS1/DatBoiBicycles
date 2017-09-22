using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle
{
    abstract class Cykel
    {
        public double Tommer { get; set; }
        public double Pris { get; set; }
        public int Gear { get; set; }

        public Cykel()
        {
            
        }

        public Cykel(double tommer, double pris, int gear)
        {
            Tommer = tommer;
            Pris = pris;
            Gear = gear;
        }

        public abstract string CykelType();



    }
}
