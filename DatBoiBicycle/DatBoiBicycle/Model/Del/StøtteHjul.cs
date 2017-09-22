using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatBoiBicycle.Model
{
    class StøtteHjul : Del
    {
        public double Længde { get; set; }

        public StøtteHjul(string id, double pris, double længde) :base(id, pris)
        {
            this.Længde = længde;
        }



        public override string DelType()
        {
            return "StøtteHjul";
        }
    }
}
