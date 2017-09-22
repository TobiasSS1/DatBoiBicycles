using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle.Model
{
    class MountainBike : Cykel
    {
        public string BremseType { get; set; }
        
        public MountainBike(double tommer, double pris, int gear, string bremsetype) :base(tommer, pris, gear)
        {
            this.BremseType = bremsetype;
        }


        public override string CykelType()
        {
            return "Mountainbike";
        }
    }
}
