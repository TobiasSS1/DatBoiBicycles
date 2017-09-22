using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle.Model
{
    class DameCykel : Cykel
    {
        public bool CykelKurv { get; set; }


        public DameCykel(double tommer, double pris, int gear, bool cykelkurv) :base(tommer, pris, gear)
        {
            this.CykelKurv = cykelkurv;
        }


        public override string CykelType()
        {
            return "Damecykel";
        }
    }
}
